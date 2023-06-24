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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ServerMigrationService.Model;

namespace Amazon.ServerMigrationService
{
    /// <summary>
    /// Interface for accessing ServerMigrationService
    ///
    /// <important> 
    /// <para>
    ///  <b>Product update</b> 
    /// </para>
    ///  
    /// <para>
    /// We recommend <a href="http://aws.amazon.com/application-migration-service">Amazon
    /// Web Services Application Migration Service</a> (Amazon Web Services MGN) as the primary
    /// migration service for lift-and-shift migrations. If Amazon Web Services MGN is unavailable
    /// in a specific Amazon Web Services Region, you can use the Server Migration Service
    /// APIs through March 2023.
    /// </para>
    ///  </important> 
    /// <para>
    /// Server Migration Service (Server Migration Service) makes it easier and faster for
    /// you to migrate your on-premises workloads to Amazon Web Services. To learn more about
    /// Server Migration Service, see the following resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/server-migration-service/">Server Migration Service
    /// product page</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/server-migration-service/latest/userguide/">Server
    /// Migration Service User Guide</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonServerMigrationService : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IServerMigrationServicePaginatorFactory Paginators { get; }

        
        #region  CreateApp


        /// <summary>
        /// Creates an application. An application consists of one or more server groups. Each
        /// server group contain one or more servers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/CreateApp">REST API Reference for CreateApp Operation</seealso>
        CreateAppResponse CreateApp(CreateAppRequest request);



        /// <summary>
        /// Creates an application. An application consists of one or more server groups. Each
        /// server group contain one or more servers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/CreateApp">REST API Reference for CreateApp Operation</seealso>
        Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateReplicationJob


        /// <summary>
        /// Creates a replication job. The replication job schedules periodic replication runs
        /// to replicate your server to Amazon Web Services. Each replication run creates an Amazon
        /// Machine Image (AMI).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationJob service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationJob service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.NoConnectorsAvailableException">
        /// There are no connectors available.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ReplicationJobAlreadyExistsException">
        /// The specified replication job already exists.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ServerCannotBeReplicatedException">
        /// The specified server cannot be replicated.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.TemporarilyUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/CreateReplicationJob">REST API Reference for CreateReplicationJob Operation</seealso>
        CreateReplicationJobResponse CreateReplicationJob(CreateReplicationJobRequest request);



        /// <summary>
        /// Creates a replication job. The replication job schedules periodic replication runs
        /// to replicate your server to Amazon Web Services. Each replication run creates an Amazon
        /// Machine Image (AMI).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateReplicationJob service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.NoConnectorsAvailableException">
        /// There are no connectors available.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ReplicationJobAlreadyExistsException">
        /// The specified replication job already exists.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ServerCannotBeReplicatedException">
        /// The specified server cannot be replicated.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.TemporarilyUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/CreateReplicationJob">REST API Reference for CreateReplicationJob Operation</seealso>
        Task<CreateReplicationJobResponse> CreateReplicationJobAsync(CreateReplicationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteApp


        /// <summary>
        /// Deletes the specified application. Optionally deletes the launched stack associated
        /// with the application and all Server Migration Service replication jobs for servers
        /// in the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        DeleteAppResponse DeleteApp(DeleteAppRequest request);



        /// <summary>
        /// Deletes the specified application. Optionally deletes the launched stack associated
        /// with the application and all Server Migration Service replication jobs for servers
        /// in the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAppLaunchConfiguration


        /// <summary>
        /// Deletes the launch configuration for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteAppLaunchConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteAppLaunchConfiguration">REST API Reference for DeleteAppLaunchConfiguration Operation</seealso>
        DeleteAppLaunchConfigurationResponse DeleteAppLaunchConfiguration(DeleteAppLaunchConfigurationRequest request);



        /// <summary>
        /// Deletes the launch configuration for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppLaunchConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppLaunchConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteAppLaunchConfiguration">REST API Reference for DeleteAppLaunchConfiguration Operation</seealso>
        Task<DeleteAppLaunchConfigurationResponse> DeleteAppLaunchConfigurationAsync(DeleteAppLaunchConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAppReplicationConfiguration


        /// <summary>
        /// Deletes the replication configuration for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppReplicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteAppReplicationConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteAppReplicationConfiguration">REST API Reference for DeleteAppReplicationConfiguration Operation</seealso>
        DeleteAppReplicationConfigurationResponse DeleteAppReplicationConfiguration(DeleteAppReplicationConfigurationRequest request);



        /// <summary>
        /// Deletes the replication configuration for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppReplicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppReplicationConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteAppReplicationConfiguration">REST API Reference for DeleteAppReplicationConfiguration Operation</seealso>
        Task<DeleteAppReplicationConfigurationResponse> DeleteAppReplicationConfigurationAsync(DeleteAppReplicationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAppValidationConfiguration


        /// <summary>
        /// Deletes the validation configuration for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppValidationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteAppValidationConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteAppValidationConfiguration">REST API Reference for DeleteAppValidationConfiguration Operation</seealso>
        DeleteAppValidationConfigurationResponse DeleteAppValidationConfiguration(DeleteAppValidationConfigurationRequest request);



        /// <summary>
        /// Deletes the validation configuration for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppValidationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppValidationConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteAppValidationConfiguration">REST API Reference for DeleteAppValidationConfiguration Operation</seealso>
        Task<DeleteAppValidationConfigurationResponse> DeleteAppValidationConfigurationAsync(DeleteAppValidationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteReplicationJob


        /// <summary>
        /// Deletes the specified replication job.
        /// 
        ///  
        /// <para>
        /// After you delete a replication job, there are no further replication runs. Amazon
        /// Web Services deletes the contents of the Amazon S3 bucket used to store Server Migration
        /// Service artifacts. The AMIs created by the replication runs are not deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationJob service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationJob service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ReplicationJobNotFoundException">
        /// The specified replication job does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteReplicationJob">REST API Reference for DeleteReplicationJob Operation</seealso>
        DeleteReplicationJobResponse DeleteReplicationJob(DeleteReplicationJobRequest request);



        /// <summary>
        /// Deletes the specified replication job.
        /// 
        ///  
        /// <para>
        /// After you delete a replication job, there are no further replication runs. Amazon
        /// Web Services deletes the contents of the Amazon S3 bucket used to store Server Migration
        /// Service artifacts. The AMIs created by the replication runs are not deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReplicationJob service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ReplicationJobNotFoundException">
        /// The specified replication job does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteReplicationJob">REST API Reference for DeleteReplicationJob Operation</seealso>
        Task<DeleteReplicationJobResponse> DeleteReplicationJobAsync(DeleteReplicationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteServerCatalog


        /// <summary>
        /// Deletes all servers from your server catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCatalog service method.</param>
        /// 
        /// <returns>The response from the DeleteServerCatalog service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteServerCatalog">REST API Reference for DeleteServerCatalog Operation</seealso>
        DeleteServerCatalogResponse DeleteServerCatalog(DeleteServerCatalogRequest request);



        /// <summary>
        /// Deletes all servers from your server catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCatalog service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServerCatalog service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteServerCatalog">REST API Reference for DeleteServerCatalog Operation</seealso>
        Task<DeleteServerCatalogResponse> DeleteServerCatalogAsync(DeleteServerCatalogRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateConnector


        /// <summary>
        /// Disassociates the specified connector from Server Migration Service.
        /// 
        ///  
        /// <para>
        /// After you disassociate a connector, it is no longer available to support replication
        /// jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnector service method.</param>
        /// 
        /// <returns>The response from the DisassociateConnector service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DisassociateConnector">REST API Reference for DisassociateConnector Operation</seealso>
        DisassociateConnectorResponse DisassociateConnector(DisassociateConnectorRequest request);



        /// <summary>
        /// Disassociates the specified connector from Server Migration Service.
        /// 
        ///  
        /// <para>
        /// After you disassociate a connector, it is no longer available to support replication
        /// jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateConnector service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DisassociateConnector">REST API Reference for DisassociateConnector Operation</seealso>
        Task<DisassociateConnectorResponse> DisassociateConnectorAsync(DisassociateConnectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GenerateChangeSet


        /// <summary>
        /// Generates a target change set for a currently launched stack and writes it to an Amazon
        /// S3 object in the customer’s Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateChangeSet service method.</param>
        /// 
        /// <returns>The response from the GenerateChangeSet service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GenerateChangeSet">REST API Reference for GenerateChangeSet Operation</seealso>
        GenerateChangeSetResponse GenerateChangeSet(GenerateChangeSetRequest request);



        /// <summary>
        /// Generates a target change set for a currently launched stack and writes it to an Amazon
        /// S3 object in the customer’s Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateChangeSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateChangeSet service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GenerateChangeSet">REST API Reference for GenerateChangeSet Operation</seealso>
        Task<GenerateChangeSetResponse> GenerateChangeSetAsync(GenerateChangeSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GenerateTemplate


        /// <summary>
        /// Generates an CloudFormation template based on the current launch configuration and
        /// writes it to an Amazon S3 object in the customer’s Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateTemplate service method.</param>
        /// 
        /// <returns>The response from the GenerateTemplate service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GenerateTemplate">REST API Reference for GenerateTemplate Operation</seealso>
        GenerateTemplateResponse GenerateTemplate(GenerateTemplateRequest request);



        /// <summary>
        /// Generates an CloudFormation template based on the current launch configuration and
        /// writes it to an Amazon S3 object in the customer’s Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateTemplate service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GenerateTemplate">REST API Reference for GenerateTemplate Operation</seealso>
        Task<GenerateTemplateResponse> GenerateTemplateAsync(GenerateTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetApp


        /// <summary>
        /// Retrieve information about the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApp service method.</param>
        /// 
        /// <returns>The response from the GetApp service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetApp">REST API Reference for GetApp Operation</seealso>
        GetAppResponse GetApp(GetAppRequest request);



        /// <summary>
        /// Retrieve information about the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApp service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetApp">REST API Reference for GetApp Operation</seealso>
        Task<GetAppResponse> GetAppAsync(GetAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAppLaunchConfiguration


        /// <summary>
        /// Retrieves the application launch configuration associated with the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetAppLaunchConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetAppLaunchConfiguration">REST API Reference for GetAppLaunchConfiguration Operation</seealso>
        GetAppLaunchConfigurationResponse GetAppLaunchConfiguration(GetAppLaunchConfigurationRequest request);



        /// <summary>
        /// Retrieves the application launch configuration associated with the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppLaunchConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAppLaunchConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetAppLaunchConfiguration">REST API Reference for GetAppLaunchConfiguration Operation</seealso>
        Task<GetAppLaunchConfigurationResponse> GetAppLaunchConfigurationAsync(GetAppLaunchConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAppReplicationConfiguration


        /// <summary>
        /// Retrieves the application replication configuration associated with the specified
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppReplicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetAppReplicationConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetAppReplicationConfiguration">REST API Reference for GetAppReplicationConfiguration Operation</seealso>
        GetAppReplicationConfigurationResponse GetAppReplicationConfiguration(GetAppReplicationConfigurationRequest request);



        /// <summary>
        /// Retrieves the application replication configuration associated with the specified
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppReplicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAppReplicationConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetAppReplicationConfiguration">REST API Reference for GetAppReplicationConfiguration Operation</seealso>
        Task<GetAppReplicationConfigurationResponse> GetAppReplicationConfigurationAsync(GetAppReplicationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAppValidationConfiguration


        /// <summary>
        /// Retrieves information about a configuration for validating an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppValidationConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetAppValidationConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetAppValidationConfiguration">REST API Reference for GetAppValidationConfiguration Operation</seealso>
        GetAppValidationConfigurationResponse GetAppValidationConfiguration(GetAppValidationConfigurationRequest request);



        /// <summary>
        /// Retrieves information about a configuration for validating an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppValidationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAppValidationConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetAppValidationConfiguration">REST API Reference for GetAppValidationConfiguration Operation</seealso>
        Task<GetAppValidationConfigurationResponse> GetAppValidationConfigurationAsync(GetAppValidationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAppValidationOutput


        /// <summary>
        /// Retrieves output from validating an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppValidationOutput service method.</param>
        /// 
        /// <returns>The response from the GetAppValidationOutput service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetAppValidationOutput">REST API Reference for GetAppValidationOutput Operation</seealso>
        GetAppValidationOutputResponse GetAppValidationOutput(GetAppValidationOutputRequest request);



        /// <summary>
        /// Retrieves output from validating an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppValidationOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAppValidationOutput service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetAppValidationOutput">REST API Reference for GetAppValidationOutput Operation</seealso>
        Task<GetAppValidationOutputResponse> GetAppValidationOutputAsync(GetAppValidationOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetConnectors


        /// <summary>
        /// Describes the connectors registered with the Server Migration Service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectors service method.</param>
        /// 
        /// <returns>The response from the GetConnectors service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetConnectors">REST API Reference for GetConnectors Operation</seealso>
        GetConnectorsResponse GetConnectors(GetConnectorsRequest request);



        /// <summary>
        /// Describes the connectors registered with the Server Migration Service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnectors service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetConnectors">REST API Reference for GetConnectors Operation</seealso>
        Task<GetConnectorsResponse> GetConnectorsAsync(GetConnectorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetReplicationJobs


        /// <summary>
        /// Describes the specified replication job or all of your replication jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationJobs service method.</param>
        /// 
        /// <returns>The response from the GetReplicationJobs service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetReplicationJobs">REST API Reference for GetReplicationJobs Operation</seealso>
        GetReplicationJobsResponse GetReplicationJobs(GetReplicationJobsRequest request);



        /// <summary>
        /// Describes the specified replication job or all of your replication jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReplicationJobs service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetReplicationJobs">REST API Reference for GetReplicationJobs Operation</seealso>
        Task<GetReplicationJobsResponse> GetReplicationJobsAsync(GetReplicationJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetReplicationRuns


        /// <summary>
        /// Describes the replication runs for the specified replication job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationRuns service method.</param>
        /// 
        /// <returns>The response from the GetReplicationRuns service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetReplicationRuns">REST API Reference for GetReplicationRuns Operation</seealso>
        GetReplicationRunsResponse GetReplicationRuns(GetReplicationRunsRequest request);



        /// <summary>
        /// Describes the replication runs for the specified replication job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReplicationRuns service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetReplicationRuns">REST API Reference for GetReplicationRuns Operation</seealso>
        Task<GetReplicationRunsResponse> GetReplicationRunsAsync(GetReplicationRunsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetServers


        /// <summary>
        /// Describes the servers in your server catalog.
        /// 
        ///  
        /// <para>
        /// Before you can describe your servers, you must import them using <a>ImportServerCatalog</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServers service method.</param>
        /// 
        /// <returns>The response from the GetServers service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetServers">REST API Reference for GetServers Operation</seealso>
        GetServersResponse GetServers(GetServersRequest request);



        /// <summary>
        /// Describes the servers in your server catalog.
        /// 
        ///  
        /// <para>
        /// Before you can describe your servers, you must import them using <a>ImportServerCatalog</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServers service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetServers">REST API Reference for GetServers Operation</seealso>
        Task<GetServersResponse> GetServersAsync(GetServersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ImportAppCatalog


        /// <summary>
        /// Allows application import from Migration Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportAppCatalog service method.</param>
        /// 
        /// <returns>The response from the ImportAppCatalog service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/ImportAppCatalog">REST API Reference for ImportAppCatalog Operation</seealso>
        ImportAppCatalogResponse ImportAppCatalog(ImportAppCatalogRequest request);



        /// <summary>
        /// Allows application import from Migration Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportAppCatalog service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportAppCatalog service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/ImportAppCatalog">REST API Reference for ImportAppCatalog Operation</seealso>
        Task<ImportAppCatalogResponse> ImportAppCatalogAsync(ImportAppCatalogRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ImportServerCatalog


        /// <summary>
        /// Gathers a complete list of on-premises servers. Connectors must be installed and monitoring
        /// all servers to import.
        /// 
        ///  
        /// <para>
        /// This call returns immediately, but might take additional time to retrieve all the
        /// servers.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportServerCatalog service method.</param>
        /// 
        /// <returns>The response from the ImportServerCatalog service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.NoConnectorsAvailableException">
        /// There are no connectors available.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/ImportServerCatalog">REST API Reference for ImportServerCatalog Operation</seealso>
        ImportServerCatalogResponse ImportServerCatalog(ImportServerCatalogRequest request);



        /// <summary>
        /// Gathers a complete list of on-premises servers. Connectors must be installed and monitoring
        /// all servers to import.
        /// 
        ///  
        /// <para>
        /// This call returns immediately, but might take additional time to retrieve all the
        /// servers.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportServerCatalog service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportServerCatalog service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.NoConnectorsAvailableException">
        /// There are no connectors available.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/ImportServerCatalog">REST API Reference for ImportServerCatalog Operation</seealso>
        Task<ImportServerCatalogResponse> ImportServerCatalogAsync(ImportServerCatalogRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  LaunchApp


        /// <summary>
        /// Launches the specified application as a stack in CloudFormation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LaunchApp service method.</param>
        /// 
        /// <returns>The response from the LaunchApp service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/LaunchApp">REST API Reference for LaunchApp Operation</seealso>
        LaunchAppResponse LaunchApp(LaunchAppRequest request);



        /// <summary>
        /// Launches the specified application as a stack in CloudFormation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LaunchApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the LaunchApp service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/LaunchApp">REST API Reference for LaunchApp Operation</seealso>
        Task<LaunchAppResponse> LaunchAppAsync(LaunchAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListApps


        /// <summary>
        /// Retrieves summaries for all applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/ListApps">REST API Reference for ListApps Operation</seealso>
        ListAppsResponse ListApps(ListAppsRequest request);



        /// <summary>
        /// Retrieves summaries for all applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/ListApps">REST API Reference for ListApps Operation</seealso>
        Task<ListAppsResponse> ListAppsAsync(ListAppsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  NotifyAppValidationOutput


        /// <summary>
        /// Provides information to Server Migration Service about whether application validation
        /// is successful.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NotifyAppValidationOutput service method.</param>
        /// 
        /// <returns>The response from the NotifyAppValidationOutput service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/NotifyAppValidationOutput">REST API Reference for NotifyAppValidationOutput Operation</seealso>
        NotifyAppValidationOutputResponse NotifyAppValidationOutput(NotifyAppValidationOutputRequest request);



        /// <summary>
        /// Provides information to Server Migration Service about whether application validation
        /// is successful.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NotifyAppValidationOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NotifyAppValidationOutput service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/NotifyAppValidationOutput">REST API Reference for NotifyAppValidationOutput Operation</seealso>
        Task<NotifyAppValidationOutputResponse> NotifyAppValidationOutputAsync(NotifyAppValidationOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutAppLaunchConfiguration


        /// <summary>
        /// Creates or updates the launch configuration for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutAppLaunchConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/PutAppLaunchConfiguration">REST API Reference for PutAppLaunchConfiguration Operation</seealso>
        PutAppLaunchConfigurationResponse PutAppLaunchConfiguration(PutAppLaunchConfigurationRequest request);



        /// <summary>
        /// Creates or updates the launch configuration for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppLaunchConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAppLaunchConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/PutAppLaunchConfiguration">REST API Reference for PutAppLaunchConfiguration Operation</seealso>
        Task<PutAppLaunchConfigurationResponse> PutAppLaunchConfigurationAsync(PutAppLaunchConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutAppReplicationConfiguration


        /// <summary>
        /// Creates or updates the replication configuration for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppReplicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutAppReplicationConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/PutAppReplicationConfiguration">REST API Reference for PutAppReplicationConfiguration Operation</seealso>
        PutAppReplicationConfigurationResponse PutAppReplicationConfiguration(PutAppReplicationConfigurationRequest request);



        /// <summary>
        /// Creates or updates the replication configuration for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppReplicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAppReplicationConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/PutAppReplicationConfiguration">REST API Reference for PutAppReplicationConfiguration Operation</seealso>
        Task<PutAppReplicationConfigurationResponse> PutAppReplicationConfigurationAsync(PutAppReplicationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutAppValidationConfiguration


        /// <summary>
        /// Creates or updates a validation configuration for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppValidationConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutAppValidationConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/PutAppValidationConfiguration">REST API Reference for PutAppValidationConfiguration Operation</seealso>
        PutAppValidationConfigurationResponse PutAppValidationConfiguration(PutAppValidationConfigurationRequest request);



        /// <summary>
        /// Creates or updates a validation configuration for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppValidationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAppValidationConfiguration service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/PutAppValidationConfiguration">REST API Reference for PutAppValidationConfiguration Operation</seealso>
        Task<PutAppValidationConfigurationResponse> PutAppValidationConfigurationAsync(PutAppValidationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartAppReplication


        /// <summary>
        /// Starts replicating the specified application by creating replication jobs for each
        /// server in the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAppReplication service method.</param>
        /// 
        /// <returns>The response from the StartAppReplication service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StartAppReplication">REST API Reference for StartAppReplication Operation</seealso>
        StartAppReplicationResponse StartAppReplication(StartAppReplicationRequest request);



        /// <summary>
        /// Starts replicating the specified application by creating replication jobs for each
        /// server in the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAppReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAppReplication service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StartAppReplication">REST API Reference for StartAppReplication Operation</seealso>
        Task<StartAppReplicationResponse> StartAppReplicationAsync(StartAppReplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartOnDemandAppReplication


        /// <summary>
        /// Starts an on-demand replication run for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartOnDemandAppReplication service method.</param>
        /// 
        /// <returns>The response from the StartOnDemandAppReplication service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StartOnDemandAppReplication">REST API Reference for StartOnDemandAppReplication Operation</seealso>
        StartOnDemandAppReplicationResponse StartOnDemandAppReplication(StartOnDemandAppReplicationRequest request);



        /// <summary>
        /// Starts an on-demand replication run for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartOnDemandAppReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartOnDemandAppReplication service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StartOnDemandAppReplication">REST API Reference for StartOnDemandAppReplication Operation</seealso>
        Task<StartOnDemandAppReplicationResponse> StartOnDemandAppReplicationAsync(StartOnDemandAppReplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartOnDemandReplicationRun


        /// <summary>
        /// Starts an on-demand replication run for the specified replication job. This replication
        /// run starts immediately. This replication run is in addition to the ones already scheduled.
        /// 
        ///  
        /// <para>
        /// There is a limit on the number of on-demand replications runs that you can request
        /// in a 24-hour period.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartOnDemandReplicationRun service method.</param>
        /// 
        /// <returns>The response from the StartOnDemandReplicationRun service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.DryRunOperationException">
        /// The user has the required permissions, so the request would have succeeded, but a
        /// dry run was performed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ReplicationRunLimitExceededException">
        /// You have exceeded the number of on-demand replication runs you can request in a 24-hour
        /// period.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StartOnDemandReplicationRun">REST API Reference for StartOnDemandReplicationRun Operation</seealso>
        StartOnDemandReplicationRunResponse StartOnDemandReplicationRun(StartOnDemandReplicationRunRequest request);



        /// <summary>
        /// Starts an on-demand replication run for the specified replication job. This replication
        /// run starts immediately. This replication run is in addition to the ones already scheduled.
        /// 
        ///  
        /// <para>
        /// There is a limit on the number of on-demand replications runs that you can request
        /// in a 24-hour period.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartOnDemandReplicationRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartOnDemandReplicationRun service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.DryRunOperationException">
        /// The user has the required permissions, so the request would have succeeded, but a
        /// dry run was performed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ReplicationRunLimitExceededException">
        /// You have exceeded the number of on-demand replication runs you can request in a 24-hour
        /// period.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StartOnDemandReplicationRun">REST API Reference for StartOnDemandReplicationRun Operation</seealso>
        Task<StartOnDemandReplicationRunResponse> StartOnDemandReplicationRunAsync(StartOnDemandReplicationRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopAppReplication


        /// <summary>
        /// Stops replicating the specified application by deleting the replication job for each
        /// server in the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAppReplication service method.</param>
        /// 
        /// <returns>The response from the StopAppReplication service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StopAppReplication">REST API Reference for StopAppReplication Operation</seealso>
        StopAppReplicationResponse StopAppReplication(StopAppReplicationRequest request);



        /// <summary>
        /// Stops replicating the specified application by deleting the replication job for each
        /// server in the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAppReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopAppReplication service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StopAppReplication">REST API Reference for StopAppReplication Operation</seealso>
        Task<StopAppReplicationResponse> StopAppReplicationAsync(StopAppReplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TerminateApp


        /// <summary>
        /// Terminates the stack for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateApp service method.</param>
        /// 
        /// <returns>The response from the TerminateApp service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/TerminateApp">REST API Reference for TerminateApp Operation</seealso>
        TerminateAppResponse TerminateApp(TerminateAppRequest request);



        /// <summary>
        /// Terminates the stack for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateApp service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/TerminateApp">REST API Reference for TerminateApp Operation</seealso>
        Task<TerminateAppResponse> TerminateAppAsync(TerminateAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateApp


        /// <summary>
        /// Updates the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp service method.</param>
        /// 
        /// <returns>The response from the UpdateApp service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        UpdateAppResponse UpdateApp(UpdateAppRequest request);



        /// <summary>
        /// Updates the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApp service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateReplicationJob


        /// <summary>
        /// Updates the specified settings for the specified replication job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationJob service method.</param>
        /// 
        /// <returns>The response from the UpdateReplicationJob service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ReplicationJobNotFoundException">
        /// The specified replication job does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ServerCannotBeReplicatedException">
        /// The specified server cannot be replicated.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.TemporarilyUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/UpdateReplicationJob">REST API Reference for UpdateReplicationJob Operation</seealso>
        UpdateReplicationJobResponse UpdateReplicationJob(UpdateReplicationJobRequest request);



        /// <summary>
        /// Updates the specified settings for the specified replication job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateReplicationJob service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A specified parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// A required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ReplicationJobNotFoundException">
        /// The specified replication job does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ServerCannotBeReplicatedException">
        /// The specified server cannot be replicated.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.TemporarilyUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// You lack permissions needed to perform this operation. Check your IAM policies, and
        /// ensure that you are using the correct access keys.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/UpdateReplicationJob">REST API Reference for UpdateReplicationJob Operation</seealso>
        Task<UpdateReplicationJobResponse> UpdateReplicationJobAsync(UpdateReplicationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}