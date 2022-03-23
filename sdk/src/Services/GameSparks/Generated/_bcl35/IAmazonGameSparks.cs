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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
        CreateGameResponse CreateGame(CreateGameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGame operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGame operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGame
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/CreateGame">REST API Reference for CreateGame Operation</seealso>
        IAsyncResult BeginCreateGame(CreateGameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGame operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGame.</param>
        /// 
        /// <returns>Returns a  CreateGameResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/CreateGame">REST API Reference for CreateGame Operation</seealso>
        CreateGameResponse EndCreateGame(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSnapshot


        /// <summary>
        /// Creates a snapshot of the game configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
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
        CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        IAsyncResult BeginCreateSnapshot(CreateSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateSnapshotResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        CreateSnapshotResponse EndCreateSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStage


        /// <summary>
        /// Creates a new stage for stage-by-stage game development and deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStage service method.</param>
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
        CreateStageResponse CreateStage(CreateStageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStage operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/CreateStage">REST API Reference for CreateStage Operation</seealso>
        IAsyncResult BeginCreateStage(CreateStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStage.</param>
        /// 
        /// <returns>Returns a  CreateStageResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/CreateStage">REST API Reference for CreateStage Operation</seealso>
        CreateStageResponse EndCreateStage(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGame


        /// <summary>
        /// Deletes a game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGame service method.</param>
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
        DeleteGameResponse DeleteGame(DeleteGameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGame operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGame operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGame
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/DeleteGame">REST API Reference for DeleteGame Operation</seealso>
        IAsyncResult BeginDeleteGame(DeleteGameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGame operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGame.</param>
        /// 
        /// <returns>Returns a  DeleteGameResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/DeleteGame">REST API Reference for DeleteGame Operation</seealso>
        DeleteGameResponse EndDeleteGame(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStage


        /// <summary>
        /// Deletes a stage from a game, along with the associated game runtime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage service method.</param>
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
        DeleteStageResponse DeleteStage(DeleteStageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        IAsyncResult BeginDeleteStage(DeleteStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStage.</param>
        /// 
        /// <returns>Returns a  DeleteStageResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        DeleteStageResponse EndDeleteStage(IAsyncResult asyncResult);

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
        DisconnectPlayerResponse DisconnectPlayer(DisconnectPlayerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisconnectPlayer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisconnectPlayer operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisconnectPlayer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/DisconnectPlayer">REST API Reference for DisconnectPlayer Operation</seealso>
        IAsyncResult BeginDisconnectPlayer(DisconnectPlayerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisconnectPlayer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisconnectPlayer.</param>
        /// 
        /// <returns>Returns a  DisconnectPlayerResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/DisconnectPlayer">REST API Reference for DisconnectPlayer Operation</seealso>
        DisconnectPlayerResponse EndDisconnectPlayer(IAsyncResult asyncResult);

        #endregion
        
        #region  ExportSnapshot


        /// <summary>
        /// Exports a game configuration snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportSnapshot service method.</param>
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
        ExportSnapshotResponse ExportSnapshot(ExportSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExportSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportSnapshot operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ExportSnapshot">REST API Reference for ExportSnapshot Operation</seealso>
        IAsyncResult BeginExportSnapshot(ExportSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExportSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportSnapshot.</param>
        /// 
        /// <returns>Returns a  ExportSnapshotResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ExportSnapshot">REST API Reference for ExportSnapshot Operation</seealso>
        ExportSnapshotResponse EndExportSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  GetExtension


        /// <summary>
        /// Gets details about a specified extension.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExtension service method.</param>
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
        GetExtensionResponse GetExtension(GetExtensionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetExtension operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExtension operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExtension
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetExtension">REST API Reference for GetExtension Operation</seealso>
        IAsyncResult BeginGetExtension(GetExtensionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetExtension operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExtension.</param>
        /// 
        /// <returns>Returns a  GetExtensionResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetExtension">REST API Reference for GetExtension Operation</seealso>
        GetExtensionResponse EndGetExtension(IAsyncResult asyncResult);

        #endregion
        
        #region  GetExtensionVersion


        /// <summary>
        /// Gets details about a specified extension version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExtensionVersion service method.</param>
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
        GetExtensionVersionResponse GetExtensionVersion(GetExtensionVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetExtensionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExtensionVersion operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExtensionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetExtensionVersion">REST API Reference for GetExtensionVersion Operation</seealso>
        IAsyncResult BeginGetExtensionVersion(GetExtensionVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetExtensionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExtensionVersion.</param>
        /// 
        /// <returns>Returns a  GetExtensionVersionResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetExtensionVersion">REST API Reference for GetExtensionVersion Operation</seealso>
        GetExtensionVersionResponse EndGetExtensionVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGame


        /// <summary>
        /// Gets details about a game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGame service method.</param>
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
        GetGameResponse GetGame(GetGameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGame operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGame operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGame
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetGame">REST API Reference for GetGame Operation</seealso>
        IAsyncResult BeginGetGame(GetGameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGame operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGame.</param>
        /// 
        /// <returns>Returns a  GetGameResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetGame">REST API Reference for GetGame Operation</seealso>
        GetGameResponse EndGetGame(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGameConfiguration


        /// <summary>
        /// Gets the configuration of the game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGameConfiguration service method.</param>
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
        GetGameConfigurationResponse GetGameConfiguration(GetGameConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGameConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGameConfiguration operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGameConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetGameConfiguration">REST API Reference for GetGameConfiguration Operation</seealso>
        IAsyncResult BeginGetGameConfiguration(GetGameConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGameConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGameConfiguration.</param>
        /// 
        /// <returns>Returns a  GetGameConfigurationResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetGameConfiguration">REST API Reference for GetGameConfiguration Operation</seealso>
        GetGameConfigurationResponse EndGetGameConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGeneratedCodeJob


        /// <summary>
        /// Gets details about a job that is generating code for a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeneratedCodeJob service method.</param>
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
        GetGeneratedCodeJobResponse GetGeneratedCodeJob(GetGeneratedCodeJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGeneratedCodeJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGeneratedCodeJob operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGeneratedCodeJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetGeneratedCodeJob">REST API Reference for GetGeneratedCodeJob Operation</seealso>
        IAsyncResult BeginGetGeneratedCodeJob(GetGeneratedCodeJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGeneratedCodeJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGeneratedCodeJob.</param>
        /// 
        /// <returns>Returns a  GetGeneratedCodeJobResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetGeneratedCodeJob">REST API Reference for GetGeneratedCodeJob Operation</seealso>
        GetGeneratedCodeJobResponse EndGetGeneratedCodeJob(IAsyncResult asyncResult);

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
        GetPlayerConnectionStatusResponse GetPlayerConnectionStatus(GetPlayerConnectionStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPlayerConnectionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlayerConnectionStatus operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPlayerConnectionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetPlayerConnectionStatus">REST API Reference for GetPlayerConnectionStatus Operation</seealso>
        IAsyncResult BeginGetPlayerConnectionStatus(GetPlayerConnectionStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPlayerConnectionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPlayerConnectionStatus.</param>
        /// 
        /// <returns>Returns a  GetPlayerConnectionStatusResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetPlayerConnectionStatus">REST API Reference for GetPlayerConnectionStatus Operation</seealso>
        GetPlayerConnectionStatusResponse EndGetPlayerConnectionStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSnapshot


        /// <summary>
        /// Gets a copy of the game configuration in a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshot service method.</param>
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
        GetSnapshotResponse GetSnapshot(GetSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshot operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetSnapshot">REST API Reference for GetSnapshot Operation</seealso>
        IAsyncResult BeginGetSnapshot(GetSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSnapshot.</param>
        /// 
        /// <returns>Returns a  GetSnapshotResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetSnapshot">REST API Reference for GetSnapshot Operation</seealso>
        GetSnapshotResponse EndGetSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStage


        /// <summary>
        /// Gets information about a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStage service method.</param>
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
        GetStageResponse GetStage(GetStageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStage operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetStage">REST API Reference for GetStage Operation</seealso>
        IAsyncResult BeginGetStage(GetStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStage.</param>
        /// 
        /// <returns>Returns a  GetStageResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetStage">REST API Reference for GetStage Operation</seealso>
        GetStageResponse EndGetStage(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStageDeployment


        /// <summary>
        /// Gets information about a stage deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStageDeployment service method.</param>
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
        GetStageDeploymentResponse GetStageDeployment(GetStageDeploymentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStageDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStageDeployment operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStageDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetStageDeployment">REST API Reference for GetStageDeployment Operation</seealso>
        IAsyncResult BeginGetStageDeployment(GetStageDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStageDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStageDeployment.</param>
        /// 
        /// <returns>Returns a  GetStageDeploymentResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetStageDeployment">REST API Reference for GetStageDeployment Operation</seealso>
        GetStageDeploymentResponse EndGetStageDeployment(IAsyncResult asyncResult);

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
        ImportGameConfigurationResponse ImportGameConfiguration(ImportGameConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportGameConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportGameConfiguration operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportGameConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ImportGameConfiguration">REST API Reference for ImportGameConfiguration Operation</seealso>
        IAsyncResult BeginImportGameConfiguration(ImportGameConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportGameConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportGameConfiguration.</param>
        /// 
        /// <returns>Returns a  ImportGameConfigurationResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ImportGameConfiguration">REST API Reference for ImportGameConfiguration Operation</seealso>
        ImportGameConfigurationResponse EndImportGameConfiguration(IAsyncResult asyncResult);

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
        ListExtensionsResponse ListExtensions(ListExtensionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListExtensions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExtensions operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExtensions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListExtensions">REST API Reference for ListExtensions Operation</seealso>
        IAsyncResult BeginListExtensions(ListExtensionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListExtensions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExtensions.</param>
        /// 
        /// <returns>Returns a  ListExtensionsResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListExtensions">REST API Reference for ListExtensions Operation</seealso>
        ListExtensionsResponse EndListExtensions(IAsyncResult asyncResult);

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
        ListExtensionVersionsResponse ListExtensionVersions(ListExtensionVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListExtensionVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExtensionVersions operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExtensionVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListExtensionVersions">REST API Reference for ListExtensionVersions Operation</seealso>
        IAsyncResult BeginListExtensionVersions(ListExtensionVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListExtensionVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExtensionVersions.</param>
        /// 
        /// <returns>Returns a  ListExtensionVersionsResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListExtensionVersions">REST API Reference for ListExtensionVersions Operation</seealso>
        ListExtensionVersionsResponse EndListExtensionVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGames


        /// <summary>
        /// Gets a paginated list of games.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGames service method.</param>
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
        ListGamesResponse ListGames(ListGamesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGames operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGames
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListGames">REST API Reference for ListGames Operation</seealso>
        IAsyncResult BeginListGames(ListGamesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGames.</param>
        /// 
        /// <returns>Returns a  ListGamesResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListGames">REST API Reference for ListGames Operation</seealso>
        ListGamesResponse EndListGames(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGeneratedCodeJobs


        /// <summary>
        /// Gets a paginated list of code generation jobs for a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeneratedCodeJobs service method.</param>
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
        ListGeneratedCodeJobsResponse ListGeneratedCodeJobs(ListGeneratedCodeJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGeneratedCodeJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGeneratedCodeJobs operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGeneratedCodeJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListGeneratedCodeJobs">REST API Reference for ListGeneratedCodeJobs Operation</seealso>
        IAsyncResult BeginListGeneratedCodeJobs(ListGeneratedCodeJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGeneratedCodeJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGeneratedCodeJobs.</param>
        /// 
        /// <returns>Returns a  ListGeneratedCodeJobsResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListGeneratedCodeJobs">REST API Reference for ListGeneratedCodeJobs Operation</seealso>
        ListGeneratedCodeJobsResponse EndListGeneratedCodeJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSnapshots


        /// <summary>
        /// Gets a paginated list of snapshot summaries from the game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshots service method.</param>
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
        ListSnapshotsResponse ListSnapshots(ListSnapshotsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshots operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListSnapshots">REST API Reference for ListSnapshots Operation</seealso>
        IAsyncResult BeginListSnapshots(ListSnapshotsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSnapshots.</param>
        /// 
        /// <returns>Returns a  ListSnapshotsResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListSnapshots">REST API Reference for ListSnapshots Operation</seealso>
        ListSnapshotsResponse EndListSnapshots(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStageDeployments


        /// <summary>
        /// Gets a paginated list of stage deployment summaries from the game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStageDeployments service method.</param>
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
        ListStageDeploymentsResponse ListStageDeployments(ListStageDeploymentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStageDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStageDeployments operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStageDeployments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListStageDeployments">REST API Reference for ListStageDeployments Operation</seealso>
        IAsyncResult BeginListStageDeployments(ListStageDeploymentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStageDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStageDeployments.</param>
        /// 
        /// <returns>Returns a  ListStageDeploymentsResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListStageDeployments">REST API Reference for ListStageDeployments Operation</seealso>
        ListStageDeploymentsResponse EndListStageDeployments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStages


        /// <summary>
        /// Gets a paginated list of stage summaries from the game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStages service method.</param>
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
        ListStagesResponse ListStages(ListStagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStages operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListStages">REST API Reference for ListStages Operation</seealso>
        IAsyncResult BeginListStages(ListStagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStages.</param>
        /// 
        /// <returns>Returns a  ListStagesResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListStages">REST API Reference for ListStages Operation</seealso>
        ListStagesResponse EndListStages(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags associated with a GameSparks resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  StartGeneratedCodeJob


        /// <summary>
        /// Starts an asynchronous process that generates client code for system-defined and
        /// custom messages. The resulting code is collected as a .zip file and uploaded to a
        /// pre-signed Amazon S3 URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartGeneratedCodeJob service method.</param>
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
        StartGeneratedCodeJobResponse StartGeneratedCodeJob(StartGeneratedCodeJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartGeneratedCodeJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartGeneratedCodeJob operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartGeneratedCodeJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/StartGeneratedCodeJob">REST API Reference for StartGeneratedCodeJob Operation</seealso>
        IAsyncResult BeginStartGeneratedCodeJob(StartGeneratedCodeJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartGeneratedCodeJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartGeneratedCodeJob.</param>
        /// 
        /// <returns>Returns a  StartGeneratedCodeJobResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/StartGeneratedCodeJob">REST API Reference for StartGeneratedCodeJob Operation</seealso>
        StartGeneratedCodeJobResponse EndStartGeneratedCodeJob(IAsyncResult asyncResult);

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
        StartStageDeploymentResponse StartStageDeployment(StartStageDeploymentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartStageDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartStageDeployment operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartStageDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/StartStageDeployment">REST API Reference for StartStageDeployment Operation</seealso>
        IAsyncResult BeginStartStageDeployment(StartStageDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartStageDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartStageDeployment.</param>
        /// 
        /// <returns>Returns a  StartStageDeploymentResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/StartStageDeployment">REST API Reference for StartStageDeployment Operation</seealso>
        StartStageDeploymentResponse EndStartStageDeployment(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a GameSparks resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a GameSparks resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGame


        /// <summary>
        /// Updates details of the game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGame service method.</param>
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
        UpdateGameResponse UpdateGame(UpdateGameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGame operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGame operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGame
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateGame">REST API Reference for UpdateGame Operation</seealso>
        IAsyncResult BeginUpdateGame(UpdateGameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGame operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGame.</param>
        /// 
        /// <returns>Returns a  UpdateGameResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateGame">REST API Reference for UpdateGame Operation</seealso>
        UpdateGameResponse EndUpdateGame(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGameConfiguration


        /// <summary>
        /// Updates one or more sections of the game configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameConfiguration service method.</param>
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
        UpdateGameConfigurationResponse UpdateGameConfiguration(UpdateGameConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGameConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameConfiguration operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGameConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateGameConfiguration">REST API Reference for UpdateGameConfiguration Operation</seealso>
        IAsyncResult BeginUpdateGameConfiguration(UpdateGameConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGameConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGameConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateGameConfigurationResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateGameConfiguration">REST API Reference for UpdateGameConfiguration Operation</seealso>
        UpdateGameConfigurationResponse EndUpdateGameConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSnapshot


        /// <summary>
        /// Updates the metadata of a GameSparks snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshot service method.</param>
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
        UpdateSnapshotResponse UpdateSnapshot(UpdateSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshot operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateSnapshot">REST API Reference for UpdateSnapshot Operation</seealso>
        IAsyncResult BeginUpdateSnapshot(UpdateSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSnapshot.</param>
        /// 
        /// <returns>Returns a  UpdateSnapshotResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateSnapshot">REST API Reference for UpdateSnapshot Operation</seealso>
        UpdateSnapshotResponse EndUpdateSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateStage


        /// <summary>
        /// Updates the metadata of a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage service method.</param>
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
        UpdateStageResponse UpdateStage(UpdateStageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        IAsyncResult BeginUpdateStage(UpdateStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStage.</param>
        /// 
        /// <returns>Returns a  UpdateStageResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        UpdateStageResponse EndUpdateStage(IAsyncResult asyncResult);

        #endregion
        
    }
}