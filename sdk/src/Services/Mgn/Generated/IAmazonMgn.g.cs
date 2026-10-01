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
using Amazon.Mgn.Model;

#pragma warning disable CS1570

namespace Amazon.Mgn
{
    /// <summary>
    /// <para>Interface for accessing Mgn</para>
    ///
    /// Application Migration Service.
    /// </summary>
    public partial interface IAmazonMgn : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMgnPaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Archive application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ArchiveApplication service method.</param>
        /// <returns>The response from the ArchiveApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ArchiveApplication">REST API Reference for ArchiveApplication Operation</seealso>
        ArchiveApplicationResponse ArchiveApplication(ArchiveApplicationRequest request);
#endif

        /// <summary>
        /// Archive application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ArchiveApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ArchiveApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ArchiveApplication">REST API Reference for ArchiveApplication Operation</seealso>
        Task<ArchiveApplicationResponse> ArchiveApplicationAsync(ArchiveApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Archive wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ArchiveWave service method.</param>
        /// <returns>The response from the ArchiveWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ArchiveWave">REST API Reference for ArchiveWave Operation</seealso>
        ArchiveWaveResponse ArchiveWave(ArchiveWaveRequest request);
#endif

        /// <summary>
        /// Archive wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ArchiveWave service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ArchiveWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ArchiveWave">REST API Reference for ArchiveWave Operation</seealso>
        Task<ArchiveWaveResponse> ArchiveWaveAsync(ArchiveWaveRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Associate applications to wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateApplications service method.</param>
        /// <returns>The response from the AssociateApplications service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/AssociateApplications">REST API Reference for AssociateApplications Operation</seealso>
        AssociateApplicationsResponse AssociateApplications(AssociateApplicationsRequest request);
#endif

        /// <summary>
        /// Associate applications to wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AssociateApplications service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/AssociateApplications">REST API Reference for AssociateApplications Operation</seealso>
        Task<AssociateApplicationsResponse> AssociateApplicationsAsync(AssociateApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Associate source servers to application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSourceServers service method.</param>
        /// <returns>The response from the AssociateSourceServers service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/AssociateSourceServers">REST API Reference for AssociateSourceServers Operation</seealso>
        AssociateSourceServersResponse AssociateSourceServers(AssociateSourceServersRequest request);
#endif

        /// <summary>
        /// Associate source servers to application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSourceServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AssociateSourceServers service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/AssociateSourceServers">REST API Reference for AssociateSourceServers Operation</seealso>
        Task<AssociateSourceServersResponse> AssociateSourceServersAsync(AssociateSourceServersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Allows the user to set the SourceServer.LifeCycle.state property for specific Source
        /// Server IDs to one of the following: READY_FOR_TEST or READY_FOR_CUTOVER. This command
        /// only works if the Source Server is already launchable (dataReplicationInfo.lagDuration
        /// is not null.)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeServerLifeCycleState service method.</param>
        /// <returns>The response from the ChangeServerLifeCycleState service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ChangeServerLifeCycleState">REST API Reference for ChangeServerLifeCycleState Operation</seealso>
        ChangeServerLifeCycleStateResponse ChangeServerLifeCycleState(ChangeServerLifeCycleStateRequest request);
#endif

        /// <summary>
        /// Allows the user to set the SourceServer.LifeCycle.state property for specific Source
        /// Server IDs to one of the following: READY_FOR_TEST or READY_FOR_CUTOVER. This command
        /// only works if the Source Server is already launchable (dataReplicationInfo.lagDuration
        /// is not null.)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeServerLifeCycleState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ChangeServerLifeCycleState service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ChangeServerLifeCycleState">REST API Reference for ChangeServerLifeCycleState Operation</seealso>
        Task<ChangeServerLifeCycleStateResponse> ChangeServerLifeCycleStateAsync(ChangeServerLifeCycleStateRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Create application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <returns>The response from the CreateApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse CreateApplication(CreateApplicationRequest request);
#endif

        /// <summary>
        /// Create application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Create Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector service method.</param>
        /// <returns>The response from the CreateConnector service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        CreateConnectorResponse CreateConnector(CreateConnectorRequest request);
#endif

        /// <summary>
        /// Create Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateConnector service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        Task<CreateConnectorResponse> CreateConnectorAsync(CreateConnectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new Launch Configuration Template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfigurationTemplate service method.</param>
        /// <returns>The response from the CreateLaunchConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateLaunchConfigurationTemplate">REST API Reference for CreateLaunchConfigurationTemplate Operation</seealso>
        CreateLaunchConfigurationTemplateResponse CreateLaunchConfigurationTemplate(CreateLaunchConfigurationTemplateRequest request);
#endif

        /// <summary>
        /// Creates a new Launch Configuration Template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateLaunchConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateLaunchConfigurationTemplate">REST API Reference for CreateLaunchConfigurationTemplate Operation</seealso>
        Task<CreateLaunchConfigurationTemplateResponse> CreateLaunchConfigurationTemplateAsync(CreateLaunchConfigurationTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new network migration definition that specifies the source and target network
        /// configuration for a migration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkMigrationDefinition service method.</param>
        /// <returns>The response from the CreateNetworkMigrationDefinition service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateNetworkMigrationDefinition">REST API Reference for CreateNetworkMigrationDefinition Operation</seealso>
        CreateNetworkMigrationDefinitionResponse CreateNetworkMigrationDefinition(CreateNetworkMigrationDefinitionRequest request);
#endif

        /// <summary>
        /// Creates a new network migration definition that specifies the source and target network
        /// configuration for a migration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkMigrationDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateNetworkMigrationDefinition service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateNetworkMigrationDefinition">REST API Reference for CreateNetworkMigrationDefinition Operation</seealso>
        Task<CreateNetworkMigrationDefinitionResponse> CreateNetworkMigrationDefinitionAsync(CreateNetworkMigrationDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new ReplicationConfigurationTemplate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationConfigurationTemplate service method.</param>
        /// <returns>The response from the CreateReplicationConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateReplicationConfigurationTemplate">REST API Reference for CreateReplicationConfigurationTemplate Operation</seealso>
        CreateReplicationConfigurationTemplateResponse CreateReplicationConfigurationTemplate(CreateReplicationConfigurationTemplateRequest request);
#endif

        /// <summary>
        /// Creates a new ReplicationConfigurationTemplate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateReplicationConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateReplicationConfigurationTemplate">REST API Reference for CreateReplicationConfigurationTemplate Operation</seealso>
        Task<CreateReplicationConfigurationTemplateResponse> CreateReplicationConfigurationTemplateAsync(CreateReplicationConfigurationTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Create wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWave service method.</param>
        /// <returns>The response from the CreateWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateWave">REST API Reference for CreateWave Operation</seealso>
        CreateWaveResponse CreateWave(CreateWaveRequest request);
#endif

        /// <summary>
        /// Create wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWave service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateWave">REST API Reference for CreateWave Operation</seealso>
        Task<CreateWaveResponse> CreateWaveAsync(CreateWaveRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Delete application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <returns>The response from the DeleteApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request);
#endif

        /// <summary>
        /// Delete application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Delete Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector service method.</param>
        /// <returns>The response from the DeleteConnector service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        DeleteConnectorResponse DeleteConnector(DeleteConnectorRequest request);
#endif

        /// <summary>
        /// Delete Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteConnector service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        Task<DeleteConnectorResponse> DeleteConnectorAsync(DeleteConnectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a single Job by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// <returns>The response from the DeleteJob service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        DeleteJobResponse DeleteJob(DeleteJobRequest request);
#endif

        /// <summary>
        /// Deletes a single Job by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteJob service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a single Launch Configuration Template by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfigurationTemplate service method.</param>
        /// <returns>The response from the DeleteLaunchConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteLaunchConfigurationTemplate">REST API Reference for DeleteLaunchConfigurationTemplate Operation</seealso>
        DeleteLaunchConfigurationTemplateResponse DeleteLaunchConfigurationTemplate(DeleteLaunchConfigurationTemplateRequest request);
#endif

        /// <summary>
        /// Deletes a single Launch Configuration Template by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteLaunchConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteLaunchConfigurationTemplate">REST API Reference for DeleteLaunchConfigurationTemplate Operation</seealso>
        Task<DeleteLaunchConfigurationTemplateResponse> DeleteLaunchConfigurationTemplateAsync(DeleteLaunchConfigurationTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a network migration definition. This operation removes the migration definition
        /// and all associated metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkMigrationDefinition service method.</param>
        /// <returns>The response from the DeleteNetworkMigrationDefinition service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteNetworkMigrationDefinition">REST API Reference for DeleteNetworkMigrationDefinition Operation</seealso>
        DeleteNetworkMigrationDefinitionResponse DeleteNetworkMigrationDefinition(DeleteNetworkMigrationDefinitionRequest request);
#endif

        /// <summary>
        /// Deletes a network migration definition. This operation removes the migration definition
        /// and all associated metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkMigrationDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteNetworkMigrationDefinition service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteNetworkMigrationDefinition">REST API Reference for DeleteNetworkMigrationDefinition Operation</seealso>
        Task<DeleteNetworkMigrationDefinitionResponse> DeleteNetworkMigrationDefinitionAsync(DeleteNetworkMigrationDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a single Replication Configuration Template by ID
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationConfigurationTemplate service method.</param>
        /// <returns>The response from the DeleteReplicationConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteReplicationConfigurationTemplate">REST API Reference for DeleteReplicationConfigurationTemplate Operation</seealso>
        DeleteReplicationConfigurationTemplateResponse DeleteReplicationConfigurationTemplate(DeleteReplicationConfigurationTemplateRequest request);
#endif

        /// <summary>
        /// Deletes a single Replication Configuration Template by ID
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteReplicationConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteReplicationConfigurationTemplate">REST API Reference for DeleteReplicationConfigurationTemplate Operation</seealso>
        Task<DeleteReplicationConfigurationTemplateResponse> DeleteReplicationConfigurationTemplateAsync(DeleteReplicationConfigurationTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a single source server by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceServer service method.</param>
        /// <returns>The response from the DeleteSourceServer service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteSourceServer">REST API Reference for DeleteSourceServer Operation</seealso>
        DeleteSourceServerResponse DeleteSourceServer(DeleteSourceServerRequest request);
#endif

        /// <summary>
        /// Deletes a single source server by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteSourceServer service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteSourceServer">REST API Reference for DeleteSourceServer Operation</seealso>
        Task<DeleteSourceServerResponse> DeleteSourceServerAsync(DeleteSourceServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a given vCenter client by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVcenterClient service method.</param>
        /// <returns>The response from the DeleteVcenterClient service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteVcenterClient">REST API Reference for DeleteVcenterClient Operation</seealso>
        DeleteVcenterClientResponse DeleteVcenterClient(DeleteVcenterClientRequest request);
#endif

        /// <summary>
        /// Deletes a given vCenter client by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVcenterClient service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteVcenterClient service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteVcenterClient">REST API Reference for DeleteVcenterClient Operation</seealso>
        Task<DeleteVcenterClientResponse> DeleteVcenterClientAsync(DeleteVcenterClientRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Delete wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWave service method.</param>
        /// <returns>The response from the DeleteWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteWave">REST API Reference for DeleteWave Operation</seealso>
        DeleteWaveResponse DeleteWave(DeleteWaveRequest request);
#endif

        /// <summary>
        /// Delete wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWave service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteWave">REST API Reference for DeleteWave Operation</seealso>
        Task<DeleteWaveResponse> DeleteWaveAsync(DeleteWaveRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves detailed job log items with paging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobLogItems service method.</param>
        /// <returns>The response from the DescribeJobLogItems service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeJobLogItems">REST API Reference for DescribeJobLogItems Operation</seealso>
        DescribeJobLogItemsResponse DescribeJobLogItems(DescribeJobLogItemsRequest request);
#endif

        /// <summary>
        /// Retrieves detailed job log items with paging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobLogItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeJobLogItems service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeJobLogItems">REST API Reference for DescribeJobLogItems Operation</seealso>
        Task<DescribeJobLogItemsResponse> DescribeJobLogItemsAsync(DescribeJobLogItemsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of Jobs. Use the jobIDs and fromDate and toDate filters to limit which
        /// jobs are returned. The response is sorted by creationDateTime - latest date first.
        /// Jobs are normally created by the StartTest, StartCutover, and TerminateTargetInstances
        /// APIs. Jobs are also created by DiagnosticLaunch and TerminateDiagnosticInstances,
        /// which are APIs available only to *Support* and only used in response to relevant support
        /// tickets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobs service method.</param>
        /// <returns>The response from the DescribeJobs service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeJobs">REST API Reference for DescribeJobs Operation</seealso>
        DescribeJobsResponse DescribeJobs(DescribeJobsRequest request);
#endif

        /// <summary>
        /// Returns a list of Jobs. Use the jobIDs and fromDate and toDate filters to limit which
        /// jobs are returned. The response is sorted by creationDateTime - latest date first.
        /// Jobs are normally created by the StartTest, StartCutover, and TerminateTargetInstances
        /// APIs. Jobs are also created by DiagnosticLaunch and TerminateDiagnosticInstances,
        /// which are APIs available only to *Support* and only used in response to relevant support
        /// tickets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeJobs service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeJobs">REST API Reference for DescribeJobs Operation</seealso>
        Task<DescribeJobsResponse> DescribeJobsAsync(DescribeJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists all Launch Configuration Templates, filtered by Launch Configuration Template
        /// IDs
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurationTemplates service method.</param>
        /// <returns>The response from the DescribeLaunchConfigurationTemplates service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeLaunchConfigurationTemplates">REST API Reference for DescribeLaunchConfigurationTemplates Operation</seealso>
        DescribeLaunchConfigurationTemplatesResponse DescribeLaunchConfigurationTemplates(DescribeLaunchConfigurationTemplatesRequest request);
#endif

        /// <summary>
        /// Lists all Launch Configuration Templates, filtered by Launch Configuration Template
        /// IDs
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurationTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeLaunchConfigurationTemplates service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeLaunchConfigurationTemplates">REST API Reference for DescribeLaunchConfigurationTemplates Operation</seealso>
        Task<DescribeLaunchConfigurationTemplatesResponse> DescribeLaunchConfigurationTemplatesAsync(DescribeLaunchConfigurationTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists all ReplicationConfigurationTemplates, filtered by replication configuration
        /// template IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationConfigurationTemplates service method.</param>
        /// <returns>The response from the DescribeReplicationConfigurationTemplates service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeReplicationConfigurationTemplates">REST API Reference for DescribeReplicationConfigurationTemplates Operation</seealso>
        DescribeReplicationConfigurationTemplatesResponse DescribeReplicationConfigurationTemplates(DescribeReplicationConfigurationTemplatesRequest request);
#endif

        /// <summary>
        /// Lists all ReplicationConfigurationTemplates, filtered by replication configuration
        /// template IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationConfigurationTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeReplicationConfigurationTemplates service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeReplicationConfigurationTemplates">REST API Reference for DescribeReplicationConfigurationTemplates Operation</seealso>
        Task<DescribeReplicationConfigurationTemplatesResponse> DescribeReplicationConfigurationTemplatesAsync(DescribeReplicationConfigurationTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves all SourceServers or multiple SourceServers by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceServers service method.</param>
        /// <returns>The response from the DescribeSourceServers service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeSourceServers">REST API Reference for DescribeSourceServers Operation</seealso>
        DescribeSourceServersResponse DescribeSourceServers(DescribeSourceServersRequest request);
#endif

        /// <summary>
        /// Retrieves all SourceServers or multiple SourceServers by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeSourceServers service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeSourceServers">REST API Reference for DescribeSourceServers Operation</seealso>
        Task<DescribeSourceServersResponse> DescribeSourceServersAsync(DescribeSourceServersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of the installed vCenter clients.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVcenterClients service method.</param>
        /// <returns>The response from the DescribeVcenterClients service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeVcenterClients">REST API Reference for DescribeVcenterClients Operation</seealso>
        DescribeVcenterClientsResponse DescribeVcenterClients(DescribeVcenterClientsRequest request);
#endif

        /// <summary>
        /// Returns a list of the installed vCenter clients.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVcenterClients service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeVcenterClients service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeVcenterClients">REST API Reference for DescribeVcenterClients Operation</seealso>
        Task<DescribeVcenterClientsResponse> DescribeVcenterClientsAsync(DescribeVcenterClientsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Disassociate applications from wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateApplications service method.</param>
        /// <returns>The response from the DisassociateApplications service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisassociateApplications">REST API Reference for DisassociateApplications Operation</seealso>
        DisassociateApplicationsResponse DisassociateApplications(DisassociateApplicationsRequest request);
#endif

        /// <summary>
        /// Disassociate applications from wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisassociateApplications service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisassociateApplications">REST API Reference for DisassociateApplications Operation</seealso>
        Task<DisassociateApplicationsResponse> DisassociateApplicationsAsync(DisassociateApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Disassociate source servers from application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSourceServers service method.</param>
        /// <returns>The response from the DisassociateSourceServers service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisassociateSourceServers">REST API Reference for DisassociateSourceServers Operation</seealso>
        DisassociateSourceServersResponse DisassociateSourceServers(DisassociateSourceServersRequest request);
#endif

        /// <summary>
        /// Disassociate source servers from application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSourceServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisassociateSourceServers service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisassociateSourceServers">REST API Reference for DisassociateSourceServers Operation</seealso>
        Task<DisassociateSourceServersResponse> DisassociateSourceServersAsync(DisassociateSourceServersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Disconnects specific Source Servers from Application Migration Service. Data replication
        /// is stopped immediately. All AWS resources created by Application Migration Service
        /// for enabling the replication of these source servers will be terminated / deleted
        /// within 90 minutes. Launched Test or Cutover instances will NOT be terminated. If the
        /// agent on the source server has not been prevented from communicating with Application
        /// Migration Service, then it will receive a command to uninstall itself (within approximately
        /// 10 minutes). The following properties of the SourceServer will be changed immediately:
        /// dataReplicationInfo.dataReplicationState will be set to DISCONNECTED; The totalStorageBytes
        /// property for each of dataReplicationInfo.replicatedDisks will be set to zero; dataReplicationInfo.lagDuration
        /// and dataReplicationInfo.lagDuration will be nullified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectFromService service method.</param>
        /// <returns>The response from the DisconnectFromService service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisconnectFromService">REST API Reference for DisconnectFromService Operation</seealso>
        DisconnectFromServiceResponse DisconnectFromService(DisconnectFromServiceRequest request);
#endif

        /// <summary>
        /// Disconnects specific Source Servers from Application Migration Service. Data replication
        /// is stopped immediately. All AWS resources created by Application Migration Service
        /// for enabling the replication of these source servers will be terminated / deleted
        /// within 90 minutes. Launched Test or Cutover instances will NOT be terminated. If the
        /// agent on the source server has not been prevented from communicating with Application
        /// Migration Service, then it will receive a command to uninstall itself (within approximately
        /// 10 minutes). The following properties of the SourceServer will be changed immediately:
        /// dataReplicationInfo.dataReplicationState will be set to DISCONNECTED; The totalStorageBytes
        /// property for each of dataReplicationInfo.replicatedDisks will be set to zero; dataReplicationInfo.lagDuration
        /// and dataReplicationInfo.lagDuration will be nullified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectFromService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisconnectFromService service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisconnectFromService">REST API Reference for DisconnectFromService Operation</seealso>
        Task<DisconnectFromServiceResponse> DisconnectFromServiceAsync(DisconnectFromServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Finalizes the cutover immediately for specific Source Servers. All AWS resources created
        /// by Application Migration Service for enabling the replication of these source servers
        /// will be terminated / deleted within 90 minutes. Launched Test or Cutover instances
        /// will NOT be terminated. The AWS Replication Agent will receive a command to uninstall
        /// itself (within 10 minutes). The following properties of the SourceServer will be changed
        /// immediately: dataReplicationInfo.dataReplicationState will be changed to DISCONNECTED;
        /// The SourceServer.lifeCycle.state will be changed to CUTOVER; The totalStorageBytes
        /// property for each of dataReplicationInfo.replicatedDisks will be set to zero; dataReplicationInfo.lagDuration
        /// and dataReplicationInfo.lagDuration will be nullified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FinalizeCutover service method.</param>
        /// <returns>The response from the FinalizeCutover service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/FinalizeCutover">REST API Reference for FinalizeCutover Operation</seealso>
        FinalizeCutoverResponse FinalizeCutover(FinalizeCutoverRequest request);
#endif

        /// <summary>
        /// Finalizes the cutover immediately for specific Source Servers. All AWS resources created
        /// by Application Migration Service for enabling the replication of these source servers
        /// will be terminated / deleted within 90 minutes. Launched Test or Cutover instances
        /// will NOT be terminated. The AWS Replication Agent will receive a command to uninstall
        /// itself (within 10 minutes). The following properties of the SourceServer will be changed
        /// immediately: dataReplicationInfo.dataReplicationState will be changed to DISCONNECTED;
        /// The SourceServer.lifeCycle.state will be changed to CUTOVER; The totalStorageBytes
        /// property for each of dataReplicationInfo.replicatedDisks will be set to zero; dataReplicationInfo.lagDuration
        /// and dataReplicationInfo.lagDuration will be nullified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FinalizeCutover service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the FinalizeCutover service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/FinalizeCutover">REST API Reference for FinalizeCutover Operation</seealso>
        Task<FinalizeCutoverResponse> FinalizeCutoverAsync(FinalizeCutoverRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists all LaunchConfigurations available, filtered by Source Server IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchConfiguration service method.</param>
        /// <returns>The response from the GetLaunchConfiguration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetLaunchConfiguration">REST API Reference for GetLaunchConfiguration Operation</seealso>
        GetLaunchConfigurationResponse GetLaunchConfiguration(GetLaunchConfigurationRequest request);
#endif

        /// <summary>
        /// Lists all LaunchConfigurations available, filtered by Source Server IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetLaunchConfiguration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetLaunchConfiguration">REST API Reference for GetLaunchConfiguration Operation</seealso>
        Task<GetLaunchConfigurationResponse> GetLaunchConfigurationAsync(GetLaunchConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the details of a network migration definition including source and target
        /// configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkMigrationDefinition service method.</param>
        /// <returns>The response from the GetNetworkMigrationDefinition service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetNetworkMigrationDefinition">REST API Reference for GetNetworkMigrationDefinition Operation</seealso>
        GetNetworkMigrationDefinitionResponse GetNetworkMigrationDefinition(GetNetworkMigrationDefinitionRequest request);
#endif

        /// <summary>
        /// Retrieves the details of a network migration definition including source and target
        /// configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkMigrationDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetNetworkMigrationDefinition service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetNetworkMigrationDefinition">REST API Reference for GetNetworkMigrationDefinition Operation</seealso>
        Task<GetNetworkMigrationDefinitionResponse> GetNetworkMigrationDefinitionAsync(GetNetworkMigrationDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves detailed information about a specific construct within a mapper segment,
        /// including its properties and configuration data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkMigrationMapperSegmentConstruct service method.</param>
        /// <returns>The response from the GetNetworkMigrationMapperSegmentConstruct service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetNetworkMigrationMapperSegmentConstruct">REST API Reference for GetNetworkMigrationMapperSegmentConstruct Operation</seealso>
        GetNetworkMigrationMapperSegmentConstructResponse GetNetworkMigrationMapperSegmentConstruct(GetNetworkMigrationMapperSegmentConstructRequest request);
#endif

        /// <summary>
        /// Retrieves detailed information about a specific construct within a mapper segment,
        /// including its properties and configuration data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkMigrationMapperSegmentConstruct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetNetworkMigrationMapperSegmentConstruct service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetNetworkMigrationMapperSegmentConstruct">REST API Reference for GetNetworkMigrationMapperSegmentConstruct Operation</seealso>
        Task<GetNetworkMigrationMapperSegmentConstructResponse> GetNetworkMigrationMapperSegmentConstructAsync(GetNetworkMigrationMapperSegmentConstructRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists all ReplicationConfigurations, filtered by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationConfiguration service method.</param>
        /// <returns>The response from the GetReplicationConfiguration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetReplicationConfiguration">REST API Reference for GetReplicationConfiguration Operation</seealso>
        GetReplicationConfigurationResponse GetReplicationConfiguration(GetReplicationConfigurationRequest request);
#endif

        /// <summary>
        /// Lists all ReplicationConfigurations, filtered by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetReplicationConfiguration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetReplicationConfiguration">REST API Reference for GetReplicationConfiguration Operation</seealso>
        Task<GetReplicationConfigurationResponse> GetReplicationConfigurationAsync(GetReplicationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Initialize Application Migration Service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitializeService service method.</param>
        /// <returns>The response from the InitializeService service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/InitializeService">REST API Reference for InitializeService Operation</seealso>
        InitializeServiceResponse InitializeService(InitializeServiceRequest request);
#endif

        /// <summary>
        /// Initialize Application Migration Service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitializeService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the InitializeService service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/InitializeService">REST API Reference for InitializeService Operation</seealso>
        Task<InitializeServiceResponse> InitializeServiceAsync(InitializeServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves all applications or multiple applications by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <returns>The response from the ListApplications service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse ListApplications(ListApplicationsRequest request);
#endif

        /// <summary>
        /// Retrieves all applications or multiple applications by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListApplications service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListApplications">REST API Reference for ListApplications Operation</seealso>
        Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List Connectors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors service method.</param>
        /// <returns>The response from the ListConnectors service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        ListConnectorsResponse ListConnectors(ListConnectorsRequest request);
#endif

        /// <summary>
        /// List Connectors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListConnectors service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        Task<ListConnectorsResponse> ListConnectorsAsync(ListConnectorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List export errors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExportErrors service method.</param>
        /// <returns>The response from the ListExportErrors service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListExportErrors">REST API Reference for ListExportErrors Operation</seealso>
        ListExportErrorsResponse ListExportErrors(ListExportErrorsRequest request);
#endif

        /// <summary>
        /// List export errors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExportErrors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListExportErrors service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListExportErrors">REST API Reference for ListExportErrors Operation</seealso>
        Task<ListExportErrorsResponse> ListExportErrorsAsync(ListExportErrorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List exports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExports service method.</param>
        /// <returns>The response from the ListExports service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListExports">REST API Reference for ListExports Operation</seealso>
        ListExportsResponse ListExports(ListExportsRequest request);
#endif

        /// <summary>
        /// List exports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListExports service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListExports">REST API Reference for ListExports Operation</seealso>
        Task<ListExportsResponse> ListExportsAsync(ListExportsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List import errors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportErrors service method.</param>
        /// <returns>The response from the ListImportErrors service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListImportErrors">REST API Reference for ListImportErrors Operation</seealso>
        ListImportErrorsResponse ListImportErrors(ListImportErrorsRequest request);
#endif

        /// <summary>
        /// List import errors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportErrors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListImportErrors service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListImportErrors">REST API Reference for ListImportErrors Operation</seealso>
        Task<ListImportErrorsResponse> ListImportErrorsAsync(ListImportErrorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists import file enrichment jobs with optional filtering by job IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportFileEnrichments service method.</param>
        /// <returns>The response from the ListImportFileEnrichments service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListImportFileEnrichments">REST API Reference for ListImportFileEnrichments Operation</seealso>
        ListImportFileEnrichmentsResponse ListImportFileEnrichments(ListImportFileEnrichmentsRequest request);
#endif

        /// <summary>
        /// Lists import file enrichment jobs with optional filtering by job IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportFileEnrichments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListImportFileEnrichments service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListImportFileEnrichments">REST API Reference for ListImportFileEnrichments Operation</seealso>
        Task<ListImportFileEnrichmentsResponse> ListImportFileEnrichmentsAsync(ListImportFileEnrichmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List imports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImports service method.</param>
        /// <returns>The response from the ListImports service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListImports">REST API Reference for ListImports Operation</seealso>
        ListImportsResponse ListImports(ListImportsRequest request);
#endif

        /// <summary>
        /// List imports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListImports service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListImports">REST API Reference for ListImports Operation</seealso>
        Task<ListImportsResponse> ListImportsAsync(ListImportsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List Managed Accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedAccounts service method.</param>
        /// <returns>The response from the ListManagedAccounts service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListManagedAccounts">REST API Reference for ListManagedAccounts Operation</seealso>
        ListManagedAccountsResponse ListManagedAccounts(ListManagedAccountsRequest request);
#endif

        /// <summary>
        /// List Managed Accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListManagedAccounts service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListManagedAccounts">REST API Reference for ListManagedAccounts Operation</seealso>
        Task<ListManagedAccountsResponse> ListManagedAccountsAsync(ListManagedAccountsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists network migration analysis jobs for a specified execution. Returns information
        /// about analysis job status and results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationAnalyses service method.</param>
        /// <returns>The response from the ListNetworkMigrationAnalyses service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationAnalyses">REST API Reference for ListNetworkMigrationAnalyses Operation</seealso>
        ListNetworkMigrationAnalysesResponse ListNetworkMigrationAnalyses(ListNetworkMigrationAnalysesRequest request);
#endif

        /// <summary>
        /// Lists network migration analysis jobs for a specified execution. Returns information
        /// about analysis job status and results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationAnalyses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListNetworkMigrationAnalyses service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationAnalyses">REST API Reference for ListNetworkMigrationAnalyses Operation</seealso>
        Task<ListNetworkMigrationAnalysesResponse> ListNetworkMigrationAnalysesAsync(ListNetworkMigrationAnalysesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the results of network migration analyses, showing connectivity and compatibility
        /// findings for migrated resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationAnalysisResults service method.</param>
        /// <returns>The response from the ListNetworkMigrationAnalysisResults service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationAnalysisResults">REST API Reference for ListNetworkMigrationAnalysisResults Operation</seealso>
        ListNetworkMigrationAnalysisResultsResponse ListNetworkMigrationAnalysisResults(ListNetworkMigrationAnalysisResultsRequest request);
#endif

        /// <summary>
        /// Lists the results of network migration analyses, showing connectivity and compatibility
        /// findings for migrated resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationAnalysisResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListNetworkMigrationAnalysisResults service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationAnalysisResults">REST API Reference for ListNetworkMigrationAnalysisResults Operation</seealso>
        Task<ListNetworkMigrationAnalysisResultsResponse> ListNetworkMigrationAnalysisResultsAsync(ListNetworkMigrationAnalysisResultsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists code generation segments, which represent individual infrastructure components
        /// generated as code templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationCodeGenerationSegments service method.</param>
        /// <returns>The response from the ListNetworkMigrationCodeGenerationSegments service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationCodeGenerationSegments">REST API Reference for ListNetworkMigrationCodeGenerationSegments Operation</seealso>
        ListNetworkMigrationCodeGenerationSegmentsResponse ListNetworkMigrationCodeGenerationSegments(ListNetworkMigrationCodeGenerationSegmentsRequest request);
#endif

        /// <summary>
        /// Lists code generation segments, which represent individual infrastructure components
        /// generated as code templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationCodeGenerationSegments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListNetworkMigrationCodeGenerationSegments service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationCodeGenerationSegments">REST API Reference for ListNetworkMigrationCodeGenerationSegments Operation</seealso>
        Task<ListNetworkMigrationCodeGenerationSegmentsResponse> ListNetworkMigrationCodeGenerationSegmentsAsync(ListNetworkMigrationCodeGenerationSegmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists network migration code generation jobs, which convert network mappings into
        /// infrastructure-as-code templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationCodeGenerations service method.</param>
        /// <returns>The response from the ListNetworkMigrationCodeGenerations service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationCodeGenerations">REST API Reference for ListNetworkMigrationCodeGenerations Operation</seealso>
        ListNetworkMigrationCodeGenerationsResponse ListNetworkMigrationCodeGenerations(ListNetworkMigrationCodeGenerationsRequest request);
#endif

        /// <summary>
        /// Lists network migration code generation jobs, which convert network mappings into
        /// infrastructure-as-code templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationCodeGenerations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListNetworkMigrationCodeGenerations service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationCodeGenerations">REST API Reference for ListNetworkMigrationCodeGenerations Operation</seealso>
        Task<ListNetworkMigrationCodeGenerationsResponse> ListNetworkMigrationCodeGenerationsAsync(ListNetworkMigrationCodeGenerationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists all network migration definitions in the account, with optional filtering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationDefinitions service method.</param>
        /// <returns>The response from the ListNetworkMigrationDefinitions service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationDefinitions">REST API Reference for ListNetworkMigrationDefinitions Operation</seealso>
        ListNetworkMigrationDefinitionsResponse ListNetworkMigrationDefinitions(ListNetworkMigrationDefinitionsRequest request);
#endif

        /// <summary>
        /// Lists all network migration definitions in the account, with optional filtering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListNetworkMigrationDefinitions service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationDefinitions">REST API Reference for ListNetworkMigrationDefinitions Operation</seealso>
        Task<ListNetworkMigrationDefinitionsResponse> ListNetworkMigrationDefinitionsAsync(ListNetworkMigrationDefinitionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists CloudFormation stacks that have been deployed as part of the network migration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationDeployedStacks service method.</param>
        /// <returns>The response from the ListNetworkMigrationDeployedStacks service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationDeployedStacks">REST API Reference for ListNetworkMigrationDeployedStacks Operation</seealso>
        ListNetworkMigrationDeployedStacksResponse ListNetworkMigrationDeployedStacks(ListNetworkMigrationDeployedStacksRequest request);
#endif

        /// <summary>
        /// Lists CloudFormation stacks that have been deployed as part of the network migration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationDeployedStacks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListNetworkMigrationDeployedStacks service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationDeployedStacks">REST API Reference for ListNetworkMigrationDeployedStacks Operation</seealso>
        Task<ListNetworkMigrationDeployedStacksResponse> ListNetworkMigrationDeployedStacksAsync(ListNetworkMigrationDeployedStacksRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists network migration deployment jobs and their current status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationDeployments service method.</param>
        /// <returns>The response from the ListNetworkMigrationDeployments service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationDeployments">REST API Reference for ListNetworkMigrationDeployments Operation</seealso>
        ListNetworkMigrationDeploymentsResponse ListNetworkMigrationDeployments(ListNetworkMigrationDeploymentsRequest request);
#endif

        /// <summary>
        /// Lists network migration deployment jobs and their current status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListNetworkMigrationDeployments service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationDeployments">REST API Reference for ListNetworkMigrationDeployments Operation</seealso>
        Task<ListNetworkMigrationDeploymentsResponse> ListNetworkMigrationDeploymentsAsync(ListNetworkMigrationDeploymentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists network migration execution instances for a given definition, showing the status
        /// and progress of each execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationExecutions service method.</param>
        /// <returns>The response from the ListNetworkMigrationExecutions service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationExecutions">REST API Reference for ListNetworkMigrationExecutions Operation</seealso>
        ListNetworkMigrationExecutionsResponse ListNetworkMigrationExecutions(ListNetworkMigrationExecutionsRequest request);
#endif

        /// <summary>
        /// Lists network migration execution instances for a given definition, showing the status
        /// and progress of each execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListNetworkMigrationExecutions service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationExecutions">REST API Reference for ListNetworkMigrationExecutions Operation</seealso>
        Task<ListNetworkMigrationExecutionsResponse> ListNetworkMigrationExecutionsAsync(ListNetworkMigrationExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists constructs within a mapper segment, representing individual infrastructure components
        /// like VPCs, subnets, or security groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationMapperSegmentConstructs service method.</param>
        /// <returns>The response from the ListNetworkMigrationMapperSegmentConstructs service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationMapperSegmentConstructs">REST API Reference for ListNetworkMigrationMapperSegmentConstructs Operation</seealso>
        ListNetworkMigrationMapperSegmentConstructsResponse ListNetworkMigrationMapperSegmentConstructs(ListNetworkMigrationMapperSegmentConstructsRequest request);
#endif

        /// <summary>
        /// Lists constructs within a mapper segment, representing individual infrastructure components
        /// like VPCs, subnets, or security groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationMapperSegmentConstructs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListNetworkMigrationMapperSegmentConstructs service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationMapperSegmentConstructs">REST API Reference for ListNetworkMigrationMapperSegmentConstructs Operation</seealso>
        Task<ListNetworkMigrationMapperSegmentConstructsResponse> ListNetworkMigrationMapperSegmentConstructsAsync(ListNetworkMigrationMapperSegmentConstructsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists mapper segments, which represent logical groupings of network resources to be
        /// migrated together.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationMapperSegments service method.</param>
        /// <returns>The response from the ListNetworkMigrationMapperSegments service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationMapperSegments">REST API Reference for ListNetworkMigrationMapperSegments Operation</seealso>
        ListNetworkMigrationMapperSegmentsResponse ListNetworkMigrationMapperSegments(ListNetworkMigrationMapperSegmentsRequest request);
#endif

        /// <summary>
        /// Lists mapper segments, which represent logical groupings of network resources to be
        /// migrated together.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationMapperSegments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListNetworkMigrationMapperSegments service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationMapperSegments">REST API Reference for ListNetworkMigrationMapperSegments Operation</seealso>
        Task<ListNetworkMigrationMapperSegmentsResponse> ListNetworkMigrationMapperSegmentsAsync(ListNetworkMigrationMapperSegmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists mapping update jobs, which apply customer modifications to the generated network
        /// mappings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationMappingUpdates service method.</param>
        /// <returns>The response from the ListNetworkMigrationMappingUpdates service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationMappingUpdates">REST API Reference for ListNetworkMigrationMappingUpdates Operation</seealso>
        ListNetworkMigrationMappingUpdatesResponse ListNetworkMigrationMappingUpdates(ListNetworkMigrationMappingUpdatesRequest request);
#endif

        /// <summary>
        /// Lists mapping update jobs, which apply customer modifications to the generated network
        /// mappings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationMappingUpdates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListNetworkMigrationMappingUpdates service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationMappingUpdates">REST API Reference for ListNetworkMigrationMappingUpdates Operation</seealso>
        Task<ListNetworkMigrationMappingUpdatesResponse> ListNetworkMigrationMappingUpdatesAsync(ListNetworkMigrationMappingUpdatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists network migration mapping jobs, which analyze and create relationships between
        /// source and target network resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationMappings service method.</param>
        /// <returns>The response from the ListNetworkMigrationMappings service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationMappings">REST API Reference for ListNetworkMigrationMappings Operation</seealso>
        ListNetworkMigrationMappingsResponse ListNetworkMigrationMappings(ListNetworkMigrationMappingsRequest request);
#endif

        /// <summary>
        /// Lists network migration mapping jobs, which analyze and create relationships between
        /// source and target network resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkMigrationMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListNetworkMigrationMappings service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListNetworkMigrationMappings">REST API Reference for ListNetworkMigrationMappings Operation</seealso>
        Task<ListNetworkMigrationMappingsResponse> ListNetworkMigrationMappingsAsync(ListNetworkMigrationMappingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List source server post migration custom actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceServerActions service method.</param>
        /// <returns>The response from the ListSourceServerActions service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListSourceServerActions">REST API Reference for ListSourceServerActions Operation</seealso>
        ListSourceServerActionsResponse ListSourceServerActions(ListSourceServerActionsRequest request);
#endif

        /// <summary>
        /// List source server post migration custom actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceServerActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListSourceServerActions service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListSourceServerActions">REST API Reference for ListSourceServerActions Operation</seealso>
        Task<ListSourceServerActionsResponse> ListSourceServerActionsAsync(ListSourceServerActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List all tags for your Application Migration Service resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.InternalServerException">
        /// The server encountered an unexpected condition that prevented it from fulfilling the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);
#endif

        /// <summary>
        /// List all tags for your Application Migration Service resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.InternalServerException">
        /// The server encountered an unexpected condition that prevented it from fulfilling the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List template post migration custom actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateActions service method.</param>
        /// <returns>The response from the ListTemplateActions service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListTemplateActions">REST API Reference for ListTemplateActions Operation</seealso>
        ListTemplateActionsResponse ListTemplateActions(ListTemplateActionsRequest request);
#endif

        /// <summary>
        /// List template post migration custom actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTemplateActions service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListTemplateActions">REST API Reference for ListTemplateActions Operation</seealso>
        Task<ListTemplateActionsResponse> ListTemplateActionsAsync(ListTemplateActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves all waves or multiple waves by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWaves service method.</param>
        /// <returns>The response from the ListWaves service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListWaves">REST API Reference for ListWaves Operation</seealso>
        ListWavesResponse ListWaves(ListWavesRequest request);
#endif

        /// <summary>
        /// Retrieves all waves or multiple waves by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWaves service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListWaves service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListWaves">REST API Reference for ListWaves Operation</seealso>
        Task<ListWavesResponse> ListWavesAsync(ListWavesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Archives specific Source Servers by setting the SourceServer.isArchived property to
        /// true for specified SourceServers by ID. This command only works for SourceServers
        /// with a lifecycle state that equals DISCONNECTED or CUTOVER.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MarkAsArchived service method.</param>
        /// <returns>The response from the MarkAsArchived service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/MarkAsArchived">REST API Reference for MarkAsArchived Operation</seealso>
        MarkAsArchivedResponse MarkAsArchived(MarkAsArchivedRequest request);
#endif

        /// <summary>
        /// Archives specific Source Servers by setting the SourceServer.isArchived property to
        /// true for specified SourceServers by ID. This command only works for SourceServers
        /// with a lifecycle state that equals DISCONNECTED or CUTOVER.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MarkAsArchived service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the MarkAsArchived service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/MarkAsArchived">REST API Reference for MarkAsArchived Operation</seealso>
        Task<MarkAsArchivedResponse> MarkAsArchivedAsync(MarkAsArchivedRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Pause Replication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PauseReplication service method.</param>
        /// <returns>The response from the PauseReplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/PauseReplication">REST API Reference for PauseReplication Operation</seealso>
        PauseReplicationResponse PauseReplication(PauseReplicationRequest request);
#endif

        /// <summary>
        /// Pause Replication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PauseReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PauseReplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/PauseReplication">REST API Reference for PauseReplication Operation</seealso>
        Task<PauseReplicationResponse> PauseReplicationAsync(PauseReplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Put source server post migration custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSourceServerAction service method.</param>
        /// <returns>The response from the PutSourceServerAction service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/PutSourceServerAction">REST API Reference for PutSourceServerAction Operation</seealso>
        PutSourceServerActionResponse PutSourceServerAction(PutSourceServerActionRequest request);
#endif

        /// <summary>
        /// Put source server post migration custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSourceServerAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutSourceServerAction service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/PutSourceServerAction">REST API Reference for PutSourceServerAction Operation</seealso>
        Task<PutSourceServerActionResponse> PutSourceServerActionAsync(PutSourceServerActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Put template post migration custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTemplateAction service method.</param>
        /// <returns>The response from the PutTemplateAction service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/PutTemplateAction">REST API Reference for PutTemplateAction Operation</seealso>
        PutTemplateActionResponse PutTemplateAction(PutTemplateActionRequest request);
#endif

        /// <summary>
        /// Put template post migration custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTemplateAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutTemplateAction service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/PutTemplateAction">REST API Reference for PutTemplateAction Operation</seealso>
        Task<PutTemplateActionResponse> PutTemplateActionAsync(PutTemplateActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Remove source server post migration custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceServerAction service method.</param>
        /// <returns>The response from the RemoveSourceServerAction service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RemoveSourceServerAction">REST API Reference for RemoveSourceServerAction Operation</seealso>
        RemoveSourceServerActionResponse RemoveSourceServerAction(RemoveSourceServerActionRequest request);
#endif

        /// <summary>
        /// Remove source server post migration custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceServerAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RemoveSourceServerAction service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RemoveSourceServerAction">REST API Reference for RemoveSourceServerAction Operation</seealso>
        Task<RemoveSourceServerActionResponse> RemoveSourceServerActionAsync(RemoveSourceServerActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Remove template post migration custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTemplateAction service method.</param>
        /// <returns>The response from the RemoveTemplateAction service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RemoveTemplateAction">REST API Reference for RemoveTemplateAction Operation</seealso>
        RemoveTemplateActionResponse RemoveTemplateAction(RemoveTemplateActionRequest request);
#endif

        /// <summary>
        /// Remove template post migration custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTemplateAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RemoveTemplateAction service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RemoveTemplateAction">REST API Reference for RemoveTemplateAction Operation</seealso>
        Task<RemoveTemplateActionResponse> RemoveTemplateActionAsync(RemoveTemplateActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Resume Replication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeReplication service method.</param>
        /// <returns>The response from the ResumeReplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ResumeReplication">REST API Reference for ResumeReplication Operation</seealso>
        ResumeReplicationResponse ResumeReplication(ResumeReplicationRequest request);
#endif

        /// <summary>
        /// Resume Replication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ResumeReplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ResumeReplication">REST API Reference for ResumeReplication Operation</seealso>
        Task<ResumeReplicationResponse> ResumeReplicationAsync(ResumeReplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Causes the data replication initiation sequence to begin immediately upon next Handshake
        /// for specified SourceServer IDs, regardless of when the previous initiation started.
        /// This command will not work if the SourceServer is not stalled or is in a DISCONNECTED
        /// or STOPPED state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryDataReplication service method.</param>
        /// <returns>The response from the RetryDataReplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RetryDataReplication">REST API Reference for RetryDataReplication Operation</seealso>
        RetryDataReplicationResponse RetryDataReplication(RetryDataReplicationRequest request);
#endif

        /// <summary>
        /// Causes the data replication initiation sequence to begin immediately upon next Handshake
        /// for specified SourceServer IDs, regardless of when the previous initiation started.
        /// This command will not work if the SourceServer is not stalled or is in a DISCONNECTED
        /// or STOPPED state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryDataReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RetryDataReplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RetryDataReplication">REST API Reference for RetryDataReplication Operation</seealso>
        Task<RetryDataReplicationResponse> RetryDataReplicationAsync(RetryDataReplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Launches a Cutover Instance for specific Source Servers. This command starts a LAUNCH
        /// job whose initiatedBy property is StartCutover and changes the SourceServer.lifeCycle.state
        /// property to CUTTING_OVER.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCutover service method.</param>
        /// <returns>The response from the StartCutover service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartCutover">REST API Reference for StartCutover Operation</seealso>
        StartCutoverResponse StartCutover(StartCutoverRequest request);
#endif

        /// <summary>
        /// Launches a Cutover Instance for specific Source Servers. This command starts a LAUNCH
        /// job whose initiatedBy property is StartCutover and changes the SourceServer.lifeCycle.state
        /// property to CUTTING_OVER.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCutover service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartCutover service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartCutover">REST API Reference for StartCutover Operation</seealso>
        Task<StartCutoverResponse> StartCutoverAsync(StartCutoverRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Start export.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExport service method.</param>
        /// <returns>The response from the StartExport service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartExport">REST API Reference for StartExport Operation</seealso>
        StartExportResponse StartExport(StartExportRequest request);
#endif

        /// <summary>
        /// Start export.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartExport service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartExport">REST API Reference for StartExport Operation</seealso>
        Task<StartExportResponse> StartExportAsync(StartExportRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Start import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImport service method.</param>
        /// <returns>The response from the StartImport service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartImport">REST API Reference for StartImport Operation</seealso>
        StartImportResponse StartImport(StartImportRequest request);
#endif

        /// <summary>
        /// Start import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartImport service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartImport">REST API Reference for StartImport Operation</seealso>
        Task<StartImportResponse> StartImportAsync(StartImportRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Starts an import file enrichment job to process and enrich network migration import
        /// files with additional metadata and IP assignment strategies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImportFileEnrichment service method.</param>
        /// <returns>The response from the StartImportFileEnrichment service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartImportFileEnrichment">REST API Reference for StartImportFileEnrichment Operation</seealso>
        StartImportFileEnrichmentResponse StartImportFileEnrichment(StartImportFileEnrichmentRequest request);
#endif

        /// <summary>
        /// Starts an import file enrichment job to process and enrich network migration import
        /// files with additional metadata and IP assignment strategies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImportFileEnrichment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartImportFileEnrichment service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartImportFileEnrichment">REST API Reference for StartImportFileEnrichment Operation</seealso>
        Task<StartImportFileEnrichmentResponse> StartImportFileEnrichmentAsync(StartImportFileEnrichmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Starts a network migration analysis job to evaluate connectivity and compatibility
        /// of the migration mappings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNetworkMigrationAnalysis service method.</param>
        /// <returns>The response from the StartNetworkMigrationAnalysis service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartNetworkMigrationAnalysis">REST API Reference for StartNetworkMigrationAnalysis Operation</seealso>
        StartNetworkMigrationAnalysisResponse StartNetworkMigrationAnalysis(StartNetworkMigrationAnalysisRequest request);
#endif

        /// <summary>
        /// Starts a network migration analysis job to evaluate connectivity and compatibility
        /// of the migration mappings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNetworkMigrationAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartNetworkMigrationAnalysis service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartNetworkMigrationAnalysis">REST API Reference for StartNetworkMigrationAnalysis Operation</seealso>
        Task<StartNetworkMigrationAnalysisResponse> StartNetworkMigrationAnalysisAsync(StartNetworkMigrationAnalysisRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Starts a code generation job to convert network migration mappings into infrastructure-as-code
        /// templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNetworkMigrationCodeGeneration service method.</param>
        /// <returns>The response from the StartNetworkMigrationCodeGeneration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartNetworkMigrationCodeGeneration">REST API Reference for StartNetworkMigrationCodeGeneration Operation</seealso>
        StartNetworkMigrationCodeGenerationResponse StartNetworkMigrationCodeGeneration(StartNetworkMigrationCodeGenerationRequest request);
#endif

        /// <summary>
        /// Starts a code generation job to convert network migration mappings into infrastructure-as-code
        /// templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNetworkMigrationCodeGeneration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartNetworkMigrationCodeGeneration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartNetworkMigrationCodeGeneration">REST API Reference for StartNetworkMigrationCodeGeneration Operation</seealso>
        Task<StartNetworkMigrationCodeGenerationResponse> StartNetworkMigrationCodeGenerationAsync(StartNetworkMigrationCodeGenerationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Starts a deployment job to create the target network infrastructure based on the generated
        /// code templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNetworkMigrationDeployment service method.</param>
        /// <returns>The response from the StartNetworkMigrationDeployment service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartNetworkMigrationDeployment">REST API Reference for StartNetworkMigrationDeployment Operation</seealso>
        StartNetworkMigrationDeploymentResponse StartNetworkMigrationDeployment(StartNetworkMigrationDeploymentRequest request);
#endif

        /// <summary>
        /// Starts a deployment job to create the target network infrastructure based on the generated
        /// code templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNetworkMigrationDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartNetworkMigrationDeployment service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartNetworkMigrationDeployment">REST API Reference for StartNetworkMigrationDeployment Operation</seealso>
        Task<StartNetworkMigrationDeploymentResponse> StartNetworkMigrationDeploymentAsync(StartNetworkMigrationDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Starts the network migration mapping process for a given network migration execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNetworkMigrationMapping service method.</param>
        /// <returns>The response from the StartNetworkMigrationMapping service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartNetworkMigrationMapping">REST API Reference for StartNetworkMigrationMapping Operation</seealso>
        StartNetworkMigrationMappingResponse StartNetworkMigrationMapping(StartNetworkMigrationMappingRequest request);
#endif

        /// <summary>
        /// Starts the network migration mapping process for a given network migration execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNetworkMigrationMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartNetworkMigrationMapping service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartNetworkMigrationMapping">REST API Reference for StartNetworkMigrationMapping Operation</seealso>
        Task<StartNetworkMigrationMappingResponse> StartNetworkMigrationMappingAsync(StartNetworkMigrationMappingRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Starts a job to apply customer modifications to network migration mappings, such as
        /// changing properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNetworkMigrationMappingUpdate service method.</param>
        /// <returns>The response from the StartNetworkMigrationMappingUpdate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartNetworkMigrationMappingUpdate">REST API Reference for StartNetworkMigrationMappingUpdate Operation</seealso>
        StartNetworkMigrationMappingUpdateResponse StartNetworkMigrationMappingUpdate(StartNetworkMigrationMappingUpdateRequest request);
#endif

        /// <summary>
        /// Starts a job to apply customer modifications to network migration mappings, such as
        /// changing properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNetworkMigrationMappingUpdate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartNetworkMigrationMappingUpdate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartNetworkMigrationMappingUpdate">REST API Reference for StartNetworkMigrationMappingUpdate Operation</seealso>
        Task<StartNetworkMigrationMappingUpdateResponse> StartNetworkMigrationMappingUpdateAsync(StartNetworkMigrationMappingUpdateRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Start replication for source server irrespective of its replication type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReplication service method.</param>
        /// <returns>The response from the StartReplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartReplication">REST API Reference for StartReplication Operation</seealso>
        StartReplicationResponse StartReplication(StartReplicationRequest request);
#endif

        /// <summary>
        /// Start replication for source server irrespective of its replication type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartReplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartReplication">REST API Reference for StartReplication Operation</seealso>
        Task<StartReplicationResponse> StartReplicationAsync(StartReplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Launches a Test Instance for specific Source Servers. This command starts a LAUNCH
        /// job whose initiatedBy property is StartTest and changes the SourceServer.lifeCycle.state
        /// property to TESTING.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTest service method.</param>
        /// <returns>The response from the StartTest service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartTest">REST API Reference for StartTest Operation</seealso>
        StartTestResponse StartTest(StartTestRequest request);
#endif

        /// <summary>
        /// Launches a Test Instance for specific Source Servers. This command starts a LAUNCH
        /// job whose initiatedBy property is StartTest and changes the SourceServer.lifeCycle.state
        /// property to TESTING.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartTest service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartTest">REST API Reference for StartTest Operation</seealso>
        Task<StartTestResponse> StartTestAsync(StartTestRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Stop Replication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopReplication service method.</param>
        /// <returns>The response from the StopReplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StopReplication">REST API Reference for StopReplication Operation</seealso>
        StopReplicationResponse StopReplication(StopReplicationRequest request);
#endif

        /// <summary>
        /// Stop Replication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StopReplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StopReplication">REST API Reference for StopReplication Operation</seealso>
        Task<StopReplicationResponse> StopReplicationAsync(StopReplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Adds or overwrites only the specified tags for the specified Application Migration
        /// Service resource or resources. When you specify an existing tag key, the value is
        /// overwritten with the new value. Each resource can have a maximum of 50 tags. Each
        /// tag consists of a key and optional value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.InternalServerException">
        /// The server encountered an unexpected condition that prevented it from fulfilling the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);
#endif

        /// <summary>
        /// Adds or overwrites only the specified tags for the specified Application Migration
        /// Service resource or resources. When you specify an existing tag key, the value is
        /// overwritten with the new value. Each resource can have a maximum of 50 tags. Each
        /// tag consists of a key and optional value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.InternalServerException">
        /// The server encountered an unexpected condition that prevented it from fulfilling the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Starts a job that terminates specific launched EC2 Test and Cutover instances. This
        /// command will not work for any Source Server with a lifecycle.state of TESTING, CUTTING_OVER,
        /// or CUTOVER.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateTargetInstances service method.</param>
        /// <returns>The response from the TerminateTargetInstances service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/TerminateTargetInstances">REST API Reference for TerminateTargetInstances Operation</seealso>
        TerminateTargetInstancesResponse TerminateTargetInstances(TerminateTargetInstancesRequest request);
#endif

        /// <summary>
        /// Starts a job that terminates specific launched EC2 Test and Cutover instances. This
        /// command will not work for any Source Server with a lifecycle.state of TESTING, CUTTING_OVER,
        /// or CUTOVER.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateTargetInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TerminateTargetInstances service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/TerminateTargetInstances">REST API Reference for TerminateTargetInstances Operation</seealso>
        Task<TerminateTargetInstancesResponse> TerminateTargetInstancesAsync(TerminateTargetInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Unarchive application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveApplication service method.</param>
        /// <returns>The response from the UnarchiveApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UnarchiveApplication">REST API Reference for UnarchiveApplication Operation</seealso>
        UnarchiveApplicationResponse UnarchiveApplication(UnarchiveApplicationRequest request);
#endif

        /// <summary>
        /// Unarchive application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UnarchiveApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UnarchiveApplication">REST API Reference for UnarchiveApplication Operation</seealso>
        Task<UnarchiveApplicationResponse> UnarchiveApplicationAsync(UnarchiveApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Unarchive wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveWave service method.</param>
        /// <returns>The response from the UnarchiveWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UnarchiveWave">REST API Reference for UnarchiveWave Operation</seealso>
        UnarchiveWaveResponse UnarchiveWave(UnarchiveWaveRequest request);
#endif

        /// <summary>
        /// Unarchive wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveWave service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UnarchiveWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because it exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UnarchiveWave">REST API Reference for UnarchiveWave Operation</seealso>
        Task<UnarchiveWaveResponse> UnarchiveWaveAsync(UnarchiveWaveRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the specified set of tags from the specified set of Application Migration
        /// Service resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.InternalServerException">
        /// The server encountered an unexpected condition that prevented it from fulfilling the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);
#endif

        /// <summary>
        /// Deletes the specified set of tags from the specified set of Application Migration
        /// Service resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.InternalServerException">
        /// The server encountered an unexpected condition that prevented it from fulfilling the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Update application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <returns>The response from the UpdateApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request);
#endif

        /// <summary>
        /// Update application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Update Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnector service method.</param>
        /// <returns>The response from the UpdateConnector service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateConnector">REST API Reference for UpdateConnector Operation</seealso>
        UpdateConnectorResponse UpdateConnector(UpdateConnectorRequest request);
#endif

        /// <summary>
        /// Update Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateConnector service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateConnector">REST API Reference for UpdateConnector Operation</seealso>
        Task<UpdateConnectorResponse> UpdateConnectorAsync(UpdateConnectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates multiple LaunchConfigurations by Source Server ID.
        /// 
        ///  <note> 
        /// <para>
        /// bootMode valid values are <c>LEGACY_BIOS | UEFI | USE_SOURCE</c> 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchConfiguration service method.</param>
        /// <returns>The response from the UpdateLaunchConfiguration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateLaunchConfiguration">REST API Reference for UpdateLaunchConfiguration Operation</seealso>
        UpdateLaunchConfigurationResponse UpdateLaunchConfiguration(UpdateLaunchConfigurationRequest request);
#endif

        /// <summary>
        /// Updates multiple LaunchConfigurations by Source Server ID.
        /// 
        ///  <note> 
        /// <para>
        /// bootMode valid values are <c>LEGACY_BIOS | UEFI | USE_SOURCE</c> 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateLaunchConfiguration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateLaunchConfiguration">REST API Reference for UpdateLaunchConfiguration Operation</seealso>
        Task<UpdateLaunchConfigurationResponse> UpdateLaunchConfigurationAsync(UpdateLaunchConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates an existing Launch Configuration Template by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchConfigurationTemplate service method.</param>
        /// <returns>The response from the UpdateLaunchConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateLaunchConfigurationTemplate">REST API Reference for UpdateLaunchConfigurationTemplate Operation</seealso>
        UpdateLaunchConfigurationTemplateResponse UpdateLaunchConfigurationTemplate(UpdateLaunchConfigurationTemplateRequest request);
#endif

        /// <summary>
        /// Updates an existing Launch Configuration Template by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateLaunchConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateLaunchConfigurationTemplate">REST API Reference for UpdateLaunchConfigurationTemplate Operation</seealso>
        Task<UpdateLaunchConfigurationTemplateResponse> UpdateLaunchConfigurationTemplateAsync(UpdateLaunchConfigurationTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates an existing network migration definition with new source or target configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkMigrationDefinition service method.</param>
        /// <returns>The response from the UpdateNetworkMigrationDefinition service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateNetworkMigrationDefinition">REST API Reference for UpdateNetworkMigrationDefinition Operation</seealso>
        UpdateNetworkMigrationDefinitionResponse UpdateNetworkMigrationDefinition(UpdateNetworkMigrationDefinitionRequest request);
#endif

        /// <summary>
        /// Updates an existing network migration definition with new source or target configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkMigrationDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateNetworkMigrationDefinition service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateNetworkMigrationDefinition">REST API Reference for UpdateNetworkMigrationDefinition Operation</seealso>
        Task<UpdateNetworkMigrationDefinitionResponse> UpdateNetworkMigrationDefinitionAsync(UpdateNetworkMigrationDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a mapper segment's configuration, such as changing its scope tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkMigrationMapperSegment service method.</param>
        /// <returns>The response from the UpdateNetworkMigrationMapperSegment service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateNetworkMigrationMapperSegment">REST API Reference for UpdateNetworkMigrationMapperSegment Operation</seealso>
        UpdateNetworkMigrationMapperSegmentResponse UpdateNetworkMigrationMapperSegment(UpdateNetworkMigrationMapperSegmentRequest request);
#endif

        /// <summary>
        /// Updates a mapper segment's configuration, such as changing its scope tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkMigrationMapperSegment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateNetworkMigrationMapperSegment service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateNetworkMigrationMapperSegment">REST API Reference for UpdateNetworkMigrationMapperSegment Operation</seealso>
        Task<UpdateNetworkMigrationMapperSegmentResponse> UpdateNetworkMigrationMapperSegmentAsync(UpdateNetworkMigrationMapperSegmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Allows you to update multiple ReplicationConfigurations by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfiguration service method.</param>
        /// <returns>The response from the UpdateReplicationConfiguration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateReplicationConfiguration">REST API Reference for UpdateReplicationConfiguration Operation</seealso>
        UpdateReplicationConfigurationResponse UpdateReplicationConfiguration(UpdateReplicationConfigurationRequest request);
#endif

        /// <summary>
        /// Allows you to update multiple ReplicationConfigurations by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateReplicationConfiguration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateReplicationConfiguration">REST API Reference for UpdateReplicationConfiguration Operation</seealso>
        Task<UpdateReplicationConfigurationResponse> UpdateReplicationConfigurationAsync(UpdateReplicationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a ReplicationConfigurationTemplate by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfigurationTemplate service method.</param>
        /// <returns>The response from the UpdateReplicationConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateReplicationConfigurationTemplate">REST API Reference for UpdateReplicationConfigurationTemplate Operation</seealso>
        UpdateReplicationConfigurationTemplateResponse UpdateReplicationConfigurationTemplate(UpdateReplicationConfigurationTemplateRequest request);
#endif

        /// <summary>
        /// Updates a ReplicationConfigurationTemplate by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateReplicationConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operation denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateReplicationConfigurationTemplate">REST API Reference for UpdateReplicationConfigurationTemplate Operation</seealso>
        Task<UpdateReplicationConfigurationTemplateResponse> UpdateReplicationConfigurationTemplateAsync(UpdateReplicationConfigurationTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Update Source Server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceServer service method.</param>
        /// <returns>The response from the UpdateSourceServer service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateSourceServer">REST API Reference for UpdateSourceServer Operation</seealso>
        UpdateSourceServerResponse UpdateSourceServer(UpdateSourceServerRequest request);
#endif

        /// <summary>
        /// Update Source Server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateSourceServer service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateSourceServer">REST API Reference for UpdateSourceServer Operation</seealso>
        Task<UpdateSourceServerResponse> UpdateSourceServerAsync(UpdateSourceServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Allows you to change between the AGENT_BASED replication type and the SNAPSHOT_SHIPPING
        /// replication type. 
        /// 
        ///  
        /// <para>
        /// SNAPSHOT_SHIPPING should be used for agentless replication.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceServerReplicationType service method.</param>
        /// <returns>The response from the UpdateSourceServerReplicationType service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateSourceServerReplicationType">REST API Reference for UpdateSourceServerReplicationType Operation</seealso>
        UpdateSourceServerReplicationTypeResponse UpdateSourceServerReplicationType(UpdateSourceServerReplicationTypeRequest request);
#endif

        /// <summary>
        /// Allows you to change between the AGENT_BASED replication type and the SNAPSHOT_SHIPPING
        /// replication type. 
        /// 
        ///  
        /// <para>
        /// SNAPSHOT_SHIPPING should be used for agentless replication.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceServerReplicationType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateSourceServerReplicationType service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateSourceServerReplicationType">REST API Reference for UpdateSourceServerReplicationType Operation</seealso>
        Task<UpdateSourceServerReplicationTypeResponse> UpdateSourceServerReplicationTypeAsync(UpdateSourceServerReplicationTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Update wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWave service method.</param>
        /// <returns>The response from the UpdateWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateWave">REST API Reference for UpdateWave Operation</seealso>
        UpdateWaveResponse UpdateWave(UpdateWaveRequest request);
#endif

        /// <summary>
        /// Update wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWave service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateWave">REST API Reference for UpdateWave Operation</seealso>
        Task<UpdateWaveResponse> UpdateWaveAsync(UpdateWaveRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonMgnConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonMgnConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonMgnConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonMgnConfig to create AmazonMgnClient");
            }

            return awsCredentials == null ?
                    new AmazonMgnClient(serviceClientConfig) :
                    new AmazonMgnClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
