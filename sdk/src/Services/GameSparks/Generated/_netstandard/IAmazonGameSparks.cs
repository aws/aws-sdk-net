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
 * Do not modify this file. This file is generated from the gamesparks-2021-08-17.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.GameSparks.Model;

namespace Amazon.GameSparks
{
    /// <summary>
    /// Interface for accessing GameSparks
    ///
    /// 
    /// </summary>
    public partial interface IAmazonGameSparks : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IGameSparksPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateGame



        /// <summary>
        /// Creates a new game with an empty configuration. After creating your game, you can
        /// update the configuration using <code>UpdateGameConfiguration</code> or <code>ImportGameConfiguration</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGame service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGame service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ServiceQuotaExceededException">
        /// The request would result in exceeding service quota.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/CreateGame">REST API Reference for CreateGame Operation</seealso>
        Task<CreateGameResponse> CreateGameAsync(CreateGameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSnapshot



        /// <summary>
        /// Creates a snapshot of the game configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateStage



        /// <summary>
        /// Creates a new stage for stage-by-stage game development and deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStage service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/CreateStage">REST API Reference for CreateStage Operation</seealso>
        Task<CreateStageResponse> CreateStageAsync(CreateStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGame



        /// <summary>
        /// Deletes a game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGame service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGame service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/DeleteGame">REST API Reference for DeleteGame Operation</seealso>
        Task<DeleteGameResponse> DeleteGameAsync(DeleteGameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteStage



        /// <summary>
        /// Deletes a stage from a game, along with the associated game runtime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStage service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        Task<DeleteStageResponse> DeleteStageAsync(DeleteStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisconnectPlayer



        /// <summary>
        /// Disconnects a player from the game runtime.
        /// 
        ///  
        /// <para>
        ///  If a player has multiple connections, this operation attempts to close all of them.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectPlayer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisconnectPlayer service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/DisconnectPlayer">REST API Reference for DisconnectPlayer Operation</seealso>
        Task<DisconnectPlayerResponse> DisconnectPlayerAsync(DisconnectPlayerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExportSnapshot



        /// <summary>
        /// Exports a game configuration snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportSnapshot service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ExportSnapshot">REST API Reference for ExportSnapshot Operation</seealso>
        Task<ExportSnapshotResponse> ExportSnapshotAsync(ExportSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetExtension



        /// <summary>
        /// Gets details about a specified extension.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExtension service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExtension service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetExtension">REST API Reference for GetExtension Operation</seealso>
        Task<GetExtensionResponse> GetExtensionAsync(GetExtensionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetExtensionVersion



        /// <summary>
        /// Gets details about a specified extension version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExtensionVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExtensionVersion service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetExtensionVersion">REST API Reference for GetExtensionVersion Operation</seealso>
        Task<GetExtensionVersionResponse> GetExtensionVersionAsync(GetExtensionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGame



        /// <summary>
        /// Gets details about a game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGame service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGame service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetGame">REST API Reference for GetGame Operation</seealso>
        Task<GetGameResponse> GetGameAsync(GetGameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGameConfiguration



        /// <summary>
        /// Gets the configuration of the game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGameConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGameConfiguration service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetGameConfiguration">REST API Reference for GetGameConfiguration Operation</seealso>
        Task<GetGameConfigurationResponse> GetGameConfigurationAsync(GetGameConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGeneratedCodeJob



        /// <summary>
        /// Gets details about a job that is generating code for a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeneratedCodeJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGeneratedCodeJob service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetGeneratedCodeJob">REST API Reference for GetGeneratedCodeJob Operation</seealso>
        Task<GetGeneratedCodeJobResponse> GetGeneratedCodeJobAsync(GetGeneratedCodeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPlayerConnectionStatus



        /// <summary>
        /// Gets the status of a player's connection to the game runtime.
        /// 
        ///  
        /// <para>
        ///  It's possible for a single player to have multiple connections to the game runtime.
        /// If a player is not connected, this operation returns an empty list. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlayerConnectionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPlayerConnectionStatus service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetPlayerConnectionStatus">REST API Reference for GetPlayerConnectionStatus Operation</seealso>
        Task<GetPlayerConnectionStatusResponse> GetPlayerConnectionStatusAsync(GetPlayerConnectionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSnapshot



        /// <summary>
        /// Gets a copy of the game configuration in a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSnapshot service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetSnapshot">REST API Reference for GetSnapshot Operation</seealso>
        Task<GetSnapshotResponse> GetSnapshotAsync(GetSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetStage



        /// <summary>
        /// Gets information about a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStage service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetStage">REST API Reference for GetStage Operation</seealso>
        Task<GetStageResponse> GetStageAsync(GetStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetStageDeployment



        /// <summary>
        /// Gets information about a stage deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStageDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStageDeployment service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetStageDeployment">REST API Reference for GetStageDeployment Operation</seealso>
        Task<GetStageDeploymentResponse> GetStageDeploymentAsync(GetStageDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportGameConfiguration



        /// <summary>
        /// Imports a game configuration.
        /// 
        ///  
        /// <para>
        ///  This operation replaces the current configuration of the game with the provided input.
        /// This is not a reversible operation. If you want to preserve the previous configuration,
        /// use <code>CreateSnapshot</code> to make a new snapshot before importing. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportGameConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportGameConfiguration service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ServiceQuotaExceededException">
        /// The request would result in exceeding service quota.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ImportGameConfiguration">REST API Reference for ImportGameConfiguration Operation</seealso>
        Task<ImportGameConfigurationResponse> ImportGameConfigurationAsync(ImportGameConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListExtensions



        /// <summary>
        /// Gets a paginated list of available extensions.
        /// 
        ///  
        /// <para>
        ///  Extensions provide features that games can use from scripts. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExtensions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExtensions service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListExtensions">REST API Reference for ListExtensions Operation</seealso>
        Task<ListExtensionsResponse> ListExtensionsAsync(ListExtensionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListExtensionVersions



        /// <summary>
        /// Gets a paginated list of available versions for the extension.
        /// 
        ///  
        /// <para>
        ///  Each time an API change is made to an extension, the version is incremented. The
        /// list retrieved by this operation shows the versions that are currently available.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExtensionVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExtensionVersions service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListExtensionVersions">REST API Reference for ListExtensionVersions Operation</seealso>
        Task<ListExtensionVersionsResponse> ListExtensionVersionsAsync(ListExtensionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGames



        /// <summary>
        /// Gets a paginated list of games.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGames service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGames service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListGames">REST API Reference for ListGames Operation</seealso>
        Task<ListGamesResponse> ListGamesAsync(ListGamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGeneratedCodeJobs



        /// <summary>
        /// Gets a paginated list of code generation jobs for a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeneratedCodeJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGeneratedCodeJobs service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListGeneratedCodeJobs">REST API Reference for ListGeneratedCodeJobs Operation</seealso>
        Task<ListGeneratedCodeJobsResponse> ListGeneratedCodeJobsAsync(ListGeneratedCodeJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSnapshots



        /// <summary>
        /// Gets a paginated list of snapshot summaries from the game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSnapshots service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListSnapshots">REST API Reference for ListSnapshots Operation</seealso>
        Task<ListSnapshotsResponse> ListSnapshotsAsync(ListSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListStageDeployments



        /// <summary>
        /// Gets a paginated list of stage deployment summaries from the game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStageDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStageDeployments service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListStageDeployments">REST API Reference for ListStageDeployments Operation</seealso>
        Task<ListStageDeploymentsResponse> ListStageDeploymentsAsync(ListStageDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListStages



        /// <summary>
        /// Gets a paginated list of stage summaries from the game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStages service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListStages">REST API Reference for ListStages Operation</seealso>
        Task<ListStagesResponse> ListStagesAsync(ListStagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags associated with a GameSparks resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartGeneratedCodeJob



        /// <summary>
        /// Starts an asynchronous process that generates client code for system-defined and
        /// custom messages. The resulting code is collected as a .zip file and uploaded to a
        /// pre-signed Amazon S3 URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartGeneratedCodeJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartGeneratedCodeJob service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/StartGeneratedCodeJob">REST API Reference for StartGeneratedCodeJob Operation</seealso>
        Task<StartGeneratedCodeJobResponse> StartGeneratedCodeJobAsync(StartGeneratedCodeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartStageDeployment



        /// <summary>
        /// Deploys a snapshot to the stage and creates a new game runtime.
        /// 
        ///  
        /// <para>
        ///  After you call this operation, you can check the deployment status by using <code>GetStageDeployment</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  If there are any players connected to the previous game runtime, then both runtimes
        /// persist. Existing connections to the previous runtime are maintained. When players
        /// disconnect and reconnect, they connect to the new runtime. After there are no connections
        /// to the previous game runtime, it is deleted. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartStageDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartStageDeployment service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/StartStageDeployment">REST API Reference for StartStageDeployment Operation</seealso>
        Task<StartStageDeploymentResponse> StartStageDeploymentAsync(StartStageDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds tags to a GameSparks resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from a GameSparks resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGame



        /// <summary>
        /// Updates details of the game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGame service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGame service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateGame">REST API Reference for UpdateGame Operation</seealso>
        Task<UpdateGameResponse> UpdateGameAsync(UpdateGameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGameConfiguration



        /// <summary>
        /// Updates one or more sections of the game configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGameConfiguration service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ServiceQuotaExceededException">
        /// The request would result in exceeding service quota.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateGameConfiguration">REST API Reference for UpdateGameConfiguration Operation</seealso>
        Task<UpdateGameConfigurationResponse> UpdateGameConfigurationAsync(UpdateGameConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSnapshot



        /// <summary>
        /// Updates the metadata of a GameSparks snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSnapshot service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateSnapshot">REST API Reference for UpdateSnapshot Operation</seealso>
        Task<UpdateSnapshotResponse> UpdateSnapshotAsync(UpdateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateStage



        /// <summary>
        /// Updates the metadata of a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStage service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        Task<UpdateStageResponse> UpdateStageAsync(UpdateStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}