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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.GameLift.Model;

namespace Amazon.GameLift
{
    /// <summary>
    /// Interface for accessing GameLift
    ///
    /// Amazon GameLift Service 
    /// <para>
    /// Welcome to the <i>Amazon GameLift API Reference</i>. Amazon GameLift is a managed
    /// Amazon Web Services (AWS) service for developers who need a scalable, server-based
    /// solution for multiplayer games. Amazon GameLift provides setup and deployment of game
    /// servers, and handles infrastructure scaling and session management.
    /// </para>
    ///  
    /// <para>
    /// This reference describes the low-level service API for GameLift. You can call this
    /// API directly or use the <a href="https://aws.amazon.com/tools/">AWS SDK</a> for your
    /// preferred language. The AWS SDK includes a set of high-level GameLift actions multiplayer
    /// game sessions. Alternatively, you can use the <a href="https://aws.amazon.com/cli/">AWS
    /// command-line interface</a> (CLI) tool, which includes commands for GameLift. For administrative
    /// actions, you can also use the Amazon GameLift console. 
    /// </para>
    ///  
    /// <para>
    /// <b>More Resources</b>
    /// </para>
    ///  <ul> <li> <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/">Amazon
    /// GameLift Developer Guide</a>: Learn more about GameLift features and how to use them
    /// </li> <li> <a href="https://gamedev.amazon.com/forums/tutorials">Lumberyard and GameLift
    /// Tutorials</a>: Get started fast with walkthroughs and sample projects</li> <li> <a
    /// href="https://aws.amazon.com/blogs/gamedev/">GameDev Blog</a>: Stay up to date with
    /// new features and techniques</li> <li> <a href="https://gamedev.amazon.com/forums/spaces/123/gamelift-discussion.html">GameDev
    /// Forums</a>: Connect with the GameDev community</li> </ul> 
    /// <para>
    /// <b>Manage Games and Players Through GameLift</b>
    /// </para>
    ///  
    /// <para>
    /// Call these actions from your game clients and/or services to create and manage multiplayer
    /// game sessions and player sessions.
    /// </para>
    ///  <ul> <li> <b>Game sessions</b> <ul> <li><a>CreateGameSession</a></li> <li><a>DescribeGameSessions</a></li>
    /// <li><a>DescribeGameSessionDetails</a></li> <li><a>UpdateGameSession</a></li> </ul>
    /// </li> <li> <b>Player sessions</b> <ul> <li><a>CreatePlayerSession</a></li> <li><a>CreatePlayerSessions</a></li>
    /// <li><a>DescribePlayerSessions</a></li> </ul> </li> <li> <b>Other actions:</b> <ul>
    /// <li><a>GetGameSessionLogUrl</a></li> </ul> </li> </ul> 
    /// <para>
    /// <b>Set Up and Manage Game Servers</b>
    /// </para>
    ///  
    /// <para>
    /// Use these administrative actions to configure GameLift to host your game servers.
    /// When setting up GameLift, you'll need to (1) configure a build for your game and upload
    /// build files, and (2) set up one or more fleets to host game sessions. Once you've
    /// created and activated a fleet, you can assign aliases to it, scale capacity, track
    /// performance and utilization, etc.
    /// </para>
    ///  <ul> <li> <b>Manage your builds:</b> <ul> <li><a>ListBuilds</a></li> <li><a>CreateBuild</a></li>
    /// <li><a>DescribeBuild</a></li> <li><a>UpdateBuild</a></li> <li><a>DeleteBuild</a></li>
    /// <li><a>RequestUploadCredentials</a></li> </ul> </li> <li> <b>Manage your fleets:</b>
    /// <ul> <li><a>ListFleets</a></li> <li><a>CreateFleet</a></li> <li>Describe fleets: <ul>
    /// <li><a>DescribeFleetAttributes</a></li> <li><a>DescribeFleetCapacity</a></li> <li><a>DescribeFleetPortSettings</a></li>
    /// <li><a>DescribeFleetUtilization</a></li> <li><a>DescribeEC2InstanceLimits</a></li>
    /// <li><a>DescribeFleetEvents</a></li> <li><a>DescribeRuntimeConfiguration</a></li> </ul>
    /// </li> <li>Update fleets: <ul> <li><a>UpdateFleetAttributes</a></li> <li><a>UpdateFleetCapacity</a></li>
    /// <li><a>UpdateFleetPortSettings</a></li> <li><a>UpdateRuntimeConfiguration</a></li>
    /// </ul> </li> <li><a>DeleteFleet</a></li> </ul> </li> <li> <b>Manage fleet aliases:</b>
    /// <ul> <li><a>ListAliases</a></li> <li><a>CreateAlias</a></li> <li><a>DescribeAlias</a></li>
    /// <li><a>UpdateAlias</a></li> <li><a>DeleteAlias</a></li> <li><a>ResolveAlias</a></li>
    /// </ul> </li> <li> <b>Manage autoscaling:</b> <ul> <li><a>PutScalingPolicy</a></li>
    /// <li><a>DescribeScalingPolicies</a></li> <li><a>DeleteScalingPolicy</a></li> </ul>
    /// </li> </ul> 
    /// <para>
    /// To view changes to the API, see the GameLift <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/doc-history.html">Document
    /// History</a> page.
    /// </para>
    /// </summary>
    public partial interface IAmazonGameLift : IAmazonService, IDisposable
    {
                
        #region  CreateAlias


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateBuild


        /// <summary>
        /// Initiates the asynchronous execution of the CreateBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBuild operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateBuildResponse> CreateBuildAsync(CreateBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFleet


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGameSession


        /// <summary>
        /// Initiates the asynchronous execution of the CreateGameSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGameSession operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateGameSessionResponse> CreateGameSessionAsync(CreateGameSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePlayerSession


        /// <summary>
        /// Adds a player to a game session and creates a player session record. A game session
        /// must be in an <code>ACTIVE</code> state, have a creation policy of <code>ALLOW_ALL</code>,
        /// and have an open player slot before players can be added to the session.
        /// 
        ///  
        /// <para>
        /// To create a player session, specify a game session ID and player ID. If successful,
        /// the player is added to the game session and a new <a>PlayerSession</a> object is returned.
        /// 
        /// </para>
        /// </summary>
        /// <param name="gameSessionId">Unique identifier for a game session. Specify the game session you want to add a player to.</param>
        /// <param name="playerId">Unique identifier for the player to be added.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePlayerSession service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.GameSessionFullException">
        /// The game instance is currently full and cannot allow the requested player(s) to join.
        /// This exception occurs in response to a <a>CreatePlayerSession</a> request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Clients should not retry such
        /// requests without resolving the conflict.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Correct the invalid
        /// parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests
        /// </exception>
        Task<CreatePlayerSessionResponse> CreatePlayerSessionAsync(string gameSessionId, string playerId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlayerSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlayerSession operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreatePlayerSessionResponse> CreatePlayerSessionAsync(CreatePlayerSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePlayerSessions


        /// <summary>
        /// Adds a group of players to a game session. Similar to <a>CreatePlayerSession</a>,
        /// this action allows you to add multiple players in a single call, which is useful for
        /// games that provide party and/or matchmaking features. A game session must be in an
        /// <code>ACTIVE</code> state, have a creation policy of <code>ALLOW_ALL</code>, and have
        /// an open player slot before players can be added to the session.
        /// 
        ///  
        /// <para>
        /// To create player sessions, specify a game session ID and a list of player IDs. If
        /// successful, the players are added to the game session and a set of new <a>PlayerSession</a>
        /// objects is returned. 
        /// </para>
        /// </summary>
        /// <param name="gameSessionId">Unique identifier for a game session. </param>
        /// <param name="playerIds">List of unique identifiers for the players to be added.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePlayerSessions service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.GameSessionFullException">
        /// The game instance is currently full and cannot allow the requested player(s) to join.
        /// This exception occurs in response to a <a>CreatePlayerSession</a> request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Clients should not retry such
        /// requests without resolving the conflict.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Correct the invalid
        /// parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests
        /// </exception>
        Task<CreatePlayerSessionsResponse> CreatePlayerSessionsAsync(string gameSessionId, List<string> playerIds, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlayerSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlayerSessions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreatePlayerSessionsResponse> CreatePlayerSessionsAsync(CreatePlayerSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAlias


        /// <summary>
        /// Deletes an alias. This action removes all record of the alias; game clients attempting
        /// to access a server process using the deleted alias receive an error. To delete an
        /// alias, specify the alias ID to be deleted.
        /// </summary>
        /// <param name="aliasId">Unique identifier for a fleet alias. Specify the alias you want to delete. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Correct the invalid
        /// parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests
        /// </exception>
        Task<DeleteAliasResponse> DeleteAliasAsync(string aliasId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBuild


        /// <summary>
        /// Deletes a build. This action permanently deletes the build record and any uploaded
        /// build files.
        /// 
        ///  
        /// <para>
        /// To delete a build, specify its ID. Deleting a build does not affect the status of
        /// any active fleets using the build, but you can no longer create new fleets with the
        /// deleted build.
        /// </para>
        /// </summary>
        /// <param name="buildId">Unique identifier for the build you want to delete. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Correct the invalid
        /// parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests
        /// </exception>
        Task<DeleteBuildResponse> DeleteBuildAsync(string buildId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBuild operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteBuildResponse> DeleteBuildAsync(DeleteBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFleet


        /// <summary>
        /// Deletes everything related to a fleet. Before deleting a fleet, you must set the fleet's
        /// desired capacity to zero. See <a>UpdateFleetCapacity</a>.
        /// 
        ///  
        /// <para>
        /// This action removes the fleet's resources and the fleet record. Once a fleet is deleted,
        /// you can no longer use that fleet.
        /// </para>
        /// </summary>
        /// <param name="fleetId">Unique identifier for the fleet you want to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Correct the invalid
        /// parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests
        /// </exception>
        Task<DeleteFleetResponse> DeleteFleetAsync(string fleetId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteFleetResponse> DeleteFleetAsync(DeleteFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteScalingPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScalingPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteScalingPolicyResponse> DeleteScalingPolicyAsync(DeleteScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAlias


        /// <summary>
        /// Retrieves properties for a specified alias. To get the alias, specify an alias ID.
        /// If successful, an <a>Alias</a> object is returned.
        /// </summary>
        /// <param name="aliasId">Unique identifier for a fleet alias. Specify the alias you want to retrieve. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Correct the invalid
        /// parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests
        /// </exception>
        Task<DescribeAliasResponse> DescribeAliasAsync(string aliasId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAliasResponse> DescribeAliasAsync(DescribeAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBuild


        /// <summary>
        /// Retrieves properties for a build. To get a build record, specify a build ID. If successful,
        /// an object containing the build properties is returned.
        /// </summary>
        /// <param name="buildId">Unique identifier of the build that you want to retrieve properties for. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Correct the invalid
        /// parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests
        /// </exception>
        Task<DescribeBuildResponse> DescribeBuildAsync(string buildId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBuild operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeBuildResponse> DescribeBuildAsync(DescribeBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEC2InstanceLimits


        /// <summary>
        /// Retrieves the following information for the specified EC2 instance type:
        /// 
        ///  <ul> <li>maximum number of instances allowed per AWS account (service limit)</li>
        /// <li>current usage level for the AWS account </li> </ul> 
        /// <para>
        /// Service limits vary depending on region. Available regions for GameLift can be found
        /// in the AWS Management Console for GameLift (see the drop-down list in the upper right
        /// corner).
        /// </para>
        /// </summary>
        /// <param name="ec2InstanceType">Name of an EC2 instance type that is supported in Amazon GameLift. A fleet instance type determines the computing resources of each instance in the fleet, including CPU, memory, storage, and networking capacity. GameLift supports the following EC2 instance types. See <a href="https://aws.amazon.com/ec2/instance-types/">Amazon EC2 Instance Types</a> for detailed descriptions. Leave this parameter blank to retrieve limits for all types.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEC2InstanceLimits service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Correct the invalid
        /// parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests
        /// </exception>
        Task<DescribeEC2InstanceLimitsResponse> DescribeEC2InstanceLimitsAsync(EC2InstanceType ec2InstanceType, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEC2InstanceLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEC2InstanceLimits operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEC2InstanceLimitsResponse> DescribeEC2InstanceLimitsAsync(DescribeEC2InstanceLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFleetAttributes


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeFleetAttributesResponse> DescribeFleetAttributesAsync(DescribeFleetAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFleetCapacity


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetCapacity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeFleetCapacityResponse> DescribeFleetCapacityAsync(DescribeFleetCapacityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFleetEvents


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeFleetEventsResponse> DescribeFleetEventsAsync(DescribeFleetEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFleetPortSettings


        /// <summary>
        /// Retrieves the inbound connection permissions for a fleet. Connection permissions include
        /// a range of IP addresses and port settings that incoming traffic can use to access
        /// server processes in the fleet. To get a fleet's inbound connection permissions, specify
        /// a fleet ID. If successful, a collection of <a>IpPermission</a> objects is returned
        /// for the requested fleet ID. If the requested fleet has been deleted, the result set
        /// is empty.
        /// </summary>
        /// <param name="fleetId">Unique identifier for the fleet you want to retrieve port settings for. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleetPortSettings service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Correct the invalid
        /// parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests
        /// </exception>
        Task<DescribeFleetPortSettingsResponse> DescribeFleetPortSettingsAsync(string fleetId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetPortSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetPortSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeFleetPortSettingsResponse> DescribeFleetPortSettingsAsync(DescribeFleetPortSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFleetUtilization


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetUtilization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetUtilization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeFleetUtilizationResponse> DescribeFleetUtilizationAsync(DescribeFleetUtilizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeGameSessionDetails


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGameSessionDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessionDetails operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeGameSessionDetailsResponse> DescribeGameSessionDetailsAsync(DescribeGameSessionDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeGameSessions


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGameSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeGameSessionsResponse> DescribeGameSessionsAsync(DescribeGameSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePlayerSessions


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePlayerSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlayerSessions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribePlayerSessionsResponse> DescribePlayerSessionsAsync(DescribePlayerSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRuntimeConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRuntimeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuntimeConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeRuntimeConfigurationResponse> DescribeRuntimeConfigurationAsync(DescribeRuntimeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeScalingPolicies


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeScalingPoliciesResponse> DescribeScalingPoliciesAsync(DescribeScalingPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGameSessionLogUrl


        /// <summary>
        /// Retrieves the location of stored game session logs for a specified game session. When
        /// a game session is terminated, Amazon GameLift automatically stores the logs in Amazon
        /// S3. Use this URL to download the logs.
        /// 
        ///  <note> 
        /// <para>
        /// See the <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_gamelift">AWS
        /// Service Limits</a> page for maximum log file sizes. Log files that exceed this limit
        /// are not saved.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="gameSessionId">Unique identifier for a game session. Specify the game session you want to get logs for.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGameSessionLogUrl service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Correct the invalid
        /// parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests
        /// </exception>
        Task<GetGameSessionLogUrlResponse> GetGameSessionLogUrlAsync(string gameSessionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetGameSessionLogUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGameSessionLogUrl operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetGameSessionLogUrlResponse> GetGameSessionLogUrlAsync(GetGameSessionLogUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAliases


        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBuilds


        /// <summary>
        /// Initiates the asynchronous execution of the ListBuilds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuilds operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListBuildsResponse> ListBuildsAsync(ListBuildsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFleets


        /// <summary>
        /// Initiates the asynchronous execution of the ListFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListFleetsResponse> ListFleetsAsync(ListFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutScalingPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the PutScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RequestUploadCredentials


        /// <summary>
        /// Retrieves a fresh set of upload credentials and the assigned Amazon S3 storage location
        /// for a specific build. Valid credentials are required to upload your game build files
        /// to Amazon S3.
        /// 
        ///  <important> 
        /// <para>
        /// Call this action only if you need credentials for a build created with <code><a>CreateBuild</a></code>.
        /// This is a rare situation; in most cases, builds are created using the CLI command
        /// <code>upload-build</code>, which creates a build record and also uploads build files.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Upload credentials are returned when you create the build, but they have a limited
        /// lifespan. You can get fresh credentials and use them to re-upload game files until
        /// the state of that build changes to <code>READY</code>. Once this happens, you must
        /// create a brand new build.
        /// </para>
        /// </summary>
        /// <param name="buildId">Unique identifier for the build you want to get credentials for. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestUploadCredentials service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Correct the invalid
        /// parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests
        /// </exception>
        Task<RequestUploadCredentialsResponse> RequestUploadCredentialsAsync(string buildId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the RequestUploadCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestUploadCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RequestUploadCredentialsResponse> RequestUploadCredentialsAsync(RequestUploadCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResolveAlias


        /// <summary>
        /// Retrieves the fleet ID that a specified alias is currently pointing to.
        /// </summary>
        /// <param name="aliasId">Unique identifier for the alias you want to resolve. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResolveAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Correct the invalid
        /// parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests
        /// </exception>
        Task<ResolveAliasResponse> ResolveAliasAsync(string aliasId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the ResolveAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResolveAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ResolveAliasResponse> ResolveAliasAsync(ResolveAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAlias


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateBuild


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBuild operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateBuildResponse> UpdateBuildAsync(UpdateBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateFleetAttributes


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleetAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateFleetAttributesResponse> UpdateFleetAttributesAsync(UpdateFleetAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateFleetCapacity


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleetCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetCapacity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateFleetCapacityResponse> UpdateFleetCapacityAsync(UpdateFleetCapacityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateFleetPortSettings


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleetPortSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetPortSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateFleetPortSettingsResponse> UpdateFleetPortSettingsAsync(UpdateFleetPortSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGameSession


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGameSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameSession operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateGameSessionResponse> UpdateGameSessionAsync(UpdateGameSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRuntimeConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRuntimeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuntimeConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateRuntimeConfigurationResponse> UpdateRuntimeConfigurationAsync(UpdateRuntimeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}