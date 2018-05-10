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
    ///  Amazon GameLift is a managed service for developers who need a scalable, dedicated
    /// server solution for their multiplayer games. Use Amazon GameLift for these tasks:
    /// (1) set up computing resources and deploy your game servers, (2) run game sessions
    /// and get players into games, (3) automatically scale your resources to meet player
    /// demand and manage costs, and (4) track in-depth metrics on game server performance
    /// and player usage.
    /// </para>
    ///  
    /// <para>
    /// The Amazon GameLift service API includes two important function sets:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Manage game sessions and player access</b> -- Retrieve information on available
    /// game sessions; create new game sessions; send player requests to join a game session.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Configure and manage game server resources</b> -- Manage builds, fleets, queues,
    /// and aliases; set auto-scaling policies; retrieve logs and metrics.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This reference guide describes the low-level service API for Amazon GameLift. You
    /// can use the API functionality with these tools: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The Amazon Web Services software development kit (<a href="http://aws.amazon.com/tools/#sdk">AWS
    /// SDK</a>) is available in <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-supported.html#gamelift-supported-clients">multiple
    /// languages</a> including C++ and C#. Use the SDK to access the API programmatically
    /// from an application, such as a game client.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <a href="http://aws.amazon.com/cli/">AWS command-line interface</a> (CLI) tool
    /// is primarily useful for handling administrative actions, such as setting up and managing
    /// Amazon GameLift settings and resources. You can use the AWS CLI to manage all of your
    /// AWS services.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <a href="https://console.aws.amazon.com/gamelift/home">AWS Management Console</a>
    /// for Amazon GameLift provides a web interface to manage your Amazon GameLift settings
    /// and resources. The console includes a dashboard for tracking key resources, including
    /// builds and fleets, and displays usage and performance metrics for your games as customizable
    /// graphs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon GameLift Local is a tool for testing your game's integration with Amazon GameLift
    /// before deploying it on the service. This tools supports a subset of key API actions,
    /// which can be called from either the AWS CLI or programmatically. See <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/integration-testing-local.html">Testing
    /// an Integration</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/"> Developer Guide</a>
    /// -- Read about Amazon GameLift features and how to use them. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://gamedev.amazon.com/forums/tutorials">Tutorials</a> -- Get started
    /// fast with walkthroughs and sample projects.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/blogs/gamedev/">GameDev Blog</a> -- Stay up to date
    /// with new features and techniques.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://gamedev.amazon.com/forums/spaces/123/gamelift-discussion.html">GameDev
    /// Forums</a> -- Connect with the GameDev community.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/releasenotes/Amazon-GameLift/">Release notes</a> and
    /// <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/doc-history.html">document
    /// history</a> -- Stay current with updates to the Amazon GameLift service, SDKs, and
    /// documentation. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>API SUMMARY</b> 
    /// </para>
    ///  
    /// <para>
    /// This list offers a functional overview of the Amazon GameLift service API.
    /// </para>
    ///  
    /// <para>
    ///  <b>Managing Games and Players</b> 
    /// </para>
    ///  
    /// <para>
    /// Use these actions to start new game sessions, find existing game sessions, track game
    /// session status and other information, and enable player access to game sessions.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Discover existing game sessions</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>SearchGameSessions</a> -- Retrieve all available game sessions or search for game
    /// sessions that match a set of criteria. 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Start new game sessions</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Start new games with Queues to find the best available hosting resources across multiple
    /// regions, minimize player latency, and balance game session activity for efficiency
    /// and cost effectiveness. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>StartGameSessionPlacement</a> -- Request a new game session placement and add
    /// one or more players to it.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeGameSessionPlacement</a> -- Get details on a placement request, including
    /// status.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StopGameSessionPlacement</a> -- Cancel a placement request. 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <a>CreateGameSession</a> -- Start a new game session on a specific fleet. <i>Available
    /// in Amazon GameLift Local.</i> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Match players to game sessions with FlexMatch matchmaking</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>StartMatchmaking</a> -- Request matchmaking for one players or a group who want
    /// to play together. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StartMatchBackfill</a> - Request additional player matches to fill empty slots
    /// in an existing game session. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeMatchmaking</a> -- Get details on a matchmaking request, including status.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>AcceptMatch</a> -- Register that a player accepts a proposed match, for matches
    /// that require player acceptance. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StopMatchmaking</a> -- Cancel a matchmaking request. 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Manage game session data</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeGameSessions</a> -- Retrieve metadata for one or more game sessions, including
    /// length of time active and current player count. <i>Available in Amazon GameLift Local.</i>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeGameSessionDetails</a> -- Retrieve metadata and the game session protection
    /// setting for one or more game sessions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateGameSession</a> -- Change game session settings, such as maximum player
    /// count and join policy.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetGameSessionLogUrl</a> -- Get the location of saved logs for a game session.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Manage player sessions</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreatePlayerSession</a> -- Send a request for a player to join a game session.
    /// <i>Available in Amazon GameLift Local.</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreatePlayerSessions</a> -- Send a request for multiple players to join a game
    /// session. <i>Available in Amazon GameLift Local.</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribePlayerSessions</a> -- Get details on player activity, including status,
    /// playing time, and player data. <i>Available in Amazon GameLift Local.</i> 
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    ///  <b>Setting Up and Managing Game Servers</b> 
    /// </para>
    ///  
    /// <para>
    /// When setting up Amazon GameLift resources for your game, you first <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">create
    /// a game build</a> and upload it to Amazon GameLift. You can then use these actions
    /// to configure and manage a fleet of resources to run your game servers, scale capacity
    /// to meet player demand, access performance and utilization metrics, and more.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Manage game builds</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateBuild</a> -- Create a new build using files stored in an Amazon S3 bucket.
    /// To create a build and upload files from a local path, use the AWS CLI command <code>upload-build</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListBuilds</a> -- Get a list of all builds uploaded to a Amazon GameLift region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeBuild</a> -- Retrieve information associated with a build.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateBuild</a> -- Change build metadata, including build name and version.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteBuild</a> -- Remove a build from Amazon GameLift.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Manage fleets</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateFleet</a> -- Configure and activate a new fleet to run a build's game servers.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListFleets</a> -- Get a list of all fleet IDs in a Amazon GameLift region (all
    /// statuses).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteFleet</a> -- Terminate a fleet that is no longer running game servers or
    /// hosting players.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// View / update fleet configurations.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeFleetAttributes</a> / <a>UpdateFleetAttributes</a> -- View or change a
    /// fleet's metadata and settings for game session protection and resource creation limits.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetPortSettings</a> / <a>UpdateFleetPortSettings</a> -- View or change
    /// the inbound permissions (IP address and port setting ranges) allowed for a fleet.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeRuntimeConfiguration</a> / <a>UpdateRuntimeConfiguration</a> -- View or
    /// change what server processes (and how many) to run on each instance in a fleet.
    /// </para>
    ///  </li> </ul> </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Control fleet capacity</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeEC2InstanceLimits</a> -- Retrieve maximum number of instances allowed
    /// for the current AWS account and the current usage level.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetCapacity</a> / <a>UpdateFleetCapacity</a> -- Retrieve the capacity
    /// settings and the current number of instances in a fleet; adjust fleet capacity settings
    /// to scale up or down.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Autoscale -- Manage auto-scaling rules and apply them to a fleet.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>PutScalingPolicy</a> -- Create a new auto-scaling policy, or update an existing
    /// one.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeScalingPolicies</a> -- Retrieve an existing auto-scaling policy.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteScalingPolicy</a> -- Delete an auto-scaling policy and stop it from affecting
    /// a fleet's capacity.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StartFleetActions</a> -- Restart a fleet's auto-scaling policies.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StopFleetActions</a> -- Suspend a fleet's auto-scaling policies.
    /// </para>
    ///  </li> </ul> </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Manage VPC peering connections for fleets</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateVpcPeeringAuthorization</a> -- Authorize a peering connection to one of
    /// your VPCs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeVpcPeeringAuthorizations</a> -- Retrieve valid peering connection authorizations.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteVpcPeeringAuthorization</a> -- Delete a peering connection authorization.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateVpcPeeringConnection</a> -- Establish a peering connection between the VPC
    /// for a Amazon GameLift fleet and one of your VPCs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeVpcPeeringConnections</a> -- Retrieve information on active or pending
    /// VPC peering connections with a Amazon GameLift fleet.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteVpcPeeringConnection</a> -- Delete a VPC peering connection with a Amazon
    /// GameLift fleet.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Access fleet activity statistics</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeFleetUtilization</a> -- Get current data on the number of server processes,
    /// game sessions, and players currently active on a fleet.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetEvents</a> -- Get a fleet's logged events for a specified time span.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeGameSessions</a> -- Retrieve metadata associated with one or more game
    /// sessions, including length of time active and current player count.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Remotely access an instance</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeInstances</a> -- Get information on each instance in a fleet, including
    /// instance ID, IP address, and status.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetInstanceAccess</a> -- Request access credentials needed to remotely connect
    /// to a specified instance in a fleet.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Manage fleet aliases</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateAlias</a> -- Define a new alias and optionally assign it to a fleet.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListAliases</a> -- Get all fleet aliases defined in a Amazon GameLift region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeAlias</a> -- Retrieve information on an existing alias.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateAlias</a> -- Change settings for a alias, such as redirecting it from one
    /// fleet to another.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteAlias</a> -- Remove an alias from the region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ResolveAlias</a> -- Get the fleet ID that a specified alias points to.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Manage game session queues</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateGameSessionQueue</a> -- Create a queue for processing requests for new game
    /// sessions. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeGameSessionQueues</a> -- Retrieve game session queues defined in a Amazon
    /// GameLift region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateGameSessionQueue</a> -- Change the configuration of a game session queue.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteGameSessionQueue</a> -- Remove a game session queue from the region.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Manage FlexMatch resources</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateMatchmakingConfiguration</a> -- Create a matchmaking configuration with
    /// instructions for building a player group and placing in a new game session. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeMatchmakingConfigurations</a> -- Retrieve matchmaking configurations defined
    /// a Amazon GameLift region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateMatchmakingConfiguration</a> -- Change settings for matchmaking configuration.
    /// queue.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteMatchmakingConfiguration</a> -- Remove a matchmaking configuration from
    /// the region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateMatchmakingRuleSet</a> -- Create a set of rules to use when searching for
    /// player matches. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeMatchmakingRuleSets</a> -- Retrieve matchmaking rule sets defined in a
    /// Amazon GameLift region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ValidateMatchmakingRuleSet</a> -- Verify syntax for a set of matchmaking rules.
    /// 
    /// </para>
    ///  </li> </ul> </li> </ul>
    /// </summary>
    public partial interface IAmazonGameLift : IAmazonService, IDisposable
    {
                
        #region  AcceptMatch


        /// <summary>
        /// Initiates the asynchronous execution of the AcceptMatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptMatch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/AcceptMatch">REST API Reference for AcceptMatch Operation</seealso>
        Task<AcceptMatchResponse> AcceptMatchAsync(AcceptMatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateBuild">REST API Reference for CreateBuild Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameSession">REST API Reference for CreateGameSession Operation</seealso>
        Task<CreateGameSessionResponse> CreateGameSessionAsync(CreateGameSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGameSessionQueue


        /// <summary>
        /// Initiates the asynchronous execution of the CreateGameSessionQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGameSessionQueue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameSessionQueue">REST API Reference for CreateGameSessionQueue Operation</seealso>
        Task<CreateGameSessionQueueResponse> CreateGameSessionQueueAsync(CreateGameSessionQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMatchmakingConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the CreateMatchmakingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchmakingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateMatchmakingConfiguration">REST API Reference for CreateMatchmakingConfiguration Operation</seealso>
        Task<CreateMatchmakingConfigurationResponse> CreateMatchmakingConfigurationAsync(CreateMatchmakingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMatchmakingRuleSet


        /// <summary>
        /// Initiates the asynchronous execution of the CreateMatchmakingRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchmakingRuleSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateMatchmakingRuleSet">REST API Reference for CreateMatchmakingRuleSet Operation</seealso>
        Task<CreateMatchmakingRuleSetResponse> CreateMatchmakingRuleSetAsync(CreateMatchmakingRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePlayerSession


        /// <summary>
        /// Adds a player to a game session and creates a player session record. Before a player
        /// can be added, a game session must have an <code>ACTIVE</code> status, have a creation
        /// policy of <code>ALLOW_ALL</code>, and have an open player slot. To add a group of
        /// players to a game session, use <a>CreatePlayerSessions</a>.
        /// 
        ///  
        /// <para>
        /// To create a player session, specify a game session ID, player ID, and optionally a
        /// string of player data. If successful, the player is added to the game session and
        /// a new <a>PlayerSession</a> object is returned. Player sessions cannot be updated.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
        /// </para>
        ///  
        /// <para>
        /// Player-session-related operations include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreatePlayerSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreatePlayerSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribePlayerSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Game session placements
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopGameSessionPlacement</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="gameSessionId">Unique identifier for the game session to add a player to.</param>
        /// <param name="playerId">Unique identifier for a player. Player IDs are developer-defined.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePlayerSession service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.GameSessionFullException">
        /// The game instance is currently full and cannot allow the requested player(s) to join.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Resolve the conflict before
        /// retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the routing strategy itself. Such requests should
        /// only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSession">REST API Reference for CreatePlayerSession Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSession">REST API Reference for CreatePlayerSession Operation</seealso>
        Task<CreatePlayerSessionResponse> CreatePlayerSessionAsync(CreatePlayerSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePlayerSessions


        /// <summary>
        /// Adds a group of players to a game session. This action is useful with a team matching
        /// feature. Before players can be added, a game session must have an <code>ACTIVE</code>
        /// status, have a creation policy of <code>ALLOW_ALL</code>, and have an open player
        /// slot. To add a single player to a game session, use <a>CreatePlayerSession</a>.
        /// 
        ///  
        /// <para>
        /// To create player sessions, specify a game session ID, a list of player IDs, and optionally
        /// a set of player data strings. If successful, the players are added to the game session
        /// and a set of new <a>PlayerSession</a> objects is returned. Player sessions cannot
        /// be updated.
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
        /// </para>
        ///  
        /// <para>
        /// Player-session-related operations include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreatePlayerSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreatePlayerSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribePlayerSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Game session placements
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopGameSessionPlacement</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="gameSessionId">Unique identifier for the game session to add players to.</param>
        /// <param name="playerIds">List of unique identifiers for the players to be added.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePlayerSessions service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.GameSessionFullException">
        /// The game instance is currently full and cannot allow the requested player(s) to join.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Resolve the conflict before
        /// retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the routing strategy itself. Such requests should
        /// only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSessions">REST API Reference for CreatePlayerSessions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSessions">REST API Reference for CreatePlayerSessions Operation</seealso>
        Task<CreatePlayerSessionsResponse> CreatePlayerSessionsAsync(CreatePlayerSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVpcPeeringAuthorization


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcPeeringAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringAuthorization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateVpcPeeringAuthorization">REST API Reference for CreateVpcPeeringAuthorization Operation</seealso>
        Task<CreateVpcPeeringAuthorizationResponse> CreateVpcPeeringAuthorizationAsync(CreateVpcPeeringAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVpcPeeringConnection


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateVpcPeeringConnection">REST API Reference for CreateVpcPeeringConnection Operation</seealso>
        Task<CreateVpcPeeringConnectionResponse> CreateVpcPeeringConnectionAsync(CreateVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAlias


        /// <summary>
        /// Deletes an alias. This action removes all record of the alias. Game clients attempting
        /// to access a server process using the deleted alias receive an error. To delete an
        /// alias, specify the alias ID to be deleted.
        /// 
        ///  
        /// <para>
        /// Alias-related operations include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResolveAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="aliasId">Unique identifier for a fleet alias. Specify the alias you want to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
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
        ///  
        /// <para>
        /// Build-related operations include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBuilds</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBuild</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="buildId">Unique identifier for a build to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteBuild">REST API Reference for DeleteBuild Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteBuild">REST API Reference for DeleteBuild Operation</seealso>
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
        ///  
        /// <para>
        /// Fleet-related operations include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Describe fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetUtilization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeRuntimeConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetEvents</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Update fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateRuntimeConfiguration</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Manage fleet actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="fleetId">Unique identifier for a fleet to be deleted.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        Task<DeleteFleetResponse> DeleteFleetAsync(DeleteFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGameSessionQueue


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGameSessionQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGameSessionQueue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteGameSessionQueue">REST API Reference for DeleteGameSessionQueue Operation</seealso>
        Task<DeleteGameSessionQueueResponse> DeleteGameSessionQueueAsync(DeleteGameSessionQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMatchmakingConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMatchmakingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchmakingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteMatchmakingConfiguration">REST API Reference for DeleteMatchmakingConfiguration Operation</seealso>
        Task<DeleteMatchmakingConfigurationResponse> DeleteMatchmakingConfigurationAsync(DeleteMatchmakingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteScalingPolicy">REST API Reference for DeleteScalingPolicy Operation</seealso>
        Task<DeleteScalingPolicyResponse> DeleteScalingPolicyAsync(DeleteScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVpcPeeringAuthorization


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcPeeringAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringAuthorization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteVpcPeeringAuthorization">REST API Reference for DeleteVpcPeeringAuthorization Operation</seealso>
        Task<DeleteVpcPeeringAuthorizationResponse> DeleteVpcPeeringAuthorizationAsync(DeleteVpcPeeringAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVpcPeeringConnection


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteVpcPeeringConnection">REST API Reference for DeleteVpcPeeringConnection Operation</seealso>
        Task<DeleteVpcPeeringConnectionResponse> DeleteVpcPeeringConnectionAsync(DeleteVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAlias


        /// <summary>
        /// Retrieves properties for an alias. This operation returns all alias metadata and settings.
        /// To get an alias's target fleet ID only, use <code>ResolveAlias</code>. 
        /// 
        ///  
        /// <para>
        /// To get alias properties, specify the alias ID. If successful, the requested alias
        /// record is returned.
        /// </para>
        ///  
        /// <para>
        /// Alias-related operations include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResolveAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="aliasId">Unique identifier for a fleet alias. Specify the alias you want to retrieve.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeAlias">REST API Reference for DescribeAlias Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeAlias">REST API Reference for DescribeAlias Operation</seealso>
        Task<DescribeAliasResponse> DescribeAliasAsync(DescribeAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBuild


        /// <summary>
        /// Retrieves properties for a build. To request a build record, specify a build ID. If
        /// successful, an object containing the build properties is returned.
        /// 
        ///  
        /// <para>
        /// Build-related operations include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBuilds</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBuild</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="buildId">Unique identifier for a build to retrieve properties for.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeBuild">REST API Reference for DescribeBuild Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeBuild">REST API Reference for DescribeBuild Operation</seealso>
        Task<DescribeBuildResponse> DescribeBuildAsync(DescribeBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEC2InstanceLimits


        /// <summary>
        /// Retrieves the following information for the specified EC2 instance type:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// maximum number of instances allowed per AWS account (service limit)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// current usage level for the AWS account
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Service limits vary depending on region. Available regions for Amazon GameLift can
        /// be found in the AWS Management Console for Amazon GameLift (see the drop-down list
        /// in the upper right corner).
        /// </para>
        ///  
        /// <para>
        /// Fleet-related operations include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Describe fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetUtilization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeRuntimeConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetEvents</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Update fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateRuntimeConfiguration</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Manage fleet actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="ec2InstanceType">Name of an EC2 instance type that is supported in Amazon GameLift. A fleet instance type determines the computing resources of each instance in the fleet, including CPU, memory, storage, and networking capacity. Amazon GameLift supports the following EC2 instance types. See <a href="http://aws.amazon.com/ec2/instance-types/">Amazon EC2 Instance Types</a> for detailed descriptions. Leave this parameter blank to retrieve limits for all types.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEC2InstanceLimits service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeEC2InstanceLimits">REST API Reference for DescribeEC2InstanceLimits Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeEC2InstanceLimits">REST API Reference for DescribeEC2InstanceLimits Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetAttributes">REST API Reference for DescribeFleetAttributes Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetCapacity">REST API Reference for DescribeFleetCapacity Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetEvents">REST API Reference for DescribeFleetEvents Operation</seealso>
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
        /// 
        ///  
        /// <para>
        /// Fleet-related operations include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Describe fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetUtilization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeRuntimeConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetEvents</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Update fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateRuntimeConfiguration</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Manage fleet actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="fleetId">Unique identifier for a fleet to retrieve port settings for.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleetPortSettings service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetPortSettings">REST API Reference for DescribeFleetPortSettings Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetPortSettings">REST API Reference for DescribeFleetPortSettings Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetUtilization">REST API Reference for DescribeFleetUtilization Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionDetails">REST API Reference for DescribeGameSessionDetails Operation</seealso>
        Task<DescribeGameSessionDetailsResponse> DescribeGameSessionDetailsAsync(DescribeGameSessionDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeGameSessionPlacement


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGameSessionPlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessionPlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionPlacement">REST API Reference for DescribeGameSessionPlacement Operation</seealso>
        Task<DescribeGameSessionPlacementResponse> DescribeGameSessionPlacementAsync(DescribeGameSessionPlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeGameSessionQueues


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGameSessionQueues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessionQueues operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionQueues">REST API Reference for DescribeGameSessionQueues Operation</seealso>
        Task<DescribeGameSessionQueuesResponse> DescribeGameSessionQueuesAsync(DescribeGameSessionQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessions">REST API Reference for DescribeGameSessions Operation</seealso>
        Task<DescribeGameSessionsResponse> DescribeGameSessionsAsync(DescribeGameSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInstances


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeMatchmaking


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMatchmaking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMatchmaking operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmaking">REST API Reference for DescribeMatchmaking Operation</seealso>
        Task<DescribeMatchmakingResponse> DescribeMatchmakingAsync(DescribeMatchmakingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeMatchmakingConfigurations


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMatchmakingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMatchmakingConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmakingConfigurations">REST API Reference for DescribeMatchmakingConfigurations Operation</seealso>
        Task<DescribeMatchmakingConfigurationsResponse> DescribeMatchmakingConfigurationsAsync(DescribeMatchmakingConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeMatchmakingRuleSets


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMatchmakingRuleSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMatchmakingRuleSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmakingRuleSets">REST API Reference for DescribeMatchmakingRuleSets Operation</seealso>
        Task<DescribeMatchmakingRuleSetsResponse> DescribeMatchmakingRuleSetsAsync(DescribeMatchmakingRuleSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribePlayerSessions">REST API Reference for DescribePlayerSessions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeRuntimeConfiguration">REST API Reference for DescribeRuntimeConfiguration Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeScalingPolicies">REST API Reference for DescribeScalingPolicies Operation</seealso>
        Task<DescribeScalingPoliciesResponse> DescribeScalingPoliciesAsync(DescribeScalingPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVpcPeeringAuthorizations


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcPeeringAuthorizations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringAuthorizations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeVpcPeeringAuthorizations">REST API Reference for DescribeVpcPeeringAuthorizations Operation</seealso>
        Task<DescribeVpcPeeringAuthorizationsResponse> DescribeVpcPeeringAuthorizationsAsync(DescribeVpcPeeringAuthorizationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVpcPeeringConnections


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcPeeringConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        Task<DescribeVpcPeeringConnectionsResponse> DescribeVpcPeeringConnectionsAsync(DescribeVpcPeeringConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGameSessionLogUrl


        /// <summary>
        /// Retrieves the location of stored game session logs for a specified game session. When
        /// a game session is terminated, Amazon GameLift automatically stores the logs in Amazon
        /// S3 and retains them for 14 days. Use this URL to download the logs.
        /// 
        ///  <note> 
        /// <para>
        /// See the <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_gamelift">AWS
        /// Service Limits</a> page for maximum log file sizes. Log files that exceed this limit
        /// are not saved.
        /// </para>
        ///  </note> 
        /// <para>
        /// Game-session-related operations include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionDetails</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SearchGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetGameSessionLogUrl</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Game session placements
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopGameSessionPlacement</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="gameSessionId">Unique identifier for the game session to get logs for.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGameSessionLogUrl service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetGameSessionLogUrl">REST API Reference for GetGameSessionLogUrl Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetGameSessionLogUrl">REST API Reference for GetGameSessionLogUrl Operation</seealso>
        Task<GetGameSessionLogUrlResponse> GetGameSessionLogUrlAsync(GetGameSessionLogUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetInstanceAccess


        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetInstanceAccess">REST API Reference for GetInstanceAccess Operation</seealso>
        Task<GetInstanceAccessResponse> GetInstanceAccessAsync(GetInstanceAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListBuilds">REST API Reference for ListBuilds Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListFleets">REST API Reference for ListFleets Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RequestUploadCredentials


        /// <summary>
        /// Retrieves a fresh set of credentials for use when uploading a new set of game build
        /// files to Amazon GameLift's Amazon S3. This is done as part of the build creation process;
        /// see <a>CreateBuild</a>.
        /// 
        ///  
        /// <para>
        /// To request new credentials, specify the build ID as returned with an initial <code>CreateBuild</code>
        /// request. If successful, a new set of credentials are returned, along with the S3 storage
        /// location associated with the build ID.
        /// </para>
        /// </summary>
        /// <param name="buildId">Unique identifier for a build to get credentials for.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestUploadCredentials service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/RequestUploadCredentials">REST API Reference for RequestUploadCredentials Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/RequestUploadCredentials">REST API Reference for RequestUploadCredentials Operation</seealso>
        Task<RequestUploadCredentialsResponse> RequestUploadCredentialsAsync(RequestUploadCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResolveAlias


        /// <summary>
        /// Retrieves the fleet ID that a specified alias is currently pointing to.
        /// 
        ///  
        /// <para>
        /// Alias-related operations include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResolveAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="aliasId">Unique identifier for the alias you want to resolve.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResolveAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the routing strategy itself. Such requests should
        /// only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ResolveAlias">REST API Reference for ResolveAlias Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ResolveAlias">REST API Reference for ResolveAlias Operation</seealso>
        Task<ResolveAliasResponse> ResolveAliasAsync(ResolveAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchGameSessions


        /// <summary>
        /// Initiates the asynchronous execution of the SearchGameSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchGameSessions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/SearchGameSessions">REST API Reference for SearchGameSessions Operation</seealso>
        Task<SearchGameSessionsResponse> SearchGameSessionsAsync(SearchGameSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartFleetActions


        /// <summary>
        /// Initiates the asynchronous execution of the StartFleetActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFleetActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartFleetActions">REST API Reference for StartFleetActions Operation</seealso>
        Task<StartFleetActionsResponse> StartFleetActionsAsync(StartFleetActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartGameSessionPlacement


        /// <summary>
        /// Initiates the asynchronous execution of the StartGameSessionPlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartGameSessionPlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartGameSessionPlacement">REST API Reference for StartGameSessionPlacement Operation</seealso>
        Task<StartGameSessionPlacementResponse> StartGameSessionPlacementAsync(StartGameSessionPlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartMatchBackfill


        /// <summary>
        /// Initiates the asynchronous execution of the StartMatchBackfill operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMatchBackfill operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartMatchBackfill">REST API Reference for StartMatchBackfill Operation</seealso>
        Task<StartMatchBackfillResponse> StartMatchBackfillAsync(StartMatchBackfillRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartMatchmaking


        /// <summary>
        /// Initiates the asynchronous execution of the StartMatchmaking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMatchmaking operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartMatchmaking">REST API Reference for StartMatchmaking Operation</seealso>
        Task<StartMatchmakingResponse> StartMatchmakingAsync(StartMatchmakingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopFleetActions


        /// <summary>
        /// Initiates the asynchronous execution of the StopFleetActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopFleetActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopFleetActions">REST API Reference for StopFleetActions Operation</seealso>
        Task<StopFleetActionsResponse> StopFleetActionsAsync(StopFleetActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopGameSessionPlacement


        /// <summary>
        /// Initiates the asynchronous execution of the StopGameSessionPlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopGameSessionPlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopGameSessionPlacement">REST API Reference for StopGameSessionPlacement Operation</seealso>
        Task<StopGameSessionPlacementResponse> StopGameSessionPlacementAsync(StopGameSessionPlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopMatchmaking


        /// <summary>
        /// Initiates the asynchronous execution of the StopMatchmaking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopMatchmaking operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopMatchmaking">REST API Reference for StopMatchmaking Operation</seealso>
        Task<StopMatchmakingResponse> StopMatchmakingAsync(StopMatchmakingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateBuild">REST API Reference for UpdateBuild Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetAttributes">REST API Reference for UpdateFleetAttributes Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetCapacity">REST API Reference for UpdateFleetCapacity Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetPortSettings">REST API Reference for UpdateFleetPortSettings Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameSession">REST API Reference for UpdateGameSession Operation</seealso>
        Task<UpdateGameSessionResponse> UpdateGameSessionAsync(UpdateGameSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGameSessionQueue


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGameSessionQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameSessionQueue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameSessionQueue">REST API Reference for UpdateGameSessionQueue Operation</seealso>
        Task<UpdateGameSessionQueueResponse> UpdateGameSessionQueueAsync(UpdateGameSessionQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMatchmakingConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMatchmakingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMatchmakingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateMatchmakingConfiguration">REST API Reference for UpdateMatchmakingConfiguration Operation</seealso>
        Task<UpdateMatchmakingConfigurationResponse> UpdateMatchmakingConfigurationAsync(UpdateMatchmakingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateRuntimeConfiguration">REST API Reference for UpdateRuntimeConfiguration Operation</seealso>
        Task<UpdateRuntimeConfigurationResponse> UpdateRuntimeConfigurationAsync(UpdateRuntimeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ValidateMatchmakingRuleSet


        /// <summary>
        /// Initiates the asynchronous execution of the ValidateMatchmakingRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateMatchmakingRuleSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ValidateMatchmakingRuleSet">REST API Reference for ValidateMatchmakingRuleSet Operation</seealso>
        Task<ValidateMatchmakingRuleSetResponse> ValidateMatchmakingRuleSetAsync(ValidateMatchmakingRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}