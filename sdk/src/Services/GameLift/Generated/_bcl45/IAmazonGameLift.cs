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
    /// servers, and handles infrastructure scaling and session management. For more information
    /// about the GameLift service, including a feature overview, getting started guide, and
    /// tutorial, see the accompanying <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/">Amazon
    /// GameLift Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// This reference describes the low-level service API for GameLift. You can call this
    /// API directly or use the <a href="https://aws.amazon.com/tools/">AWS SDK</a> for your
    /// preferred language. The AWS SDK includes a set of high-level GameLift actions multiplayer
    /// game sessions. Alternatively, you can use the <a href="https://aws.amazon.com/cli/">AWS
    /// command-line interface</a> (CLI) tool, which includes commands for GameLift. For administrative
    /// actions, you can use the Amazon GameLift console. 
    /// </para>
    ///  
    /// <para>
    /// <b>Setting Up Your Game Servers</b>
    /// </para>
    ///  
    /// <para>
    /// Use these administrative actions to configure GameLift to host your game servers.
    /// When configuring GameLift, you'll need to (1) configure a build for your game and
    /// provide build files, and (2) set up one or more fleets to host game sessions.
    /// </para>
    ///  <ul> <li> <b>Build actions:</b> <ul> <li><a>ListBuilds</a></li> <li><a>CreateBuild</a></li>
    /// <li><a>DescribeBuild</a></li> <li><a>UpdateBuild</a></li> <li><a>DeleteBuild</a></li>
    /// <li><a>RequestUploadCredentials</a></li> </ul> </li> <li> <b>Fleet actions:</b> <ul>
    /// <li><a>ListFleets</a></li> <li><a>CreateFleet</a></li> <li>Describe fleet actions:
    /// <ul> <li><a>DescribeFleetAttributes</a></li> <li><a>DescribeFleetCapacity</a></li>
    /// <li><a>DescribeFleetPortSettings</a></li> <li><a>DescribeFleetUtilization</a></li>
    /// <li><a>DescribeEC2InstanceLimits</a></li> <li><a>DescribeFleetEvents</a></li> </ul>
    /// </li> <li>Update fleet actions: <ul> <li><a>UpdateFleetAttributes</a></li> <li><a>UpdateFleetCapacity</a></li>
    /// <li><a>UpdateFleetPortSettings</a></li> </ul> </li> <li><a>DeleteFleet</a></li> </ul>
    /// </li> <li> <b>Alias actions:</b> <ul> <li><a>ListAliases</a></li> <li><a>CreateAlias</a></li>
    /// <li><a>DescribeAlias</a></li> <li><a>UpdateAlias</a></li> <li><a>DeleteAlias</a></li>
    /// <li><a>ResolveAlias</a></li> </ul> </li> </ul> 
    /// <para>
    /// <b>Managing Game and Player Sessions Through GameLift</b>
    /// </para>
    ///  
    /// <para>
    /// Call these actions from your game clients and/or services to create and manage multiplayer
    /// game sessions.
    /// </para>
    ///  <ul> <li> <b>Game sessions</b> <ul> <li><a>CreateGameSession</a></li> <li><a>DescribeGameSessions</a></li>
    /// <li><a>UpdateGameSession</a></li> </ul> </li> <li> <b>Player sessions</b> <ul> <li><a>CreatePlayerSession</a></li>
    /// <li><a>CreatePlayerSessions</a></li> <li><a>DescribePlayerSessions</a></li> </ul>
    /// </li> <li> <b>Other actions:</b> <ul> <li><a>GetGameSessionLogUrl</a></li> </ul> </li>
    /// </ul>
    /// </summary>
    public partial interface IAmazonGameLift : IDisposable
    {

        
        #region  CreateAlias


        /// <summary>
        /// Creates an alias for a fleet. You can use an alias to anonymize your fleet by referencing
        /// an alias instead of a specific fleet when you create game sessions. Amazon GameLift
        /// supports two types of routing strategies for aliases: simple and terminal. Use a simple
        /// alias to point to an active fleet. Use a terminal alias to display a message to incoming
        /// traffic instead of routing players to an active fleet. This option is useful when
        /// a game server is no longer supported but you want to provide better messaging than
        /// a standard 404 error.
        /// 
        ///  
        /// <para>
        /// To create a fleet alias, specify an alias name, routing strategy, and optional description.
        /// If successful, a new alias record is returned, including an alias ID, which you can
        /// reference when creating a game session. To reassign the alias to another fleet ID,
        /// call <a>UpdateAlias</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Please resolve the conflict before retrying
        /// this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Please resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        CreateAliasResponse CreateAlias(CreateAliasRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateBuild


        /// <summary>
        /// Initializes a new build record and generates information required to upload a game
        /// build to Amazon GameLift. Once the build record has been created and is in an INITIALIZED
        /// state, you can upload your game build.
        /// 
        ///  <important>
        /// <para>
        /// To create a build, use the CLI command <code>upload-build</code>, which creates a
        /// new build record and uploads the build files in one step. (See the <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/">Amazon
        /// GameLift Developer Guide</a> for more details on the CLI and the upload process.)
        /// Call the <code>CreateBuild</code> action only if you have your own Amazon Simple Storage
        /// Service (Amazon S3) client and need to manually upload your build files.
        /// </para>
        /// </important> 
        /// <para>
        /// To create a new build, optionally specify a build name and version. This metadata
        /// is stored with other properties in the build record and is displayed in the GameLift
        /// console (but not visible to players). If successful, this action returns the newly
        /// created build record along with an Amazon S3 storage location and AWS account credentials.
        /// Use the location and credentials to upload your game build.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBuild service method.</param>
        /// 
        /// <returns>The response from the CreateBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Please resolve the conflict before retrying
        /// this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        CreateBuildResponse CreateBuild(CreateBuildRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBuild operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateBuildResponse> CreateBuildAsync(CreateBuildRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFleet


        /// <summary>
        /// Creates a new fleet to host game servers. A fleet consists of a set of Amazon Elastic
        /// Compute Cloud (Amazon EC2) instances of a certain type, which defines the CPU, memory,
        /// storage, and networking capacity of each host in the fleet. See <a href="https://aws.amazon.com/ec2/instance-types/">Amazon
        /// EC2 Instance Types</a> for more information. Each instance in the fleet hosts a game
        /// server created from the specified game build. Once a fleet is in an ACTIVE state,
        /// it can begin hosting game sessions.
        /// 
        ///  
        /// <para>
        /// To create a new fleet, provide a name and the EC2 instance type for the new fleet,
        /// and specify the build and server launch path. Builds must be in a READY state before
        /// they can be used to build fleets. When configuring the new fleet, you can optionally
        /// (1) provide a set of launch parameters to be passed to a game server when activated;
        /// (2) limit incoming traffic to a specified range of IP addresses and port numbers;
        /// and (3) configure Amazon GameLift to store game session logs by specifying the path
        /// to the logs stored in your game server files. If the call is successful, Amazon GameLift
        /// performs the following tasks:
        /// </para>
        ///  <ul> <li>Creates a fleet record and sets the state to NEW.</li> <li>Sets the fleet's
        /// capacity to 1 "desired" and 1 "active" EC2 instance count.</li> <li>Creates an EC2
        /// instance and begins the process of initializing the fleet and activating a game server
        /// on the instance.</li> <li>Begins writing events to the fleet event log, which can
        /// be accessed in the GameLift console.</li> </ul> 
        /// <para>
        /// Once a fleet is created, use the following actions to change certain fleet properties
        /// (server launch parameters and log paths cannot be changed):
        /// </para>
        ///  <ul> <li> <a>UpdateFleetAttributes</a> -- Update fleet metadata, including name and
        /// description.</li> <li> <a>UpdateFleetCapacity</a> -- Increase or decrease the number
        /// of instances you want the fleet to maintain.</li> <li> <a>UpdateFleetPortSettings</a>
        /// -- Change the IP addresses and ports that allow access to incoming traffic.</li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Please resolve the conflict before retrying
        /// this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Please resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        CreateFleetResponse CreateFleet(CreateFleetRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateGameSession


        /// <summary>
        /// Creates a multiplayer game session for players. This action creates a game session
        /// record and assigns the new session to an instance in the specified fleet, which activates
        /// the server initialization process in your game server. A fleet must be in an ACTIVE
        /// state before a game session can be created for it.
        /// 
        ///  
        /// <para>
        /// To create a game session, specify either a fleet ID or an alias ID and indicate the
        /// maximum number of players the game session allows. You can also provide a name and
        /// a set of properties for your game (optional). If successful, a <a>GameSession</a>
        /// object is returned containing session properties, including an IP address. By default,
        /// newly created game sessions are set to accept adding any new players to the game session.
        /// Use <a>UpdateGameSession</a> to change the creation policy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGameSession service method.</param>
        /// 
        /// <returns>The response from the CreateGameSession service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Please resolve the conflict before retrying
        /// this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.FleetCapacityExceededException">
        /// The specified fleet has no available instances to fulfill a request to create a new
        /// game session. Such requests should only be retried once the fleet capacity has been
        /// increased.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Please resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        CreateGameSessionResponse CreateGameSession(CreateGameSessionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateGameSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGameSession operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateGameSessionResponse> CreateGameSessionAsync(CreateGameSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePlayerSession


        /// <summary>
        /// Adds a player to a game session and creates a player session record. A game session
        /// must be in an ACTIVE state, have a creation policy of ALLOW_ALL, and have an open
        /// player slot before players can be added to the session.
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
        /// 
        /// <returns>The response from the CreatePlayerSession service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.GameSessionFullException">
        /// The game instance is currently full and cannot allow the requested player(s) to join.
        /// This exception occurs in response to a <a>CreatePlayerSession</a> request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Such requests should not be
        /// retried by clients without resolving the conflict.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        CreatePlayerSessionResponse CreatePlayerSession(string gameSessionId, string playerId);

        /// <summary>
        /// Adds a player to a game session and creates a player session record. A game session
        /// must be in an ACTIVE state, have a creation policy of ALLOW_ALL, and have an open
        /// player slot before players can be added to the session.
        /// 
        ///  
        /// <para>
        /// To create a player session, specify a game session ID and player ID. If successful,
        /// the player is added to the game session and a new <a>PlayerSession</a> object is returned.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlayerSession service method.</param>
        /// 
        /// <returns>The response from the CreatePlayerSession service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.GameSessionFullException">
        /// The game instance is currently full and cannot allow the requested player(s) to join.
        /// This exception occurs in response to a <a>CreatePlayerSession</a> request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Such requests should not be
        /// retried by clients without resolving the conflict.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        CreatePlayerSessionResponse CreatePlayerSession(CreatePlayerSessionRequest request);


        /// <summary>
        /// Adds a player to a game session and creates a player session record. A game session
        /// must be in an ACTIVE state, have a creation policy of ALLOW_ALL, and have an open
        /// player slot before players can be added to the session.
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
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Such requests should not be
        /// retried by clients without resolving the conflict.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
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
        Task<CreatePlayerSessionResponse> CreatePlayerSessionAsync(CreatePlayerSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePlayerSessions


        /// <summary>
        /// Adds a group of players to a game session. Similar to <a>CreatePlayerSession</a>,
        /// this action allows you to add multiple players in a single call, which is useful for
        /// games that provide party and/or matchmaking features. A game session must be in an
        /// ACTIVE state, have a creation policy of ALLOW_ALL, and have an open player slot before
        /// players can be added to the session.
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
        /// 
        /// <returns>The response from the CreatePlayerSessions service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.GameSessionFullException">
        /// The game instance is currently full and cannot allow the requested player(s) to join.
        /// This exception occurs in response to a <a>CreatePlayerSession</a> request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Such requests should not be
        /// retried by clients without resolving the conflict.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        CreatePlayerSessionsResponse CreatePlayerSessions(string gameSessionId, List<string> playerIds);

        /// <summary>
        /// Adds a group of players to a game session. Similar to <a>CreatePlayerSession</a>,
        /// this action allows you to add multiple players in a single call, which is useful for
        /// games that provide party and/or matchmaking features. A game session must be in an
        /// ACTIVE state, have a creation policy of ALLOW_ALL, and have an open player slot before
        /// players can be added to the session.
        /// 
        ///  
        /// <para>
        /// To create player sessions, specify a game session ID and a list of player IDs. If
        /// successful, the players are added to the game session and a set of new <a>PlayerSession</a>
        /// objects is returned. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlayerSessions service method.</param>
        /// 
        /// <returns>The response from the CreatePlayerSessions service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.GameSessionFullException">
        /// The game instance is currently full and cannot allow the requested player(s) to join.
        /// This exception occurs in response to a <a>CreatePlayerSession</a> request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Such requests should not be
        /// retried by clients without resolving the conflict.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        CreatePlayerSessionsResponse CreatePlayerSessions(CreatePlayerSessionsRequest request);


        /// <summary>
        /// Adds a group of players to a game session. Similar to <a>CreatePlayerSession</a>,
        /// this action allows you to add multiple players in a single call, which is useful for
        /// games that provide party and/or matchmaking features. A game session must be in an
        /// ACTIVE state, have a creation policy of ALLOW_ALL, and have an open player slot before
        /// players can be added to the session.
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
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Such requests should not be
        /// retried by clients without resolving the conflict.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
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
        Task<CreatePlayerSessionsResponse> CreatePlayerSessionsAsync(CreatePlayerSessionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAlias


        /// <summary>
        /// Deletes an alias. This action removes all record of the alias; game clients attempting
        /// to access a game server using the deleted alias receive an error. To delete an alias,
        /// specify the alias ID to be deleted.
        /// </summary>
        /// <param name="aliasId">Unique identifier for a fleet alias. Specify the alias you want to delete. </param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        DeleteAliasResponse DeleteAlias(string aliasId);

        /// <summary>
        /// Deletes an alias. This action removes all record of the alias; game clients attempting
        /// to access a game server using the deleted alias receive an error. To delete an alias,
        /// specify the alias ID to be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        DeleteAliasResponse DeleteAlias(DeleteAliasRequest request);


        /// <summary>
        /// Deletes an alias. This action removes all record of the alias; game clients attempting
        /// to access a game server using the deleted alias receive an error. To delete an alias,
        /// specify the alias ID to be deleted.
        /// </summary>
        /// <param name="aliasId">Unique identifier for a fleet alias. Specify the alias you want to delete. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
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
        Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBuild


        /// <summary>
        /// Deletes a build. This action permanently deletes the build record and any uploaded
        /// build files.
        /// 
        ///  
        /// <para>
        /// To delete a build, specify its ID. Deleting a build does not affect the status of
        /// any active fleets, but you can no longer create new fleets for the deleted build.
        /// </para>
        /// </summary>
        /// <param name="buildId">Unique identifier for the build you want to delete. </param>
        /// 
        /// <returns>The response from the DeleteBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        DeleteBuildResponse DeleteBuild(string buildId);

        /// <summary>
        /// Deletes a build. This action permanently deletes the build record and any uploaded
        /// build files.
        /// 
        ///  
        /// <para>
        /// To delete a build, specify its ID. Deleting a build does not affect the status of
        /// any active fleets, but you can no longer create new fleets for the deleted build.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBuild service method.</param>
        /// 
        /// <returns>The response from the DeleteBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        DeleteBuildResponse DeleteBuild(DeleteBuildRequest request);


        /// <summary>
        /// Deletes a build. This action permanently deletes the build record and any uploaded
        /// build files.
        /// 
        ///  
        /// <para>
        /// To delete a build, specify its ID. Deleting a build does not affect the status of
        /// any active fleets, but you can no longer create new fleets for the deleted build.
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
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
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
        Task<DeleteBuildResponse> DeleteBuildAsync(DeleteBuildRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Please resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Please resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        DeleteFleetResponse DeleteFleet(string fleetId);

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
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Please resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Please resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        DeleteFleetResponse DeleteFleet(DeleteFleetRequest request);


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
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Please resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Please resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
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
        Task<DeleteFleetResponse> DeleteFleetAsync(DeleteFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAlias


        /// <summary>
        /// Retrieves properties for a specified alias. To get the alias, specify an alias ID.
        /// If successful, an <a>Alias</a> object is returned.
        /// </summary>
        /// <param name="aliasId">Unique identifier for a fleet alias. Specify the alias you want to retrieve. </param>
        /// 
        /// <returns>The response from the DescribeAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        DescribeAliasResponse DescribeAlias(string aliasId);

        /// <summary>
        /// Retrieves properties for a specified alias. To get the alias, specify an alias ID.
        /// If successful, an <a>Alias</a> object is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlias service method.</param>
        /// 
        /// <returns>The response from the DescribeAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        DescribeAliasResponse DescribeAlias(DescribeAliasRequest request);


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
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
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
        Task<DescribeAliasResponse> DescribeAliasAsync(DescribeAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeBuild


        /// <summary>
        /// Retrieves properties for a build. To get a build record, specify a build ID. If successful,
        /// an object containing the build properties is returned.
        /// </summary>
        /// <param name="buildId">Unique identifier for the build you want to retrieve properties for. </param>
        /// 
        /// <returns>The response from the DescribeBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        DescribeBuildResponse DescribeBuild(string buildId);

        /// <summary>
        /// Retrieves properties for a build. To get a build record, specify a build ID. If successful,
        /// an object containing the build properties is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBuild service method.</param>
        /// 
        /// <returns>The response from the DescribeBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        DescribeBuildResponse DescribeBuild(DescribeBuildRequest request);


        /// <summary>
        /// Retrieves properties for a build. To get a build record, specify a build ID. If successful,
        /// an object containing the build properties is returned.
        /// </summary>
        /// <param name="buildId">Unique identifier for the build you want to retrieve properties for. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
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
        Task<DescribeBuildResponse> DescribeBuildAsync(DescribeBuildRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEC2InstanceLimits


        /// <summary>
        /// Retrieves the maximum number of instances allowed, per AWS account, for each specified
        /// EC2 instance type. The current usage level for the AWS account is also retrieved.
        /// </summary>
        /// <param name="ec2InstanceType">Type of EC2 instances used in the fleet. EC2 instance types define the CPU, memory, storage, and networking capacity of the fleetaposs hosts. Amazon GameLift supports the EC2 instance types listed below. See <a href="https://aws.amazon.com/ec2/instance-types/">Amazon EC2 Instance Types</a> for detailed descriptions of each. Leave this parameter blank to retrieve limits for all types.</param>
        /// 
        /// <returns>The response from the DescribeEC2InstanceLimits service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        DescribeEC2InstanceLimitsResponse DescribeEC2InstanceLimits(EC2InstanceType ec2InstanceType);

        /// <summary>
        /// Retrieves the maximum number of instances allowed, per AWS account, for each specified
        /// EC2 instance type. The current usage level for the AWS account is also retrieved.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEC2InstanceLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeEC2InstanceLimits service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        DescribeEC2InstanceLimitsResponse DescribeEC2InstanceLimits(DescribeEC2InstanceLimitsRequest request);


        /// <summary>
        /// Retrieves the maximum number of instances allowed, per AWS account, for each specified
        /// EC2 instance type. The current usage level for the AWS account is also retrieved.
        /// </summary>
        /// <param name="ec2InstanceType">Type of EC2 instances used in the fleet. EC2 instance types define the CPU, memory, storage, and networking capacity of the fleetaposs hosts. Amazon GameLift supports the EC2 instance types listed below. See <a href="https://aws.amazon.com/ec2/instance-types/">Amazon EC2 Instance Types</a> for detailed descriptions of each. Leave this parameter blank to retrieve limits for all types.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEC2InstanceLimits service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
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
        Task<DescribeEC2InstanceLimitsResponse> DescribeEC2InstanceLimitsAsync(DescribeEC2InstanceLimitsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFleetAttributes


        /// <summary>
        /// Retrieves fleet properties, including metadata, status, and configuration, for one
        /// or more fleets. You can request attributes for all fleets, or specify a list of one
        /// or more fleet IDs. When requesting all fleets, use the pagination parameters to retrieve
        /// results as a set of sequential pages. If successful, a <a>FleetAttributes</a> object
        /// is returned for each requested fleet ID. When specifying a list of fleet IDs, attribute
        /// objects are returned only for fleets that currently exist. 
        /// 
        ///  <note>
        /// <para>
        /// Some API actions may limit the number of fleet IDs allowed in one request. If a request
        /// exceeds this limit, the request fails and the error message includes the maximum allowed.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetAttributes service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        DescribeFleetAttributesResponse DescribeFleetAttributes(DescribeFleetAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeFleetAttributesResponse> DescribeFleetAttributesAsync(DescribeFleetAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFleetCapacity


        /// <summary>
        /// Retrieves the current status of fleet capacity for one or more fleets. This information
        /// includes the number of instances that have been requested for the fleet and the number
        /// currently active. You can request capacity for all fleets, or specify a list of one
        /// or more fleet IDs. When requesting all fleets, use the pagination parameters to retrieve
        /// results as a set of sequential pages. If successful, a <a>FleetCapacity</a> object
        /// is returned for each requested fleet ID. When specifying a list of fleet IDs, attribute
        /// objects are returned only for fleets that currently exist. 
        /// 
        ///  <note>
        /// <para>
        /// Some API actions may limit the number of fleet IDs allowed in one request. If a request
        /// exceeds this limit, the request fails and the error message includes the maximum allowed.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetCapacity service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetCapacity service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        DescribeFleetCapacityResponse DescribeFleetCapacity(DescribeFleetCapacityRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetCapacity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeFleetCapacityResponse> DescribeFleetCapacityAsync(DescribeFleetCapacityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFleetEvents


        /// <summary>
        /// Retrieves entries from the fleet event log. You can specify a time range to limit
        /// the result set. Use the pagination parameters to retrieve results as a set of sequential
        /// pages. If successful, a collection of event log entries matching the request are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetEvents service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        DescribeFleetEventsResponse DescribeFleetEvents(DescribeFleetEventsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeFleetEventsResponse> DescribeFleetEventsAsync(DescribeFleetEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFleetPortSettings


        /// <summary>
        /// Retrieves the port settings for a fleet. Port settings are used to limit incoming
        /// traffic access to game servers in the fleet. To get a fleet's port settings, specify
        /// a fleet ID. If successful, an <a>IpPermission</a> object is returned for the requested
        /// fleet ID. If the requested fleet has been deleted, the result set will be empty.
        /// </summary>
        /// <param name="fleetId">Unique identifier for the fleet you want to retrieve port settings for. </param>
        /// 
        /// <returns>The response from the DescribeFleetPortSettings service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        DescribeFleetPortSettingsResponse DescribeFleetPortSettings(string fleetId);

        /// <summary>
        /// Retrieves the port settings for a fleet. Port settings are used to limit incoming
        /// traffic access to game servers in the fleet. To get a fleet's port settings, specify
        /// a fleet ID. If successful, an <a>IpPermission</a> object is returned for the requested
        /// fleet ID. If the requested fleet has been deleted, the result set will be empty.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetPortSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetPortSettings service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        DescribeFleetPortSettingsResponse DescribeFleetPortSettings(DescribeFleetPortSettingsRequest request);


        /// <summary>
        /// Retrieves the port settings for a fleet. Port settings are used to limit incoming
        /// traffic access to game servers in the fleet. To get a fleet's port settings, specify
        /// a fleet ID. If successful, an <a>IpPermission</a> object is returned for the requested
        /// fleet ID. If the requested fleet has been deleted, the result set will be empty.
        /// </summary>
        /// <param name="fleetId">Unique identifier for the fleet you want to retrieve port settings for. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleetPortSettings service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
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
        Task<DescribeFleetPortSettingsResponse> DescribeFleetPortSettingsAsync(DescribeFleetPortSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFleetUtilization


        /// <summary>
        /// Retrieves utilization statistics for one or more fleets. You can request utilization
        /// data for all fleets, or specify a list of one or more fleet IDs. When requesting all
        /// fleets, use the pagination parameters to retrieve results as a set of sequential pages.
        /// If successful, a <a>FleetUtilization</a> object is returned for each requested fleet
        /// ID. When specifying a list of fleet IDs, utilization objects are returned only for
        /// fleets that currently exist. 
        /// 
        ///  <note>
        /// <para>
        /// Some API actions may limit the number of fleet IDs allowed in one request. If a request
        /// exceeds this limit, the request fails and the error message includes the maximum allowed.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetUtilization service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetUtilization service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        DescribeFleetUtilizationResponse DescribeFleetUtilization(DescribeFleetUtilizationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetUtilization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetUtilization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeFleetUtilizationResponse> DescribeFleetUtilizationAsync(DescribeFleetUtilizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeGameSessions


        /// <summary>
        /// Retrieves properties for one or more game sessions. This action can be used in several
        /// ways: (1) provide a <i>GameSessionId</i> parameter to request properties for a specific
        /// game session; (2) provide a <i>FleetId</i> or <i>AliasId</i> parameter to request
        /// properties for all game sessions running on a fleet. 
        /// 
        ///  
        /// <para>
        /// To get game session record(s), specify only one of the following: game session ID,
        /// fleet ID, or alias ID. You can filter this request by game session status. Use the
        /// pagination parameters to retrieve results as a set of sequential pages. If successful,
        /// a <a>GameSession</a> object is returned for each session matching the request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessions service method.</param>
        /// 
        /// <returns>The response from the DescribeGameSessions service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        DescribeGameSessionsResponse DescribeGameSessions(DescribeGameSessionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGameSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeGameSessionsResponse> DescribeGameSessionsAsync(DescribeGameSessionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePlayerSessions


        /// <summary>
        /// Retrieves properties for one or more player sessions. This action can be used in several
        /// ways: (1) provide a <i>PlayerSessionId</i> parameter to request properties for a specific
        /// player session; (2) provide a <i>GameSessionId</i> parameter to request properties
        /// for all player sessions in the specified game session; (3) provide a <i>PlayerId</i>
        /// parameter to request properties for all player sessions of a specified player. 
        /// 
        ///  
        /// <para>
        /// To get game session record(s), specify only one of the following: a player session
        /// ID, a game session ID, or a player ID. You can filter this request by player session
        /// status. Use the pagination parameters to retrieve results as a set of sequential pages.
        /// If successful, a <a>PlayerSession</a> object is returned for each session matching
        /// the request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePlayerSessions service method.</param>
        /// 
        /// <returns>The response from the DescribePlayerSessions service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        DescribePlayerSessionsResponse DescribePlayerSessions(DescribePlayerSessionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePlayerSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlayerSessions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribePlayerSessionsResponse> DescribePlayerSessionsAsync(DescribePlayerSessionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// </note>
        /// </summary>
        /// <param name="gameSessionId">Unique identifier for a game session. Specify the game session you want to get logs for.</param>
        /// 
        /// <returns>The response from the GetGameSessionLogUrl service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        GetGameSessionLogUrlResponse GetGameSessionLogUrl(string gameSessionId);

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
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGameSessionLogUrl service method.</param>
        /// 
        /// <returns>The response from the GetGameSessionLogUrl service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        GetGameSessionLogUrlResponse GetGameSessionLogUrl(GetGameSessionLogUrlRequest request);


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
        /// </note>
        /// </summary>
        /// <param name="gameSessionId">Unique identifier for a game session. Specify the game session you want to get logs for.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGameSessionLogUrl service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
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
        Task<GetGameSessionLogUrlResponse> GetGameSessionLogUrlAsync(GetGameSessionLogUrlRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAliases


        /// <summary>
        /// Retrieves a collection of alias records for this AWS account. You can filter the result
        /// set by alias name and/or routing strategy type. Use the pagination parameters to retrieve
        /// results in sequential pages. 
        /// 
        ///  <note>
        /// <para>
        /// Aliases are not listed in any particular order.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        ListAliasesResponse ListAliases(ListAliasesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListBuilds


        /// <summary>
        /// Retrieves build records for all builds associated with an AWS account. You can filter
        /// the result set by build status. Use the pagination parameters to retrieve results
        /// in a set of sequential pages. 
        /// 
        ///  <note>
        /// <para>
        /// Build records are not listed in any particular order.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuilds service method.</param>
        /// 
        /// <returns>The response from the ListBuilds service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        ListBuildsResponse ListBuilds(ListBuildsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListBuilds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuilds operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListBuildsResponse> ListBuildsAsync(ListBuildsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFleets


        /// <summary>
        /// Retrieves a collection of fleet records for this AWS account. You can filter the result
        /// set by build ID. Use the pagination parameters to retrieve results in sequential pages.
        /// 
        /// 
        ///  <note>
        /// <para>
        /// Fleet records are not listed in any particular order.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleets service method.</param>
        /// 
        /// <returns>The response from the ListFleets service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        ListFleetsResponse ListFleets(ListFleetsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListFleetsResponse> ListFleetsAsync(ListFleetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RequestUploadCredentials


        /// <summary>
        /// Retrieves a fresh set of upload credentials and the assigned Amazon S3 storage location
        /// for a specific build. Valid credentials are required to upload your game build files
        /// to Amazon S3.
        /// 
        ///  <important>
        /// <para>
        /// Call this action only if you need credentials for a build created with <a>CreateBuild</a>.
        /// This is a rare situation; in most cases, builds are created using the CLI command
        /// <code>upload-build</code>, which creates a build record and also uploads build files.
        /// 
        /// </para>
        /// </important> 
        /// <para>
        /// Upload credentials are returned when you create the build, but they have a limited
        /// lifespan. You can get fresh credentials and use them to re-upload game files until
        /// the state of that build changes to READY. Once this happens, you must create a brand
        /// new build.
        /// </para>
        /// </summary>
        /// <param name="buildId">Unique identifier for the build you want to get credentials for. </param>
        /// 
        /// <returns>The response from the RequestUploadCredentials service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        RequestUploadCredentialsResponse RequestUploadCredentials(string buildId);

        /// <summary>
        /// Retrieves a fresh set of upload credentials and the assigned Amazon S3 storage location
        /// for a specific build. Valid credentials are required to upload your game build files
        /// to Amazon S3.
        /// 
        ///  <important>
        /// <para>
        /// Call this action only if you need credentials for a build created with <a>CreateBuild</a>.
        /// This is a rare situation; in most cases, builds are created using the CLI command
        /// <code>upload-build</code>, which creates a build record and also uploads build files.
        /// 
        /// </para>
        /// </important> 
        /// <para>
        /// Upload credentials are returned when you create the build, but they have a limited
        /// lifespan. You can get fresh credentials and use them to re-upload game files until
        /// the state of that build changes to READY. Once this happens, you must create a brand
        /// new build.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestUploadCredentials service method.</param>
        /// 
        /// <returns>The response from the RequestUploadCredentials service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        RequestUploadCredentialsResponse RequestUploadCredentials(RequestUploadCredentialsRequest request);


        /// <summary>
        /// Retrieves a fresh set of upload credentials and the assigned Amazon S3 storage location
        /// for a specific build. Valid credentials are required to upload your game build files
        /// to Amazon S3.
        /// 
        ///  <important>
        /// <para>
        /// Call this action only if you need credentials for a build created with <a>CreateBuild</a>.
        /// This is a rare situation; in most cases, builds are created using the CLI command
        /// <code>upload-build</code>, which creates a build record and also uploads build files.
        /// 
        /// </para>
        /// </important> 
        /// <para>
        /// Upload credentials are returned when you create the build, but they have a limited
        /// lifespan. You can get fresh credentials and use them to re-upload game files until
        /// the state of that build changes to READY. Once this happens, you must create a brand
        /// new build.
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
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
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
        Task<RequestUploadCredentialsResponse> RequestUploadCredentialsAsync(RequestUploadCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResolveAlias


        /// <summary>
        /// Retrieves the fleet ID that a specified alias is currently pointing to.
        /// </summary>
        /// <param name="aliasId">Unique identifier for the alias you want to resolve. </param>
        /// 
        /// <returns>The response from the ResolveAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        ResolveAliasResponse ResolveAlias(string aliasId);

        /// <summary>
        /// Retrieves the fleet ID that a specified alias is currently pointing to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResolveAlias service method.</param>
        /// 
        /// <returns>The response from the ResolveAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        ResolveAliasResponse ResolveAlias(ResolveAliasRequest request);


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
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the TerminalRoutingStrategy itself. Such requests
        /// should only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
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
        Task<ResolveAliasResponse> ResolveAliasAsync(ResolveAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAlias


        /// <summary>
        /// Updates properties for an alias. To update properties, specify the alias ID to be
        /// updated and provide the information to be changed. To reassign an alias to another
        /// fleet, provide an updated routing strategy. If successful, the updated alias record
        /// is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        UpdateAliasResponse UpdateAlias(UpdateAliasRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateBuild


        /// <summary>
        /// Updates metadata in a build record, including the build name and version. To update
        /// the metadata, specify the build ID to update and provide the new values. If successful,
        /// a build object containing the updated metadata is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBuild service method.</param>
        /// 
        /// <returns>The response from the UpdateBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        UpdateBuildResponse UpdateBuild(UpdateBuildRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBuild operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateBuildResponse> UpdateBuildAsync(UpdateBuildRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFleetAttributes


        /// <summary>
        /// Updates fleet properties, including name and description, for a fleet. To update metadata,
        /// specify the fleet ID and the property values you want to change. If successful, the
        /// fleet ID for the updated fleet is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetAttributes service method.</param>
        /// 
        /// <returns>The response from the UpdateFleetAttributes service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Please resolve the conflict before retrying
        /// this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Please resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Please resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        UpdateFleetAttributesResponse UpdateFleetAttributes(UpdateFleetAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleetAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateFleetAttributesResponse> UpdateFleetAttributesAsync(UpdateFleetAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFleetCapacity


        /// <summary>
        /// Updates capacity settings for a fleet. Use this action to specify the number of EC2
        /// instances (hosts) you want this fleet to contain. Before calling this action, you
        /// may want to call <a>DescribeEC2InstanceLimits</a> to get the maximum capacity based
        /// on the fleet's EC2 instance type.
        /// 
        ///  
        /// <para>
        /// To update fleet capacity, specify the fleet ID and the desired number of instances.
        /// If successful, Amazon GameLift starts or terminates instances so that the fleet's
        /// active instance count matches the desired instance count. You can view a fleet's current
        /// capacity information by calling <a>DescribeFleetCapacity</a>. If the desired instance
        /// count is higher than the instance type's limit, the "Limit Exceeded" exception will
        /// occur.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetCapacity service method.</param>
        /// 
        /// <returns>The response from the UpdateFleetCapacity service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Please resolve the conflict before retrying
        /// this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Please resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Please resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        UpdateFleetCapacityResponse UpdateFleetCapacity(UpdateFleetCapacityRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleetCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetCapacity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateFleetCapacityResponse> UpdateFleetCapacityAsync(UpdateFleetCapacityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFleetPortSettings


        /// <summary>
        /// Updates port settings for a fleet. To update settings, specify the fleet ID to be
        /// updated and list the permissions you want to update. List the permissions you want
        /// to add in <i>InboundPermissionAuthorizations</i>, and permissions you want to remove
        /// in <i>InboundPermissionRevocations</i>. Permissions to be removed must match existing
        /// fleet permissions. If successful, the fleet ID for the updated fleet is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetPortSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateFleetPortSettings service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Please resolve the conflict before retrying
        /// this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Please resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Please resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        UpdateFleetPortSettingsResponse UpdateFleetPortSettings(UpdateFleetPortSettingsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleetPortSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetPortSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateFleetPortSettingsResponse> UpdateFleetPortSettingsAsync(UpdateFleetPortSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateGameSession


        /// <summary>
        /// Updates game session properties. This includes the session name, maximum player count
        /// and the player session creation policy, which either allows or denies new players
        /// from joining the session. To update a game session, specify the game session ID and
        /// the values you want to change. If successful, an updated <a>GameSession</a> object
        /// is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameSession service method.</param>
        /// 
        /// <returns>The response from the UpdateGameSession service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Please resolve the conflict before retrying
        /// this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Such requests can be retried by clients, either immediately or after a back-off period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Such requests should not be
        /// retried by clients without resolving the conflict.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameters specified as part of the request are invalid. Please correct
        /// the invalid parameters before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Such requests should
        /// not be retried by clients.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Such requests should not be retried without valid
        /// authentication credentials.
        /// </exception>
        UpdateGameSessionResponse UpdateGameSession(UpdateGameSessionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGameSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameSession operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateGameSessionResponse> UpdateGameSessionAsync(UpdateGameSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}