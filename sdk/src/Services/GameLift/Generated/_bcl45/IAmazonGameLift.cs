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
    /// GameLift provides solutions for hosting session-based multiplayer game servers in
    /// the cloud, including tools for deploying, operating, and scaling game servers. Built
    /// on AWS global computing infrastructure, GameLift helps you deliver high-performance,
    /// high-reliability, low-cost game servers while dynamically scaling your resource usage
    /// to meet player demand. 
    /// </para>
    ///  
    /// <para>
    ///  <b>About GameLift solutions</b> 
    /// </para>
    ///  
    /// <para>
    /// Get more information on these GameLift solutions in the <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/">Amazon
    /// GameLift Developer Guide</a>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Managed GameLift -- GameLift offers a fully managed service to set up and maintain
    /// computing machines for hosting, manage game session and player session life cycle,
    /// and handle security, storage, and performance tracking. You can use automatic scaling
    /// tools to balance hosting costs against meeting player demand., configure your game
    /// session management to minimize player latency, or add FlexMatch for matchmaking.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Managed GameLift with Realtime Servers – With GameLift Realtime Servers, you can quickly
    /// configure and set up game servers for your game. Realtime Servers provides a game
    /// server framework with core Amazon GameLift infrastructure already built in.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// GameLift FleetIQ – Use GameLift FleetIQ as a standalone feature while managing your
    /// own EC2 instances and Auto Scaling groups for game hosting. GameLift FleetIQ provides
    /// optimizations that make low-cost Spot Instances viable for game hosting. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>About this API Reference</b> 
    /// </para>
    ///  
    /// <para>
    /// This reference guide describes the low-level service API for Amazon GameLift. You
    /// can find links to language-specific SDK guides and the AWS CLI reference with each
    /// operation and data type topic. Useful links:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html">GameLift
    /// API operations listed by tasks</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-components.html">
    /// GameLift tools and resources</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonGameLift : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IGameLiftPaginatorFactory Paginators { get; }

        
        #region  AcceptMatch


        /// <summary>
        /// Registers a player's acceptance or rejection of a proposed FlexMatch match. A matchmaking
        /// configuration may require player acceptance; if so, then matches built with that configuration
        /// cannot be completed unless all players accept the proposed match within a specified
        /// time limit. 
        /// 
        ///  
        /// <para>
        /// When FlexMatch builds a match, all the matchmaking tickets involved in the proposed
        /// match are placed into status <code>REQUIRES_ACCEPTANCE</code>. This is a trigger for
        /// your game to get acceptance from all players in the ticket. Acceptances are only valid
        /// for tickets when they are in this status; all other acceptances result in an error.
        /// </para>
        ///  
        /// <para>
        /// To register acceptance, specify the ticket ID, a response, and one or more players.
        /// Once all players have registered acceptance, the matchmaking tickets advance to status
        /// <code>PLACING</code>, where a new game session is created for the match. 
        /// </para>
        ///  
        /// <para>
        /// If any player rejects the match, or if acceptances are not received before a specified
        /// timeout, the proposed match is dropped. The matchmaking tickets are then handled in
        /// one of two ways: For tickets where one or more players rejected the match, the ticket
        /// status is returned to <code>SEARCHING</code> to find a new match. For tickets where
        /// one or more players failed to respond, the ticket status is set to <code>CANCELLED</code>,
        /// and processing is terminated. A new matchmaking request for these players can be submitted
        /// as needed. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-client.html">
        /// Add FlexMatch to a Game Client</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-events.html">
        /// FlexMatch Events Reference</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AcceptMatch</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartMatchBackfill</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptMatch service method.</param>
        /// 
        /// <returns>The response from the AcceptMatch service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/AcceptMatch">REST API Reference for AcceptMatch Operation</seealso>
        AcceptMatchResponse AcceptMatch(AcceptMatchRequest request);



        /// <summary>
        /// Registers a player's acceptance or rejection of a proposed FlexMatch match. A matchmaking
        /// configuration may require player acceptance; if so, then matches built with that configuration
        /// cannot be completed unless all players accept the proposed match within a specified
        /// time limit. 
        /// 
        ///  
        /// <para>
        /// When FlexMatch builds a match, all the matchmaking tickets involved in the proposed
        /// match are placed into status <code>REQUIRES_ACCEPTANCE</code>. This is a trigger for
        /// your game to get acceptance from all players in the ticket. Acceptances are only valid
        /// for tickets when they are in this status; all other acceptances result in an error.
        /// </para>
        ///  
        /// <para>
        /// To register acceptance, specify the ticket ID, a response, and one or more players.
        /// Once all players have registered acceptance, the matchmaking tickets advance to status
        /// <code>PLACING</code>, where a new game session is created for the match. 
        /// </para>
        ///  
        /// <para>
        /// If any player rejects the match, or if acceptances are not received before a specified
        /// timeout, the proposed match is dropped. The matchmaking tickets are then handled in
        /// one of two ways: For tickets where one or more players rejected the match, the ticket
        /// status is returned to <code>SEARCHING</code> to find a new match. For tickets where
        /// one or more players failed to respond, the ticket status is set to <code>CANCELLED</code>,
        /// and processing is terminated. A new matchmaking request for these players can be submitted
        /// as needed. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-client.html">
        /// Add FlexMatch to a Game Client</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-events.html">
        /// FlexMatch Events Reference</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AcceptMatch</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartMatchBackfill</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptMatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptMatch service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/AcceptMatch">REST API Reference for AcceptMatch Operation</seealso>
        Task<AcceptMatchResponse> AcceptMatchAsync(AcceptMatchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ClaimGameServer


        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Locates an available game server and temporarily reserves it to host gameplay and
        /// players. This operation is called from a game client or client service (such as a
        /// matchmaker) to request hosting resources for a new game session. In response, GameLift
        /// FleetIQ locates an available game server, places it in <code>CLAIMED</code> status
        /// for 60 seconds, and returns connection information that players can use to connect
        /// to the game server. 
        /// </para>
        ///  
        /// <para>
        /// To claim a game server, identify a game server group. You can also specify a game
        /// server ID, although this approach bypasses GameLift FleetIQ placement optimization.
        /// Optionally, include game data to pass to the game server at the start of a game session,
        /// such as a game map or player information. 
        /// </para>
        ///  
        /// <para>
        /// When a game server is successfully claimed, connection information is returned. A
        /// claimed game server's utilization status remains <code>AVAILABLE</code> while the
        /// claim status is set to <code>CLAIMED</code> for up to 60 seconds. This time period
        /// gives the game server time to update its status to <code>UTILIZED</code> (using <a>UpdateGameServer</a>)
        /// once players join. If the game server's status is not updated within 60 seconds, the
        /// game server reverts to unclaimed status and is available to be claimed by another
        /// request. The claim time period is a fixed value and is not configurable.
        /// </para>
        ///  
        /// <para>
        /// If you try to claim a specific game server, this request will fail in the following
        /// cases:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the game server utilization status is <code>UTILIZED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the game server claim status is <code>CLAIMED</code>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// When claiming a specific game server, this request will succeed even if the game server
        /// is running on an instance in <code>DRAINING</code> status. To avoid this, first check
        /// the instance status by calling <a>DescribeGameServerInstances</a>.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RegisterGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ClaimGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeregisterGameServer</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ClaimGameServer service method.</param>
        /// 
        /// <returns>The response from the ClaimGameServer service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
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
        /// <exception cref="Amazon.GameLift.Model.OutOfCapacityException">
        /// The specified game server group has no available game servers to fulfill a <code>ClaimGameServer</code>
        /// request. Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ClaimGameServer">REST API Reference for ClaimGameServer Operation</seealso>
        ClaimGameServerResponse ClaimGameServer(ClaimGameServerRequest request);



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Locates an available game server and temporarily reserves it to host gameplay and
        /// players. This operation is called from a game client or client service (such as a
        /// matchmaker) to request hosting resources for a new game session. In response, GameLift
        /// FleetIQ locates an available game server, places it in <code>CLAIMED</code> status
        /// for 60 seconds, and returns connection information that players can use to connect
        /// to the game server. 
        /// </para>
        ///  
        /// <para>
        /// To claim a game server, identify a game server group. You can also specify a game
        /// server ID, although this approach bypasses GameLift FleetIQ placement optimization.
        /// Optionally, include game data to pass to the game server at the start of a game session,
        /// such as a game map or player information. 
        /// </para>
        ///  
        /// <para>
        /// When a game server is successfully claimed, connection information is returned. A
        /// claimed game server's utilization status remains <code>AVAILABLE</code> while the
        /// claim status is set to <code>CLAIMED</code> for up to 60 seconds. This time period
        /// gives the game server time to update its status to <code>UTILIZED</code> (using <a>UpdateGameServer</a>)
        /// once players join. If the game server's status is not updated within 60 seconds, the
        /// game server reverts to unclaimed status and is available to be claimed by another
        /// request. The claim time period is a fixed value and is not configurable.
        /// </para>
        ///  
        /// <para>
        /// If you try to claim a specific game server, this request will fail in the following
        /// cases:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the game server utilization status is <code>UTILIZED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the game server claim status is <code>CLAIMED</code>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// When claiming a specific game server, this request will succeed even if the game server
        /// is running on an instance in <code>DRAINING</code> status. To avoid this, first check
        /// the instance status by calling <a>DescribeGameServerInstances</a>.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RegisterGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ClaimGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeregisterGameServer</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ClaimGameServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ClaimGameServer service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
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
        /// <exception cref="Amazon.GameLift.Model.OutOfCapacityException">
        /// The specified game server group has no available game servers to fulfill a <code>ClaimGameServer</code>
        /// request. Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ClaimGameServer">REST API Reference for ClaimGameServer Operation</seealso>
        Task<ClaimGameServerResponse> ClaimGameServerAsync(ClaimGameServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAlias


        /// <summary>
        /// Creates an alias for a fleet. In most situations, you can use an alias ID in place
        /// of a fleet ID. An alias provides a level of abstraction for a fleet that is useful
        /// when redirecting player traffic from one fleet to another, such as when updating your
        /// game build. 
        /// 
        ///  
        /// <para>
        /// Amazon GameLift supports two types of routing strategies for aliases: simple and terminal.
        /// A simple alias points to an active fleet. A terminal alias is used to display messaging
        /// or link to a URL instead of routing players to an active fleet. For example, you might
        /// use a terminal alias when a game version is no longer supported and you want to direct
        /// players to an upgrade site. 
        /// </para>
        ///  
        /// <para>
        /// To create a fleet alias, specify an alias name, routing strategy, and optional description.
        /// Each simple alias can point to only one fleet, but a fleet can have multiple aliases.
        /// If successful, a new alias record is returned, including an alias ID and an ARN. You
        /// can reassign an alias to another fleet by calling <code>UpdateAlias</code>.
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
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        CreateAliasResponse CreateAlias(CreateAliasRequest request);



        /// <summary>
        /// Creates an alias for a fleet. In most situations, you can use an alias ID in place
        /// of a fleet ID. An alias provides a level of abstraction for a fleet that is useful
        /// when redirecting player traffic from one fleet to another, such as when updating your
        /// game build. 
        /// 
        ///  
        /// <para>
        /// Amazon GameLift supports two types of routing strategies for aliases: simple and terminal.
        /// A simple alias points to an active fleet. A terminal alias is used to display messaging
        /// or link to a URL instead of routing players to an active fleet. For example, you might
        /// use a terminal alias when a game version is no longer supported and you want to direct
        /// players to an upgrade site. 
        /// </para>
        ///  
        /// <para>
        /// To create a fleet alias, specify an alias name, routing strategy, and optional description.
        /// Each simple alias can point to only one fleet, but a fleet can have multiple aliases.
        /// If successful, a new alias record is returned, including an alias ID and an ARN. You
        /// can reassign an alias to another fleet by calling <code>UpdateAlias</code>.
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
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateBuild


        /// <summary>
        /// Creates a new Amazon GameLift build resource for your game server binary files. Game
        /// server binaries must be combined into a zip file for use with Amazon GameLift. 
        /// 
        ///  <important> 
        /// <para>
        /// When setting up a new game build for GameLift, we recommend using the AWS CLI command
        /// <b> <a href="https://docs.aws.amazon.com/cli/latest/reference/gamelift/upload-build.html">upload-build</a>
        /// </b>. This helper command combines two tasks: (1) it uploads your build files from
        /// a file directory to a GameLift Amazon S3 location, and (2) it creates a new build
        /// resource. 
        /// </para>
        ///  </important> 
        /// <para>
        /// The <code>CreateBuild</code> operation can used in the following scenarios:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To create a new game build with build files that are in an S3 location under an AWS
        /// account that you control. To use this option, you must first give Amazon GameLift
        /// access to the S3 bucket. With permissions in place, call <code>CreateBuild</code>
        /// and specify a build name, operating system, and the S3 storage location of your game
        /// build.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To directly upload your build files to a GameLift S3 location. To use this option,
        /// first call <code>CreateBuild</code> and specify a build name and operating system.
        /// This operation creates a new build resource and also returns an S3 location with temporary
        /// access credentials. Use the credentials to manually upload your build files to the
        /// specified S3 location. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UploadingObjects.html">Uploading
        /// Objects</a> in the <i>Amazon S3 Developer Guide</i>. Build files can be uploaded to
        /// the GameLift S3 location once only; that can't be updated. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If successful, this operation creates a new build resource with a unique build ID
        /// and places it in <code>INITIALIZED</code> status. A build must be in <code>READY</code>
        /// status before you can create fleets with it.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">Uploading
        /// Your Game</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-cli-uploading.html#gamelift-build-cli-uploading-create-build">
        /// Create a Build with Files in Amazon S3</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        /// <param name="request">Container for the necessary parameters to execute the CreateBuild service method.</param>
        /// 
        /// <returns>The response from the CreateBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateBuild">REST API Reference for CreateBuild Operation</seealso>
        CreateBuildResponse CreateBuild(CreateBuildRequest request);



        /// <summary>
        /// Creates a new Amazon GameLift build resource for your game server binary files. Game
        /// server binaries must be combined into a zip file for use with Amazon GameLift. 
        /// 
        ///  <important> 
        /// <para>
        /// When setting up a new game build for GameLift, we recommend using the AWS CLI command
        /// <b> <a href="https://docs.aws.amazon.com/cli/latest/reference/gamelift/upload-build.html">upload-build</a>
        /// </b>. This helper command combines two tasks: (1) it uploads your build files from
        /// a file directory to a GameLift Amazon S3 location, and (2) it creates a new build
        /// resource. 
        /// </para>
        ///  </important> 
        /// <para>
        /// The <code>CreateBuild</code> operation can used in the following scenarios:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To create a new game build with build files that are in an S3 location under an AWS
        /// account that you control. To use this option, you must first give Amazon GameLift
        /// access to the S3 bucket. With permissions in place, call <code>CreateBuild</code>
        /// and specify a build name, operating system, and the S3 storage location of your game
        /// build.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To directly upload your build files to a GameLift S3 location. To use this option,
        /// first call <code>CreateBuild</code> and specify a build name and operating system.
        /// This operation creates a new build resource and also returns an S3 location with temporary
        /// access credentials. Use the credentials to manually upload your build files to the
        /// specified S3 location. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UploadingObjects.html">Uploading
        /// Objects</a> in the <i>Amazon S3 Developer Guide</i>. Build files can be uploaded to
        /// the GameLift S3 location once only; that can't be updated. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If successful, this operation creates a new build resource with a unique build ID
        /// and places it in <code>INITIALIZED</code> status. A build must be in <code>READY</code>
        /// status before you can create fleets with it.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">Uploading
        /// Your Game</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-cli-uploading.html#gamelift-build-cli-uploading-create-build">
        /// Create a Build with Files in Amazon S3</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        /// <param name="request">Container for the necessary parameters to execute the CreateBuild service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateBuild">REST API Reference for CreateBuild Operation</seealso>
        Task<CreateBuildResponse> CreateBuildAsync(CreateBuildRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFleet


        /// <summary>
        /// Creates a new fleet to run your game servers. whether they are custom game builds
        /// or Realtime Servers with game-specific script. A fleet is a set of Amazon Elastic
        /// Compute Cloud (Amazon EC2) instances, each of which can host multiple game sessions.
        /// When creating a fleet, you choose the hardware specifications, set some configuration
        /// options, and specify the game server to deploy on the new fleet. 
        /// 
        ///  
        /// <para>
        /// To create a new fleet, provide the following: (1) a fleet name, (2) an EC2 instance
        /// type and fleet type (spot or on-demand), (3) the build ID for your game build or script
        /// ID if using Realtime Servers, and (4) a runtime configuration, which determines how
        /// game servers will run on each instance in the fleet. 
        /// </para>
        ///  
        /// <para>
        /// If the <code>CreateFleet</code> call is successful, Amazon GameLift performs the following
        /// tasks. You can track the process of a fleet by checking the fleet status or by monitoring
        /// fleet creation events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a fleet resource. Status: <code>NEW</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Begins writing events to the fleet event log, which can be accessed in the Amazon
        /// GameLift console.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Sets the fleet's target capacity to 1 (desired instances), which triggers Amazon GameLift
        /// to start one new EC2 instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Downloads the game build or Realtime script to the new instance and installs it. Statuses:
        /// <code>DOWNLOADING</code>, <code>VALIDATING</code>, <code>BUILDING</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Starts launching server processes on the instance. If the fleet is configured to run
        /// multiple server processes per instance, Amazon GameLift staggers each process launch
        /// by a few seconds. Status: <code>ACTIVATING</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Sets the fleet's status to <code>ACTIVE</code> as soon as one server process is ready
        /// to host a game session.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// Up Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-debug.html#fleets-creating-debug-creation">Debug
        /// Fleet Creation Issues</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        CreateFleetResponse CreateFleet(CreateFleetRequest request);



        /// <summary>
        /// Creates a new fleet to run your game servers. whether they are custom game builds
        /// or Realtime Servers with game-specific script. A fleet is a set of Amazon Elastic
        /// Compute Cloud (Amazon EC2) instances, each of which can host multiple game sessions.
        /// When creating a fleet, you choose the hardware specifications, set some configuration
        /// options, and specify the game server to deploy on the new fleet. 
        /// 
        ///  
        /// <para>
        /// To create a new fleet, provide the following: (1) a fleet name, (2) an EC2 instance
        /// type and fleet type (spot or on-demand), (3) the build ID for your game build or script
        /// ID if using Realtime Servers, and (4) a runtime configuration, which determines how
        /// game servers will run on each instance in the fleet. 
        /// </para>
        ///  
        /// <para>
        /// If the <code>CreateFleet</code> call is successful, Amazon GameLift performs the following
        /// tasks. You can track the process of a fleet by checking the fleet status or by monitoring
        /// fleet creation events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a fleet resource. Status: <code>NEW</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Begins writing events to the fleet event log, which can be accessed in the Amazon
        /// GameLift console.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Sets the fleet's target capacity to 1 (desired instances), which triggers Amazon GameLift
        /// to start one new EC2 instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Downloads the game build or Realtime script to the new instance and installs it. Statuses:
        /// <code>DOWNLOADING</code>, <code>VALIDATING</code>, <code>BUILDING</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Starts launching server processes on the instance. If the fleet is configured to run
        /// multiple server processes per instance, Amazon GameLift staggers each process launch
        /// by a few seconds. Status: <code>ACTIVATING</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Sets the fleet's status to <code>ACTIVE</code> as soon as one server process is ready
        /// to host a game session.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// Up Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-debug.html#fleets-creating-debug-creation">Debug
        /// Fleet Creation Issues</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateGameServerGroup


        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Creates a GameLift FleetIQ game server group for managing game hosting on a collection
        /// of Amazon EC2 instances for game hosting. This operation creates the game server group,
        /// creates an Auto Scaling group in your AWS account, and establishes a link between
        /// the two groups. You can view the status of your game server groups in the GameLift
        /// console. Game server group metrics and events are emitted to Amazon CloudWatch.
        /// </para>
        ///  
        /// <para>
        /// Before creating a new game server group, you must have the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon EC2 launch template that specifies how to launch Amazon EC2 instances with
        /// your game server build. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">
        /// Launching an Instance from a Launch Template</a> in the <i>Amazon EC2 User Guide</i>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An IAM role that extends limited access to your AWS account to allow GameLift FleetIQ
        /// to create and interact with the Auto Scaling group. For more information, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-iam-permissions-roles.html">Create
        /// IAM roles for cross-service interaction</a> in the <i>GameLift FleetIQ Developer Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To create a new game server group, specify a unique group name, IAM role and Amazon
        /// EC2 launch template, and provide a list of instance types that can be used in the
        /// group. You must also set initial maximum and minimum limits on the group's instance
        /// count. You can optionally set an Auto Scaling policy with target tracking based on
        /// a GameLift FleetIQ metric.
        /// </para>
        ///  
        /// <para>
        /// Once the game server group and corresponding Auto Scaling group are created, you have
        /// full access to change the Auto Scaling group's configuration as needed. Several properties
        /// that are set when creating a game server group, including maximum/minimum size and
        /// auto-scaling policy settings, must be updated directly in the Auto Scaling group.
        /// Keep in mind that some Auto Scaling group properties are periodically updated by GameLift
        /// FleetIQ as part of its balancing activities to optimize for availability and cost.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerInstances</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGameServerGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGameServerGroup service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameServerGroup">REST API Reference for CreateGameServerGroup Operation</seealso>
        CreateGameServerGroupResponse CreateGameServerGroup(CreateGameServerGroupRequest request);



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Creates a GameLift FleetIQ game server group for managing game hosting on a collection
        /// of Amazon EC2 instances for game hosting. This operation creates the game server group,
        /// creates an Auto Scaling group in your AWS account, and establishes a link between
        /// the two groups. You can view the status of your game server groups in the GameLift
        /// console. Game server group metrics and events are emitted to Amazon CloudWatch.
        /// </para>
        ///  
        /// <para>
        /// Before creating a new game server group, you must have the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon EC2 launch template that specifies how to launch Amazon EC2 instances with
        /// your game server build. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">
        /// Launching an Instance from a Launch Template</a> in the <i>Amazon EC2 User Guide</i>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An IAM role that extends limited access to your AWS account to allow GameLift FleetIQ
        /// to create and interact with the Auto Scaling group. For more information, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-iam-permissions-roles.html">Create
        /// IAM roles for cross-service interaction</a> in the <i>GameLift FleetIQ Developer Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To create a new game server group, specify a unique group name, IAM role and Amazon
        /// EC2 launch template, and provide a list of instance types that can be used in the
        /// group. You must also set initial maximum and minimum limits on the group's instance
        /// count. You can optionally set an Auto Scaling policy with target tracking based on
        /// a GameLift FleetIQ metric.
        /// </para>
        ///  
        /// <para>
        /// Once the game server group and corresponding Auto Scaling group are created, you have
        /// full access to change the Auto Scaling group's configuration as needed. Several properties
        /// that are set when creating a game server group, including maximum/minimum size and
        /// auto-scaling policy settings, must be updated directly in the Auto Scaling group.
        /// Keep in mind that some Auto Scaling group properties are periodically updated by GameLift
        /// FleetIQ as part of its balancing activities to optimize for availability and cost.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerInstances</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGameServerGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGameServerGroup service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameServerGroup">REST API Reference for CreateGameServerGroup Operation</seealso>
        Task<CreateGameServerGroupResponse> CreateGameServerGroupAsync(CreateGameServerGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateGameSession


        /// <summary>
        /// Creates a multiplayer game session for players. This operation creates a game session
        /// record and assigns an available server process in the specified fleet to host the
        /// game session. A fleet must have an <code>ACTIVE</code> status before a game session
        /// can be created in it.
        /// 
        ///  
        /// <para>
        /// To create a game session, specify either fleet ID or alias ID and indicate a maximum
        /// number of players to allow in the game session. You can also provide a name and game-specific
        /// properties for this game session. If successful, a <a>GameSession</a> object is returned
        /// containing the game session properties and other settings you specified.
        /// </para>
        ///  
        /// <para>
        ///  <b>Idempotency tokens.</b> You can add a token that uniquely identifies game session
        /// requests. This is useful for ensuring that game session requests are idempotent. Multiple
        /// requests with the same idempotency token are processed only once; subsequent requests
        /// return the original result. All response values are the same with the exception of
        /// game session status, which may change.
        /// </para>
        ///  
        /// <para>
        ///  <b>Resource creation limits.</b> If you are creating a game session on a fleet with
        /// a resource creation limit policy in force, then you must specify a creator ID. Without
        /// this ID, Amazon GameLift has no way to evaluate the policy for this new game session
        /// request.
        /// </para>
        ///  
        /// <para>
        ///  <b>Player acceptance policy.</b> By default, newly created game sessions are open
        /// to new players. You can restrict new player access by using <a>UpdateGameSession</a>
        /// to change the game session's player session creation policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Game session logs.</b> Logs are retained for all active game sessions for 14 days.
        /// To access the logs, call <a>GetGameSessionLogUrl</a> to download the log files.
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
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
        /// <param name="request">Container for the necessary parameters to execute the CreateGameSession service method.</param>
        /// 
        /// <returns>The response from the CreateGameSession service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.FleetCapacityExceededException">
        /// The specified fleet has no available instances to fulfill a <code>CreateGameSession</code>
        /// request. Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.IdempotentParameterMismatchException">
        /// A game session with this custom ID string already exists in this fleet. Resolve this
        /// conflict before retrying this request.
        /// </exception>
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
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameSession">REST API Reference for CreateGameSession Operation</seealso>
        CreateGameSessionResponse CreateGameSession(CreateGameSessionRequest request);



        /// <summary>
        /// Creates a multiplayer game session for players. This operation creates a game session
        /// record and assigns an available server process in the specified fleet to host the
        /// game session. A fleet must have an <code>ACTIVE</code> status before a game session
        /// can be created in it.
        /// 
        ///  
        /// <para>
        /// To create a game session, specify either fleet ID or alias ID and indicate a maximum
        /// number of players to allow in the game session. You can also provide a name and game-specific
        /// properties for this game session. If successful, a <a>GameSession</a> object is returned
        /// containing the game session properties and other settings you specified.
        /// </para>
        ///  
        /// <para>
        ///  <b>Idempotency tokens.</b> You can add a token that uniquely identifies game session
        /// requests. This is useful for ensuring that game session requests are idempotent. Multiple
        /// requests with the same idempotency token are processed only once; subsequent requests
        /// return the original result. All response values are the same with the exception of
        /// game session status, which may change.
        /// </para>
        ///  
        /// <para>
        ///  <b>Resource creation limits.</b> If you are creating a game session on a fleet with
        /// a resource creation limit policy in force, then you must specify a creator ID. Without
        /// this ID, Amazon GameLift has no way to evaluate the policy for this new game session
        /// request.
        /// </para>
        ///  
        /// <para>
        ///  <b>Player acceptance policy.</b> By default, newly created game sessions are open
        /// to new players. You can restrict new player access by using <a>UpdateGameSession</a>
        /// to change the game session's player session creation policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Game session logs.</b> Logs are retained for all active game sessions for 14 days.
        /// To access the logs, call <a>GetGameSessionLogUrl</a> to download the log files.
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
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
        /// <param name="request">Container for the necessary parameters to execute the CreateGameSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGameSession service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.FleetCapacityExceededException">
        /// The specified fleet has no available instances to fulfill a <code>CreateGameSession</code>
        /// request. Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.IdempotentParameterMismatchException">
        /// A game session with this custom ID string already exists in this fleet. Resolve this
        /// conflict before retrying this request.
        /// </exception>
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
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameSession">REST API Reference for CreateGameSession Operation</seealso>
        Task<CreateGameSessionResponse> CreateGameSessionAsync(CreateGameSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateGameSessionQueue


        /// <summary>
        /// Establishes a new queue for processing requests to place new game sessions. A queue
        /// identifies where new game sessions can be hosted -- by specifying a list of destinations
        /// (fleets or aliases) -- and how long requests can wait in the queue before timing out.
        /// You can set up a queue to try to place game sessions on fleets in multiple Regions.
        /// To add placement requests to a queue, call <a>StartGameSessionPlacement</a> and reference
        /// the queue name.
        /// 
        ///  
        /// <para>
        ///  <b>Destination order.</b> When processing a request for a game session, Amazon GameLift
        /// tries each destination in order until it finds one with available resources to host
        /// the new game session. A queue's default order is determined by how destinations are
        /// listed. The default order is overridden when a game session placement request provides
        /// player latency information. Player latency information enables Amazon GameLift to
        /// prioritize destinations where players report the lowest average latency, as a result
        /// placing the new game session where the majority of players will have the best possible
        /// gameplay experience.
        /// </para>
        ///  
        /// <para>
        ///  <b>Player latency policies.</b> For placement requests containing player latency
        /// information, use player latency policies to protect individual players from very high
        /// latencies. With a latency cap, even when a destination can deliver a low latency for
        /// most players, the game is not placed where any individual player is reporting latency
        /// higher than a policy's maximum. A queue can have multiple latency policies, which
        /// are enforced consecutively starting with the policy with the lowest latency cap. Use
        /// multiple policies to gradually relax latency controls; for example, you might set
        /// a policy with a low latency cap for the first 60 seconds, a second policy with a higher
        /// cap for the next 60 seconds, etc. 
        /// </para>
        ///  
        /// <para>
        /// To create a new queue, provide a name, timeout value, a list of destinations and,
        /// if desired, a set of latency policies. If successful, a new queue object is returned.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-design.html">
        /// Design a Game Session Queue</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-creating.html">
        /// Create a Game Session Queue</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionQueues</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameSessionQueue</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGameSessionQueue service method.</param>
        /// 
        /// <returns>The response from the CreateGameSessionQueue service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameSessionQueue">REST API Reference for CreateGameSessionQueue Operation</seealso>
        CreateGameSessionQueueResponse CreateGameSessionQueue(CreateGameSessionQueueRequest request);



        /// <summary>
        /// Establishes a new queue for processing requests to place new game sessions. A queue
        /// identifies where new game sessions can be hosted -- by specifying a list of destinations
        /// (fleets or aliases) -- and how long requests can wait in the queue before timing out.
        /// You can set up a queue to try to place game sessions on fleets in multiple Regions.
        /// To add placement requests to a queue, call <a>StartGameSessionPlacement</a> and reference
        /// the queue name.
        /// 
        ///  
        /// <para>
        ///  <b>Destination order.</b> When processing a request for a game session, Amazon GameLift
        /// tries each destination in order until it finds one with available resources to host
        /// the new game session. A queue's default order is determined by how destinations are
        /// listed. The default order is overridden when a game session placement request provides
        /// player latency information. Player latency information enables Amazon GameLift to
        /// prioritize destinations where players report the lowest average latency, as a result
        /// placing the new game session where the majority of players will have the best possible
        /// gameplay experience.
        /// </para>
        ///  
        /// <para>
        ///  <b>Player latency policies.</b> For placement requests containing player latency
        /// information, use player latency policies to protect individual players from very high
        /// latencies. With a latency cap, even when a destination can deliver a low latency for
        /// most players, the game is not placed where any individual player is reporting latency
        /// higher than a policy's maximum. A queue can have multiple latency policies, which
        /// are enforced consecutively starting with the policy with the lowest latency cap. Use
        /// multiple policies to gradually relax latency controls; for example, you might set
        /// a policy with a low latency cap for the first 60 seconds, a second policy with a higher
        /// cap for the next 60 seconds, etc. 
        /// </para>
        ///  
        /// <para>
        /// To create a new queue, provide a name, timeout value, a list of destinations and,
        /// if desired, a set of latency policies. If successful, a new queue object is returned.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-design.html">
        /// Design a Game Session Queue</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-creating.html">
        /// Create a Game Session Queue</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionQueues</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameSessionQueue</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGameSessionQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGameSessionQueue service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameSessionQueue">REST API Reference for CreateGameSessionQueue Operation</seealso>
        Task<CreateGameSessionQueueResponse> CreateGameSessionQueueAsync(CreateGameSessionQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateMatchmakingConfiguration


        /// <summary>
        /// Defines a new matchmaking configuration for use with FlexMatch. Whether your are using
        /// FlexMatch with GameLift hosting or as a standalone matchmaking service, the matchmaking
        /// configuration sets out rules for matching players and forming teams. If you're also
        /// using GameLift hosting, it defines how to start game sessions for each match. Your
        /// matchmaking system can use multiple configurations to handle different game scenarios.
        /// All matchmaking requests (<a>StartMatchmaking</a> or <a>StartMatchBackfill</a>) identify
        /// the matchmaking configuration to use and provide player attributes consistent with
        /// that configuration. 
        /// 
        ///  
        /// <para>
        /// To create a matchmaking configuration, you must provide the following: configuration
        /// name and FlexMatch mode (with or without GameLift hosting); a rule set that specifies
        /// how to evaluate players and find acceptable matches; whether player acceptance is
        /// required; and the maximum time allowed for a matchmaking attempt. When using FlexMatch
        /// with GameLift hosting, you also need to identify the game session queue to use when
        /// starting a game session for the match.
        /// </para>
        ///  
        /// <para>
        /// In addition, you must set up an Amazon Simple Notification Service (SNS) to receive
        /// matchmaking notifications, and provide the topic ARN in the matchmaking configuration.
        /// An alternative method, continuously polling ticket status with <a>DescribeMatchmaking</a>,
        /// is only suitable for games in development with low matchmaking usage.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/gamelift-match.html">
        /// FlexMatch Developer Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-configuration.html">
        /// Design a FlexMatch Matchmaker</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-notification.html">
        /// Set Up FlexMatch Event Notification</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchmakingConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateMatchmakingConfiguration service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateMatchmakingConfiguration">REST API Reference for CreateMatchmakingConfiguration Operation</seealso>
        CreateMatchmakingConfigurationResponse CreateMatchmakingConfiguration(CreateMatchmakingConfigurationRequest request);



        /// <summary>
        /// Defines a new matchmaking configuration for use with FlexMatch. Whether your are using
        /// FlexMatch with GameLift hosting or as a standalone matchmaking service, the matchmaking
        /// configuration sets out rules for matching players and forming teams. If you're also
        /// using GameLift hosting, it defines how to start game sessions for each match. Your
        /// matchmaking system can use multiple configurations to handle different game scenarios.
        /// All matchmaking requests (<a>StartMatchmaking</a> or <a>StartMatchBackfill</a>) identify
        /// the matchmaking configuration to use and provide player attributes consistent with
        /// that configuration. 
        /// 
        ///  
        /// <para>
        /// To create a matchmaking configuration, you must provide the following: configuration
        /// name and FlexMatch mode (with or without GameLift hosting); a rule set that specifies
        /// how to evaluate players and find acceptable matches; whether player acceptance is
        /// required; and the maximum time allowed for a matchmaking attempt. When using FlexMatch
        /// with GameLift hosting, you also need to identify the game session queue to use when
        /// starting a game session for the match.
        /// </para>
        ///  
        /// <para>
        /// In addition, you must set up an Amazon Simple Notification Service (SNS) to receive
        /// matchmaking notifications, and provide the topic ARN in the matchmaking configuration.
        /// An alternative method, continuously polling ticket status with <a>DescribeMatchmaking</a>,
        /// is only suitable for games in development with low matchmaking usage.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/gamelift-match.html">
        /// FlexMatch Developer Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-configuration.html">
        /// Design a FlexMatch Matchmaker</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-notification.html">
        /// Set Up FlexMatch Event Notification</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchmakingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMatchmakingConfiguration service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateMatchmakingConfiguration">REST API Reference for CreateMatchmakingConfiguration Operation</seealso>
        Task<CreateMatchmakingConfigurationResponse> CreateMatchmakingConfigurationAsync(CreateMatchmakingConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateMatchmakingRuleSet


        /// <summary>
        /// Creates a new rule set for FlexMatch matchmaking. A rule set describes the type of
        /// match to create, such as the number and size of teams. It also sets the parameters
        /// for acceptable player matches, such as minimum skill level or character type. A rule
        /// set is used by a <a>MatchmakingConfiguration</a>. 
        /// 
        ///  
        /// <para>
        /// To create a matchmaking rule set, provide unique rule set name and the rule set body
        /// in JSON format. Rule sets must be defined in the same Region as the matchmaking configuration
        /// they are used with.
        /// </para>
        ///  
        /// <para>
        /// Since matchmaking rule sets cannot be edited, it is a good idea to check the rule
        /// set syntax using <a>ValidateMatchmakingRuleSet</a> before creating a new rule set.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-rulesets.html">Build
        /// a Rule Set</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-configuration.html">Design
        /// a Matchmaker</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-intro.html">Matchmaking
        /// with FlexMatch</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchmakingRuleSet service method.</param>
        /// 
        /// <returns>The response from the CreateMatchmakingRuleSet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateMatchmakingRuleSet">REST API Reference for CreateMatchmakingRuleSet Operation</seealso>
        CreateMatchmakingRuleSetResponse CreateMatchmakingRuleSet(CreateMatchmakingRuleSetRequest request);



        /// <summary>
        /// Creates a new rule set for FlexMatch matchmaking. A rule set describes the type of
        /// match to create, such as the number and size of teams. It also sets the parameters
        /// for acceptable player matches, such as minimum skill level or character type. A rule
        /// set is used by a <a>MatchmakingConfiguration</a>. 
        /// 
        ///  
        /// <para>
        /// To create a matchmaking rule set, provide unique rule set name and the rule set body
        /// in JSON format. Rule sets must be defined in the same Region as the matchmaking configuration
        /// they are used with.
        /// </para>
        ///  
        /// <para>
        /// Since matchmaking rule sets cannot be edited, it is a good idea to check the rule
        /// set syntax using <a>ValidateMatchmakingRuleSet</a> before creating a new rule set.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-rulesets.html">Build
        /// a Rule Set</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-configuration.html">Design
        /// a Matchmaker</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-intro.html">Matchmaking
        /// with FlexMatch</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchmakingRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMatchmakingRuleSet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateMatchmakingRuleSet">REST API Reference for CreateMatchmakingRuleSet Operation</seealso>
        Task<CreateMatchmakingRuleSetResponse> CreateMatchmakingRuleSetAsync(CreateMatchmakingRuleSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePlayerSession


        /// <summary>
        /// Reserves an open player slot in an active game session. Before a player can be added,
        /// a game session must have an <code>ACTIVE</code> status, have a creation policy of
        /// <code>ALLOW_ALL</code>, and have an open player slot. To add a group of players to
        /// a game session, use <a>CreatePlayerSessions</a>. When the player connects to the game
        /// server and references a player session ID, the game server contacts the Amazon GameLift
        /// service to validate the player reservation and accept the player.
        /// 
        ///  
        /// <para>
        /// To create a player session, specify a game session ID, player ID, and optionally a
        /// string of player data. If successful, a slot is reserved in the game session for the
        /// player and a new <a>PlayerSession</a> object is returned. Player sessions cannot be
        /// updated. 
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
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
        /// <param name="gameSessionId">A unique identifier for the game session to add a player to.</param>
        /// <param name="playerId">A unique identifier for a player. Player IDs are developer-defined.</param>
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
        CreatePlayerSessionResponse CreatePlayerSession(string gameSessionId, string playerId);

        /// <summary>
        /// Reserves an open player slot in an active game session. Before a player can be added,
        /// a game session must have an <code>ACTIVE</code> status, have a creation policy of
        /// <code>ALLOW_ALL</code>, and have an open player slot. To add a group of players to
        /// a game session, use <a>CreatePlayerSessions</a>. When the player connects to the game
        /// server and references a player session ID, the game server contacts the Amazon GameLift
        /// service to validate the player reservation and accept the player.
        /// 
        ///  
        /// <para>
        /// To create a player session, specify a game session ID, player ID, and optionally a
        /// string of player data. If successful, a slot is reserved in the game session for the
        /// player and a new <a>PlayerSession</a> object is returned. Player sessions cannot be
        /// updated. 
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
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
        /// <param name="request">Container for the necessary parameters to execute the CreatePlayerSession service method.</param>
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
        CreatePlayerSessionResponse CreatePlayerSession(CreatePlayerSessionRequest request);


        /// <summary>
        /// Reserves an open player slot in an active game session. Before a player can be added,
        /// a game session must have an <code>ACTIVE</code> status, have a creation policy of
        /// <code>ALLOW_ALL</code>, and have an open player slot. To add a group of players to
        /// a game session, use <a>CreatePlayerSessions</a>. When the player connects to the game
        /// server and references a player session ID, the game server contacts the Amazon GameLift
        /// service to validate the player reservation and accept the player.
        /// 
        ///  
        /// <para>
        /// To create a player session, specify a game session ID, player ID, and optionally a
        /// string of player data. If successful, a slot is reserved in the game session for the
        /// player and a new <a>PlayerSession</a> object is returned. Player sessions cannot be
        /// updated. 
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
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
        /// <param name="gameSessionId">A unique identifier for the game session to add a player to.</param>
        /// <param name="playerId">A unique identifier for a player. Player IDs are developer-defined.</param>
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
        /// Reserves an open player slot in an active game session. Before a player can be added,
        /// a game session must have an <code>ACTIVE</code> status, have a creation policy of
        /// <code>ALLOW_ALL</code>, and have an open player slot. To add a group of players to
        /// a game session, use <a>CreatePlayerSessions</a>. When the player connects to the game
        /// server and references a player session ID, the game server contacts the Amazon GameLift
        /// service to validate the player reservation and accept the player.
        /// 
        ///  
        /// <para>
        /// To create a player session, specify a game session ID, player ID, and optionally a
        /// string of player data. If successful, a slot is reserved in the game session for the
        /// player and a new <a>PlayerSession</a> object is returned. Player sessions cannot be
        /// updated. 
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
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
        /// <param name="request">Container for the necessary parameters to execute the CreatePlayerSession service method.</param>
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
        Task<CreatePlayerSessionResponse> CreatePlayerSessionAsync(CreatePlayerSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePlayerSessions


        /// <summary>
        /// Reserves open slots in a game session for a group of players. Before players can be
        /// added, a game session must have an <code>ACTIVE</code> status, have a creation policy
        /// of <code>ALLOW_ALL</code>, and have an open player slot. To add a single player to
        /// a game session, use <a>CreatePlayerSession</a>. When a player connects to the game
        /// server and references a player session ID, the game server contacts the Amazon GameLift
        /// service to validate the player reservation and accept the player.
        /// 
        ///  
        /// <para>
        /// To create player sessions, specify a game session ID, a list of player IDs, and optionally
        /// a set of player data strings. If successful, a slot is reserved in the game session
        /// for each player and a set of new <a>PlayerSession</a> objects is returned. Player
        /// sessions cannot be updated.
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
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
        /// <param name="gameSessionId">A unique identifier for the game session to add players to.</param>
        /// <param name="playerIds">List of unique identifiers for the players to be added.</param>
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
        CreatePlayerSessionsResponse CreatePlayerSessions(string gameSessionId, List<string> playerIds);

        /// <summary>
        /// Reserves open slots in a game session for a group of players. Before players can be
        /// added, a game session must have an <code>ACTIVE</code> status, have a creation policy
        /// of <code>ALLOW_ALL</code>, and have an open player slot. To add a single player to
        /// a game session, use <a>CreatePlayerSession</a>. When a player connects to the game
        /// server and references a player session ID, the game server contacts the Amazon GameLift
        /// service to validate the player reservation and accept the player.
        /// 
        ///  
        /// <para>
        /// To create player sessions, specify a game session ID, a list of player IDs, and optionally
        /// a set of player data strings. If successful, a slot is reserved in the game session
        /// for each player and a set of new <a>PlayerSession</a> objects is returned. Player
        /// sessions cannot be updated.
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
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
        /// <param name="request">Container for the necessary parameters to execute the CreatePlayerSessions service method.</param>
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
        CreatePlayerSessionsResponse CreatePlayerSessions(CreatePlayerSessionsRequest request);


        /// <summary>
        /// Reserves open slots in a game session for a group of players. Before players can be
        /// added, a game session must have an <code>ACTIVE</code> status, have a creation policy
        /// of <code>ALLOW_ALL</code>, and have an open player slot. To add a single player to
        /// a game session, use <a>CreatePlayerSession</a>. When a player connects to the game
        /// server and references a player session ID, the game server contacts the Amazon GameLift
        /// service to validate the player reservation and accept the player.
        /// 
        ///  
        /// <para>
        /// To create player sessions, specify a game session ID, a list of player IDs, and optionally
        /// a set of player data strings. If successful, a slot is reserved in the game session
        /// for each player and a set of new <a>PlayerSession</a> objects is returned. Player
        /// sessions cannot be updated.
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
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
        /// <param name="gameSessionId">A unique identifier for the game session to add players to.</param>
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
        /// Reserves open slots in a game session for a group of players. Before players can be
        /// added, a game session must have an <code>ACTIVE</code> status, have a creation policy
        /// of <code>ALLOW_ALL</code>, and have an open player slot. To add a single player to
        /// a game session, use <a>CreatePlayerSession</a>. When a player connects to the game
        /// server and references a player session ID, the game server contacts the Amazon GameLift
        /// service to validate the player reservation and accept the player.
        /// 
        ///  
        /// <para>
        /// To create player sessions, specify a game session ID, a list of player IDs, and optionally
        /// a set of player data strings. If successful, a slot is reserved in the game session
        /// for each player and a set of new <a>PlayerSession</a> objects is returned. Player
        /// sessions cannot be updated.
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
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
        /// <param name="request">Container for the necessary parameters to execute the CreatePlayerSessions service method.</param>
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
        Task<CreatePlayerSessionsResponse> CreatePlayerSessionsAsync(CreatePlayerSessionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateScript


        /// <summary>
        /// Creates a new script record for your Realtime Servers script. Realtime scripts are
        /// JavaScript that provide configuration settings and optional custom game logic for
        /// your game. The script is deployed when you create a Realtime Servers fleet to host
        /// your game sessions. Script logic is executed during an active game session. 
        /// 
        ///  
        /// <para>
        /// To create a new script record, specify a script name and provide the script file(s).
        /// The script files and all dependencies must be zipped into a single file. You can pull
        /// the zip file from either of these locations: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A locally available directory. Use the <i>ZipFile</i> parameter for this option.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Amazon Simple Storage Service (Amazon S3) bucket under your AWS account. Use the
        /// <i>StorageLocation</i> parameter for this option. You'll need to have an Identity
        /// Access Management (IAM) role that allows the Amazon GameLift service to access your
        /// S3 bucket. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the call is successful, a new script record is created with a unique script ID.
        /// If the script file is provided as a local file, the file is uploaded to an Amazon
        /// GameLift-owned S3 bucket and the script record's storage location reflects this location.
        /// If the script file is provided as an S3 bucket, Amazon GameLift accesses the file
        /// at this storage location as needed for deployment.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
        /// GameLift Realtime Servers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/setting-up-role.html">Set
        /// Up a Role for Amazon GameLift Access</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListScripts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScript</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScript service method.</param>
        /// 
        /// <returns>The response from the CreateScript service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateScript">REST API Reference for CreateScript Operation</seealso>
        CreateScriptResponse CreateScript(CreateScriptRequest request);



        /// <summary>
        /// Creates a new script record for your Realtime Servers script. Realtime scripts are
        /// JavaScript that provide configuration settings and optional custom game logic for
        /// your game. The script is deployed when you create a Realtime Servers fleet to host
        /// your game sessions. Script logic is executed during an active game session. 
        /// 
        ///  
        /// <para>
        /// To create a new script record, specify a script name and provide the script file(s).
        /// The script files and all dependencies must be zipped into a single file. You can pull
        /// the zip file from either of these locations: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A locally available directory. Use the <i>ZipFile</i> parameter for this option.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Amazon Simple Storage Service (Amazon S3) bucket under your AWS account. Use the
        /// <i>StorageLocation</i> parameter for this option. You'll need to have an Identity
        /// Access Management (IAM) role that allows the Amazon GameLift service to access your
        /// S3 bucket. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the call is successful, a new script record is created with a unique script ID.
        /// If the script file is provided as a local file, the file is uploaded to an Amazon
        /// GameLift-owned S3 bucket and the script record's storage location reflects this location.
        /// If the script file is provided as an S3 bucket, Amazon GameLift accesses the file
        /// at this storage location as needed for deployment.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
        /// GameLift Realtime Servers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/setting-up-role.html">Set
        /// Up a Role for Amazon GameLift Access</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListScripts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScript</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScript service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateScript service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateScript">REST API Reference for CreateScript Operation</seealso>
        Task<CreateScriptResponse> CreateScriptAsync(CreateScriptRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateVpcPeeringAuthorization


        /// <summary>
        /// Requests authorization to create or delete a peer connection between the VPC for your
        /// Amazon GameLift fleet and a virtual private cloud (VPC) in your AWS account. VPC peering
        /// enables the game servers on your fleet to communicate directly with other AWS resources.
        /// Once you've received authorization, call <a>CreateVpcPeeringConnection</a> to establish
        /// the peering connection. For more information, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
        /// Peering with Amazon GameLift Fleets</a>.
        /// 
        ///  
        /// <para>
        /// You can peer with VPCs that are owned by any AWS account you have access to, including
        /// the account that you use to manage your Amazon GameLift fleets. You cannot peer with
        /// VPCs that are in different Regions.
        /// </para>
        ///  
        /// <para>
        /// To request authorization to create a connection, call this operation from the AWS
        /// account with the VPC that you want to peer to your Amazon GameLift fleet. For example,
        /// to enable your game servers to retrieve data from a DynamoDB table, use the account
        /// that manages that DynamoDB resource. Identify the following values: (1) The ID of
        /// the VPC that you want to peer with, and (2) the ID of the AWS account that you use
        /// to manage Amazon GameLift. If successful, VPC peering is authorized for the specified
        /// VPC. 
        /// </para>
        ///  
        /// <para>
        /// To request authorization to delete a connection, call this operation from the AWS
        /// account with the VPC that is peered with your Amazon GameLift fleet. Identify the
        /// following values: (1) VPC ID that you want to delete the peering connection for, and
        /// (2) ID of the AWS account that you use to manage Amazon GameLift. 
        /// </para>
        ///  
        /// <para>
        /// The authorization remains valid for 24 hours unless it is canceled by a call to <a>DeleteVpcPeeringAuthorization</a>.
        /// You must create or delete the peering connection while the authorization is valid.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringAuthorizations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringConnection</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringConnections</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringConnection</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringAuthorization service method.</param>
        /// 
        /// <returns>The response from the CreateVpcPeeringAuthorization service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateVpcPeeringAuthorization">REST API Reference for CreateVpcPeeringAuthorization Operation</seealso>
        CreateVpcPeeringAuthorizationResponse CreateVpcPeeringAuthorization(CreateVpcPeeringAuthorizationRequest request);



        /// <summary>
        /// Requests authorization to create or delete a peer connection between the VPC for your
        /// Amazon GameLift fleet and a virtual private cloud (VPC) in your AWS account. VPC peering
        /// enables the game servers on your fleet to communicate directly with other AWS resources.
        /// Once you've received authorization, call <a>CreateVpcPeeringConnection</a> to establish
        /// the peering connection. For more information, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
        /// Peering with Amazon GameLift Fleets</a>.
        /// 
        ///  
        /// <para>
        /// You can peer with VPCs that are owned by any AWS account you have access to, including
        /// the account that you use to manage your Amazon GameLift fleets. You cannot peer with
        /// VPCs that are in different Regions.
        /// </para>
        ///  
        /// <para>
        /// To request authorization to create a connection, call this operation from the AWS
        /// account with the VPC that you want to peer to your Amazon GameLift fleet. For example,
        /// to enable your game servers to retrieve data from a DynamoDB table, use the account
        /// that manages that DynamoDB resource. Identify the following values: (1) The ID of
        /// the VPC that you want to peer with, and (2) the ID of the AWS account that you use
        /// to manage Amazon GameLift. If successful, VPC peering is authorized for the specified
        /// VPC. 
        /// </para>
        ///  
        /// <para>
        /// To request authorization to delete a connection, call this operation from the AWS
        /// account with the VPC that is peered with your Amazon GameLift fleet. Identify the
        /// following values: (1) VPC ID that you want to delete the peering connection for, and
        /// (2) ID of the AWS account that you use to manage Amazon GameLift. 
        /// </para>
        ///  
        /// <para>
        /// The authorization remains valid for 24 hours unless it is canceled by a call to <a>DeleteVpcPeeringAuthorization</a>.
        /// You must create or delete the peering connection while the authorization is valid.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringAuthorizations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringConnection</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringConnections</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringConnection</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpcPeeringAuthorization service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateVpcPeeringAuthorization">REST API Reference for CreateVpcPeeringAuthorization Operation</seealso>
        Task<CreateVpcPeeringAuthorizationResponse> CreateVpcPeeringAuthorizationAsync(CreateVpcPeeringAuthorizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateVpcPeeringConnection


        /// <summary>
        /// Establishes a VPC peering connection between a virtual private cloud (VPC) in an AWS
        /// account with the VPC for your Amazon GameLift fleet. VPC peering enables the game
        /// servers on your fleet to communicate directly with other AWS resources. You can peer
        /// with VPCs in any AWS account that you have access to, including the account that you
        /// use to manage your Amazon GameLift fleets. You cannot peer with VPCs that are in different
        /// Regions. For more information, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
        /// Peering with Amazon GameLift Fleets</a>.
        /// 
        ///  
        /// <para>
        /// Before calling this operation to establish the peering connection, you first need
        /// to call <a>CreateVpcPeeringAuthorization</a> and identify the VPC you want to peer
        /// with. Once the authorization for the specified VPC is issued, you have 24 hours to
        /// establish the connection. These two operations handle all tasks necessary to peer
        /// the two VPCs, including acceptance, updating routing tables, etc. 
        /// </para>
        ///  
        /// <para>
        /// To establish the connection, call this operation from the AWS account that is used
        /// to manage the Amazon GameLift fleets. Identify the following values: (1) The ID of
        /// the fleet you want to be enable a VPC peering connection for; (2) The AWS account
        /// with the VPC that you want to peer with; and (3) The ID of the VPC you want to peer
        /// with. This operation is asynchronous. If successful, a <a>VpcPeeringConnection</a>
        /// request is created. You can use continuous polling to track the request's status using
        /// <a>DescribeVpcPeeringConnections</a>, or by monitoring fleet events for success or
        /// failure using <a>DescribeFleetEvents</a>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringAuthorizations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringConnection</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringConnections</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringConnection</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the CreateVpcPeeringConnection service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateVpcPeeringConnection">REST API Reference for CreateVpcPeeringConnection Operation</seealso>
        CreateVpcPeeringConnectionResponse CreateVpcPeeringConnection(CreateVpcPeeringConnectionRequest request);



        /// <summary>
        /// Establishes a VPC peering connection between a virtual private cloud (VPC) in an AWS
        /// account with the VPC for your Amazon GameLift fleet. VPC peering enables the game
        /// servers on your fleet to communicate directly with other AWS resources. You can peer
        /// with VPCs in any AWS account that you have access to, including the account that you
        /// use to manage your Amazon GameLift fleets. You cannot peer with VPCs that are in different
        /// Regions. For more information, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
        /// Peering with Amazon GameLift Fleets</a>.
        /// 
        ///  
        /// <para>
        /// Before calling this operation to establish the peering connection, you first need
        /// to call <a>CreateVpcPeeringAuthorization</a> and identify the VPC you want to peer
        /// with. Once the authorization for the specified VPC is issued, you have 24 hours to
        /// establish the connection. These two operations handle all tasks necessary to peer
        /// the two VPCs, including acceptance, updating routing tables, etc. 
        /// </para>
        ///  
        /// <para>
        /// To establish the connection, call this operation from the AWS account that is used
        /// to manage the Amazon GameLift fleets. Identify the following values: (1) The ID of
        /// the fleet you want to be enable a VPC peering connection for; (2) The AWS account
        /// with the VPC that you want to peer with; and (3) The ID of the VPC you want to peer
        /// with. This operation is asynchronous. If successful, a <a>VpcPeeringConnection</a>
        /// request is created. You can use continuous polling to track the request's status using
        /// <a>DescribeVpcPeeringConnections</a>, or by monitoring fleet events for success or
        /// failure using <a>DescribeFleetEvents</a>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringAuthorizations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringConnection</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringConnections</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringConnection</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpcPeeringConnection service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateVpcPeeringConnection">REST API Reference for CreateVpcPeeringConnection Operation</seealso>
        Task<CreateVpcPeeringConnectionResponse> CreateVpcPeeringConnectionAsync(CreateVpcPeeringConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAlias


        /// <summary>
        /// Deletes an alias. This operation removes all record of the alias. Game clients attempting
        /// to access a server process using the deleted alias receive an error. To delete an
        /// alias, specify the alias ID to be deleted.
        /// 
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
        /// <param name="aliasId">A unique identifier of the alias that you want to delete. You can use either the alias ID or ARN value.</param>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        DeleteAliasResponse DeleteAlias(string aliasId);

        /// <summary>
        /// Deletes an alias. This operation removes all record of the alias. Game clients attempting
        /// to access a server process using the deleted alias receive an error. To delete an
        /// alias, specify the alias ID to be deleted.
        /// 
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        DeleteAliasResponse DeleteAlias(DeleteAliasRequest request);


        /// <summary>
        /// Deletes an alias. This operation removes all record of the alias. Game clients attempting
        /// to access a server process using the deleted alias receive an error. To delete an
        /// alias, specify the alias ID to be deleted.
        /// 
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
        /// <param name="aliasId">A unique identifier of the alias that you want to delete. You can use either the alias ID or ARN value.</param>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        Task<DeleteAliasResponse> DeleteAliasAsync(string aliasId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Deletes an alias. This operation removes all record of the alias. Game clients attempting
        /// to access a server process using the deleted alias receive an error. To delete an
        /// alias, specify the alias ID to be deleted.
        /// 
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBuild


        /// <summary>
        /// Deletes a build. This operation permanently deletes the build resource and any uploaded
        /// build files. Deleting a build does not affect the status of any active fleets using
        /// the build, but you can no longer create new fleets with the deleted build.
        /// 
        ///  
        /// <para>
        /// To delete a build, specify the build ID. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">
        /// Upload a Custom Server Build</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        /// <param name="buildId">A unique identifier for a build to delete. You can use either the build ID or ARN value. </param>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteBuild">REST API Reference for DeleteBuild Operation</seealso>
        DeleteBuildResponse DeleteBuild(string buildId);

        /// <summary>
        /// Deletes a build. This operation permanently deletes the build resource and any uploaded
        /// build files. Deleting a build does not affect the status of any active fleets using
        /// the build, but you can no longer create new fleets with the deleted build.
        /// 
        ///  
        /// <para>
        /// To delete a build, specify the build ID. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">
        /// Upload a Custom Server Build</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteBuild service method.</param>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteBuild">REST API Reference for DeleteBuild Operation</seealso>
        DeleteBuildResponse DeleteBuild(DeleteBuildRequest request);


        /// <summary>
        /// Deletes a build. This operation permanently deletes the build resource and any uploaded
        /// build files. Deleting a build does not affect the status of any active fleets using
        /// the build, but you can no longer create new fleets with the deleted build.
        /// 
        ///  
        /// <para>
        /// To delete a build, specify the build ID. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">
        /// Upload a Custom Server Build</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        /// <param name="buildId">A unique identifier for a build to delete. You can use either the build ID or ARN value. </param>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteBuild">REST API Reference for DeleteBuild Operation</seealso>
        Task<DeleteBuildResponse> DeleteBuildAsync(string buildId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Deletes a build. This operation permanently deletes the build resource and any uploaded
        /// build files. Deleting a build does not affect the status of any active fleets using
        /// the build, but you can no longer create new fleets with the deleted build.
        /// 
        ///  
        /// <para>
        /// To delete a build, specify the build ID. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">
        /// Upload a Custom Server Build</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteBuild service method.</param>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteBuild">REST API Reference for DeleteBuild Operation</seealso>
        Task<DeleteBuildResponse> DeleteBuildAsync(DeleteBuildRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFleet


        /// <summary>
        /// Deletes everything related to a fleet. Before deleting a fleet, you must set the fleet's
        /// desired capacity to zero. See <a>UpdateFleetCapacity</a>.
        /// 
        ///  
        /// <para>
        /// If the fleet being deleted has a VPC peering connection, you first need to get a valid
        /// authorization (good for 24 hours) by calling <a>CreateVpcPeeringAuthorization</a>.
        /// You do not need to explicitly delete the VPC peering connection--this is done as part
        /// of the delete fleet process.
        /// </para>
        ///  
        /// <para>
        /// This operation removes the fleet and its resources. Once a fleet is deleted, you can
        /// no longer use any of the resource in that fleet.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="fleetId">A unique identifier for a fleet to be deleted. You can use either the fleet ID or ARN value.</param>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        DeleteFleetResponse DeleteFleet(string fleetId);

        /// <summary>
        /// Deletes everything related to a fleet. Before deleting a fleet, you must set the fleet's
        /// desired capacity to zero. See <a>UpdateFleetCapacity</a>.
        /// 
        ///  
        /// <para>
        /// If the fleet being deleted has a VPC peering connection, you first need to get a valid
        /// authorization (good for 24 hours) by calling <a>CreateVpcPeeringAuthorization</a>.
        /// You do not need to explicitly delete the VPC peering connection--this is done as part
        /// of the delete fleet process.
        /// </para>
        ///  
        /// <para>
        /// This operation removes the fleet and its resources. Once a fleet is deleted, you can
        /// no longer use any of the resource in that fleet.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        DeleteFleetResponse DeleteFleet(DeleteFleetRequest request);


        /// <summary>
        /// Deletes everything related to a fleet. Before deleting a fleet, you must set the fleet's
        /// desired capacity to zero. See <a>UpdateFleetCapacity</a>.
        /// 
        ///  
        /// <para>
        /// If the fleet being deleted has a VPC peering connection, you first need to get a valid
        /// authorization (good for 24 hours) by calling <a>CreateVpcPeeringAuthorization</a>.
        /// You do not need to explicitly delete the VPC peering connection--this is done as part
        /// of the delete fleet process.
        /// </para>
        ///  
        /// <para>
        /// This operation removes the fleet and its resources. Once a fleet is deleted, you can
        /// no longer use any of the resource in that fleet.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="fleetId">A unique identifier for a fleet to be deleted. You can use either the fleet ID or ARN value.</param>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        Task<DeleteFleetResponse> DeleteFleetAsync(string fleetId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Deletes everything related to a fleet. Before deleting a fleet, you must set the fleet's
        /// desired capacity to zero. See <a>UpdateFleetCapacity</a>.
        /// 
        ///  
        /// <para>
        /// If the fleet being deleted has a VPC peering connection, you first need to get a valid
        /// authorization (good for 24 hours) by calling <a>CreateVpcPeeringAuthorization</a>.
        /// You do not need to explicitly delete the VPC peering connection--this is done as part
        /// of the delete fleet process.
        /// </para>
        ///  
        /// <para>
        /// This operation removes the fleet and its resources. Once a fleet is deleted, you can
        /// no longer use any of the resource in that fleet.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        Task<DeleteFleetResponse> DeleteFleetAsync(DeleteFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteGameServerGroup


        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Terminates a game server group and permanently deletes the game server group record.
        /// You have several options for how these resources are impacted when deleting the game
        /// server group. Depending on the type of delete operation selected, this operation might
        /// affect these resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The game server group
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The corresponding Auto Scaling group
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All game servers that are currently running in the group
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To delete a game server group, identify the game server group to delete and specify
        /// the type of delete operation to initiate. Game server groups can only be deleted if
        /// they are in <code>ACTIVE</code> or <code>ERROR</code> status.
        /// </para>
        ///  
        /// <para>
        /// If the delete request is successful, a series of operations are kicked off. The game
        /// server group status is changed to <code>DELETE_SCHEDULED</code>, which prevents new
        /// game servers from being registered and stops automatic scaling activity. Once all
        /// game servers in the game server group are deregistered, GameLift FleetIQ can begin
        /// deleting resources. If any of the delete operations fail, the game server group is
        /// placed in <code>ERROR</code> status.
        /// </para>
        ///  
        /// <para>
        /// GameLift FleetIQ emits delete events to Amazon CloudWatch.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerInstances</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGameServerGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGameServerGroup service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteGameServerGroup">REST API Reference for DeleteGameServerGroup Operation</seealso>
        DeleteGameServerGroupResponse DeleteGameServerGroup(DeleteGameServerGroupRequest request);



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Terminates a game server group and permanently deletes the game server group record.
        /// You have several options for how these resources are impacted when deleting the game
        /// server group. Depending on the type of delete operation selected, this operation might
        /// affect these resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The game server group
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The corresponding Auto Scaling group
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All game servers that are currently running in the group
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To delete a game server group, identify the game server group to delete and specify
        /// the type of delete operation to initiate. Game server groups can only be deleted if
        /// they are in <code>ACTIVE</code> or <code>ERROR</code> status.
        /// </para>
        ///  
        /// <para>
        /// If the delete request is successful, a series of operations are kicked off. The game
        /// server group status is changed to <code>DELETE_SCHEDULED</code>, which prevents new
        /// game servers from being registered and stops automatic scaling activity. Once all
        /// game servers in the game server group are deregistered, GameLift FleetIQ can begin
        /// deleting resources. If any of the delete operations fail, the game server group is
        /// placed in <code>ERROR</code> status.
        /// </para>
        ///  
        /// <para>
        /// GameLift FleetIQ emits delete events to Amazon CloudWatch.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerInstances</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGameServerGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGameServerGroup service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteGameServerGroup">REST API Reference for DeleteGameServerGroup Operation</seealso>
        Task<DeleteGameServerGroupResponse> DeleteGameServerGroupAsync(DeleteGameServerGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteGameSessionQueue


        /// <summary>
        /// Deletes a game session queue. Once a queue is successfully deleted, unfulfilled <a>StartGameSessionPlacement</a>
        /// requests that reference the queue will fail. To delete a queue, specify the queue
        /// name.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-intro.html">
        /// Using Multi-Region Queues</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionQueues</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameSessionQueue</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGameSessionQueue service method.</param>
        /// 
        /// <returns>The response from the DeleteGameSessionQueue service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteGameSessionQueue">REST API Reference for DeleteGameSessionQueue Operation</seealso>
        DeleteGameSessionQueueResponse DeleteGameSessionQueue(DeleteGameSessionQueueRequest request);



        /// <summary>
        /// Deletes a game session queue. Once a queue is successfully deleted, unfulfilled <a>StartGameSessionPlacement</a>
        /// requests that reference the queue will fail. To delete a queue, specify the queue
        /// name.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-intro.html">
        /// Using Multi-Region Queues</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionQueues</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameSessionQueue</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGameSessionQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGameSessionQueue service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteGameSessionQueue">REST API Reference for DeleteGameSessionQueue Operation</seealso>
        Task<DeleteGameSessionQueueResponse> DeleteGameSessionQueueAsync(DeleteGameSessionQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMatchmakingConfiguration


        /// <summary>
        /// Permanently removes a FlexMatch matchmaking configuration. To delete, specify the
        /// configuration name. A matchmaking configuration cannot be deleted if it is being used
        /// in any active matchmaking tickets.
        /// 
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchmakingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteMatchmakingConfiguration service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteMatchmakingConfiguration">REST API Reference for DeleteMatchmakingConfiguration Operation</seealso>
        DeleteMatchmakingConfigurationResponse DeleteMatchmakingConfiguration(DeleteMatchmakingConfigurationRequest request);



        /// <summary>
        /// Permanently removes a FlexMatch matchmaking configuration. To delete, specify the
        /// configuration name. A matchmaking configuration cannot be deleted if it is being used
        /// in any active matchmaking tickets.
        /// 
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchmakingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMatchmakingConfiguration service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteMatchmakingConfiguration">REST API Reference for DeleteMatchmakingConfiguration Operation</seealso>
        Task<DeleteMatchmakingConfigurationResponse> DeleteMatchmakingConfigurationAsync(DeleteMatchmakingConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMatchmakingRuleSet


        /// <summary>
        /// Deletes an existing matchmaking rule set. To delete the rule set, provide the rule
        /// set name. Rule sets cannot be deleted if they are currently being used by a matchmaking
        /// configuration. 
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-rulesets.html">Build
        /// a Rule Set</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchmakingRuleSet service method.</param>
        /// 
        /// <returns>The response from the DeleteMatchmakingRuleSet service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteMatchmakingRuleSet">REST API Reference for DeleteMatchmakingRuleSet Operation</seealso>
        DeleteMatchmakingRuleSetResponse DeleteMatchmakingRuleSet(DeleteMatchmakingRuleSetRequest request);



        /// <summary>
        /// Deletes an existing matchmaking rule set. To delete the rule set, provide the rule
        /// set name. Rule sets cannot be deleted if they are currently being used by a matchmaking
        /// configuration. 
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-rulesets.html">Build
        /// a Rule Set</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchmakingRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMatchmakingRuleSet service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteMatchmakingRuleSet">REST API Reference for DeleteMatchmakingRuleSet Operation</seealso>
        Task<DeleteMatchmakingRuleSetResponse> DeleteMatchmakingRuleSetAsync(DeleteMatchmakingRuleSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteScalingPolicy


        /// <summary>
        /// Deletes a fleet scaling policy. Once deleted, the policy is no longer in force and
        /// GameLift removes all record of it. To delete a scaling policy, specify both the scaling
        /// policy name and the fleet ID it is associated with.
        /// 
        ///  
        /// <para>
        /// To temporarily suspend scaling policies, call <a>StopFleetActions</a>. This operation
        /// suspends all policies for the fleet.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Manage scaling policies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutScalingPolicy</a> (auto-scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScalingPolicies</a> (auto-scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScalingPolicy</a> (auto-scaling)
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteScalingPolicy service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteScalingPolicy">REST API Reference for DeleteScalingPolicy Operation</seealso>
        DeleteScalingPolicyResponse DeleteScalingPolicy(DeleteScalingPolicyRequest request);



        /// <summary>
        /// Deletes a fleet scaling policy. Once deleted, the policy is no longer in force and
        /// GameLift removes all record of it. To delete a scaling policy, specify both the scaling
        /// policy name and the fleet ID it is associated with.
        /// 
        ///  
        /// <para>
        /// To temporarily suspend scaling policies, call <a>StopFleetActions</a>. This operation
        /// suspends all policies for the fleet.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Manage scaling policies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutScalingPolicy</a> (auto-scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScalingPolicies</a> (auto-scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScalingPolicy</a> (auto-scaling)
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteScalingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteScalingPolicy service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteScalingPolicy">REST API Reference for DeleteScalingPolicy Operation</seealso>
        Task<DeleteScalingPolicyResponse> DeleteScalingPolicyAsync(DeleteScalingPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteScript


        /// <summary>
        /// Deletes a Realtime script. This operation permanently deletes the script record. If
        /// script files were uploaded, they are also deleted (files stored in an S3 bucket are
        /// not deleted). 
        /// 
        ///  
        /// <para>
        /// To delete a script, specify the script ID. Before deleting a script, be sure to terminate
        /// all fleets that are deployed with the script being deleted. Fleet instances periodically
        /// check for script updates, and if the script record no longer exists, the instance
        /// will go into an error state and be unable to host game sessions.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
        /// GameLift Realtime Servers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListScripts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScript</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScript service method.</param>
        /// 
        /// <returns>The response from the DeleteScript service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteScript">REST API Reference for DeleteScript Operation</seealso>
        DeleteScriptResponse DeleteScript(DeleteScriptRequest request);



        /// <summary>
        /// Deletes a Realtime script. This operation permanently deletes the script record. If
        /// script files were uploaded, they are also deleted (files stored in an S3 bucket are
        /// not deleted). 
        /// 
        ///  
        /// <para>
        /// To delete a script, specify the script ID. Before deleting a script, be sure to terminate
        /// all fleets that are deployed with the script being deleted. Fleet instances periodically
        /// check for script updates, and if the script record no longer exists, the instance
        /// will go into an error state and be unable to host game sessions.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
        /// GameLift Realtime Servers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListScripts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScript</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScript service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteScript service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteScript">REST API Reference for DeleteScript Operation</seealso>
        Task<DeleteScriptResponse> DeleteScriptAsync(DeleteScriptRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteVpcPeeringAuthorization


        /// <summary>
        /// Cancels a pending VPC peering authorization for the specified VPC. If you need to
        /// delete an existing VPC peering connection, call <a>DeleteVpcPeeringConnection</a>.
        /// 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringAuthorizations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringConnection</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringConnections</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringConnection</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringAuthorization service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcPeeringAuthorization service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteVpcPeeringAuthorization">REST API Reference for DeleteVpcPeeringAuthorization Operation</seealso>
        DeleteVpcPeeringAuthorizationResponse DeleteVpcPeeringAuthorization(DeleteVpcPeeringAuthorizationRequest request);



        /// <summary>
        /// Cancels a pending VPC peering authorization for the specified VPC. If you need to
        /// delete an existing VPC peering connection, call <a>DeleteVpcPeeringConnection</a>.
        /// 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringAuthorizations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringConnection</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringConnections</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringConnection</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpcPeeringAuthorization service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteVpcPeeringAuthorization">REST API Reference for DeleteVpcPeeringAuthorization Operation</seealso>
        Task<DeleteVpcPeeringAuthorizationResponse> DeleteVpcPeeringAuthorizationAsync(DeleteVpcPeeringAuthorizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteVpcPeeringConnection


        /// <summary>
        /// Removes a VPC peering connection. To delete the connection, you must have a valid
        /// authorization for the VPC peering connection that you want to delete. You can check
        /// for an authorization by calling <a>DescribeVpcPeeringAuthorizations</a> or request
        /// a new one using <a>CreateVpcPeeringAuthorization</a>. 
        /// 
        ///  
        /// <para>
        /// Once a valid authorization exists, call this operation from the AWS account that is
        /// used to manage the Amazon GameLift fleets. Identify the connection to delete by the
        /// connection ID and fleet ID. If successful, the connection is removed. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringAuthorizations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringConnection</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringConnections</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringConnection</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcPeeringConnection service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteVpcPeeringConnection">REST API Reference for DeleteVpcPeeringConnection Operation</seealso>
        DeleteVpcPeeringConnectionResponse DeleteVpcPeeringConnection(DeleteVpcPeeringConnectionRequest request);



        /// <summary>
        /// Removes a VPC peering connection. To delete the connection, you must have a valid
        /// authorization for the VPC peering connection that you want to delete. You can check
        /// for an authorization by calling <a>DescribeVpcPeeringAuthorizations</a> or request
        /// a new one using <a>CreateVpcPeeringAuthorization</a>. 
        /// 
        ///  
        /// <para>
        /// Once a valid authorization exists, call this operation from the AWS account that is
        /// used to manage the Amazon GameLift fleets. Identify the connection to delete by the
        /// connection ID and fleet ID. If successful, the connection is removed. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringAuthorizations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringConnection</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringConnections</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringConnection</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpcPeeringConnection service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteVpcPeeringConnection">REST API Reference for DeleteVpcPeeringConnection Operation</seealso>
        Task<DeleteVpcPeeringConnectionResponse> DeleteVpcPeeringConnectionAsync(DeleteVpcPeeringConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterGameServer


        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Removes the game server from a game server group. As a result of this operation, the
        /// deregistered game server can no longer be claimed and will not be returned in a list
        /// of active game servers. 
        /// </para>
        ///  
        /// <para>
        /// To deregister a game server, specify the game server group and game server ID. If
        /// successful, this operation emits a CloudWatch event with termination timestamp and
        /// reason.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RegisterGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ClaimGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeregisterGameServer</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterGameServer service method.</param>
        /// 
        /// <returns>The response from the DeregisterGameServer service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeregisterGameServer">REST API Reference for DeregisterGameServer Operation</seealso>
        DeregisterGameServerResponse DeregisterGameServer(DeregisterGameServerRequest request);



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Removes the game server from a game server group. As a result of this operation, the
        /// deregistered game server can no longer be claimed and will not be returned in a list
        /// of active game servers. 
        /// </para>
        ///  
        /// <para>
        /// To deregister a game server, specify the game server group and game server ID. If
        /// successful, this operation emits a CloudWatch event with termination timestamp and
        /// reason.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RegisterGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ClaimGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeregisterGameServer</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterGameServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterGameServer service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeregisterGameServer">REST API Reference for DeregisterGameServer Operation</seealso>
        Task<DeregisterGameServerResponse> DeregisterGameServerAsync(DeregisterGameServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="aliasId">The unique identifier for the fleet alias that you want to retrieve. You can use either the alias ID or ARN value. </param>
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
        DescribeAliasResponse DescribeAlias(string aliasId);

        /// <summary>
        /// Retrieves properties for an alias. This operation returns all alias metadata and settings.
        /// To get an alias's target fleet ID only, use <code>ResolveAlias</code>. 
        /// 
        ///  
        /// <para>
        /// To get alias properties, specify the alias ID. If successful, the requested alias
        /// record is returned.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlias service method.</param>
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
        DescribeAliasResponse DescribeAlias(DescribeAliasRequest request);


        /// <summary>
        /// Retrieves properties for an alias. This operation returns all alias metadata and settings.
        /// To get an alias's target fleet ID only, use <code>ResolveAlias</code>. 
        /// 
        ///  
        /// <para>
        /// To get alias properties, specify the alias ID. If successful, the requested alias
        /// record is returned.
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
        /// <param name="aliasId">The unique identifier for the fleet alias that you want to retrieve. You can use either the alias ID or ARN value. </param>
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
        /// Retrieves properties for an alias. This operation returns all alias metadata and settings.
        /// To get an alias's target fleet ID only, use <code>ResolveAlias</code>. 
        /// 
        ///  
        /// <para>
        /// To get alias properties, specify the alias ID. If successful, the requested alias
        /// record is returned.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlias service method.</param>
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
        Task<DescribeAliasResponse> DescribeAliasAsync(DescribeAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeBuild


        /// <summary>
        /// Retrieves properties for a custom game build. To request a build resource, specify
        /// a build ID. If successful, an object containing the build properties is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">
        /// Upload a Custom Server Build</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        /// <param name="buildId">A unique identifier for a build to retrieve properties for. You can use either the build ID or ARN value. </param>
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
        DescribeBuildResponse DescribeBuild(string buildId);

        /// <summary>
        /// Retrieves properties for a custom game build. To request a build resource, specify
        /// a build ID. If successful, an object containing the build properties is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">
        /// Upload a Custom Server Build</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeBuild service method.</param>
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
        DescribeBuildResponse DescribeBuild(DescribeBuildRequest request);


        /// <summary>
        /// Retrieves properties for a custom game build. To request a build resource, specify
        /// a build ID. If successful, an object containing the build properties is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">
        /// Upload a Custom Server Build</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        /// <param name="buildId">A unique identifier for a build to retrieve properties for. You can use either the build ID or ARN value. </param>
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
        /// Retrieves properties for a custom game build. To request a build resource, specify
        /// a build ID. If successful, an object containing the build properties is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">
        /// Upload a Custom Server Build</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeBuild service method.</param>
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
        Task<DescribeBuildResponse> DescribeBuildAsync(DescribeBuildRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEC2InstanceLimits


        /// <summary>
        /// Retrieves the following information for the specified EC2 instance type:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of instances allowed per AWS account (service limit).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Current usage for the AWS account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To learn more about the capabilities of each instance type, see <a href="http://aws.amazon.com/ec2/instance-types/">Amazon
        /// EC2 Instance Types</a>. Note that the instance types offered may vary depending on
        /// the region.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="ec2InstanceType">Name of an EC2 instance type that is supported in Amazon GameLift. A fleet instance type determines the computing resources of each instance in the fleet, including CPU, memory, storage, and networking capacity. Amazon GameLift supports the following EC2 instance types. See <a href="http://aws.amazon.com/ec2/instance-types/">Amazon EC2 Instance Types</a> for detailed descriptions. Leave this parameter blank to retrieve limits for all types.</param>
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
        DescribeEC2InstanceLimitsResponse DescribeEC2InstanceLimits(EC2InstanceType ec2InstanceType);

        /// <summary>
        /// Retrieves the following information for the specified EC2 instance type:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of instances allowed per AWS account (service limit).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Current usage for the AWS account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To learn more about the capabilities of each instance type, see <a href="http://aws.amazon.com/ec2/instance-types/">Amazon
        /// EC2 Instance Types</a>. Note that the instance types offered may vary depending on
        /// the region.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEC2InstanceLimits service method.</param>
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
        DescribeEC2InstanceLimitsResponse DescribeEC2InstanceLimits(DescribeEC2InstanceLimitsRequest request);


        /// <summary>
        /// Retrieves the following information for the specified EC2 instance type:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of instances allowed per AWS account (service limit).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Current usage for the AWS account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To learn more about the capabilities of each instance type, see <a href="http://aws.amazon.com/ec2/instance-types/">Amazon
        /// EC2 Instance Types</a>. Note that the instance types offered may vary depending on
        /// the region.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
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
        /// Retrieves the following information for the specified EC2 instance type:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of instances allowed per AWS account (service limit).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Current usage for the AWS account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To learn more about the capabilities of each instance type, see <a href="http://aws.amazon.com/ec2/instance-types/">Amazon
        /// EC2 Instance Types</a>. Note that the instance types offered may vary depending on
        /// the region.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEC2InstanceLimits service method.</param>
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
        Task<DescribeEC2InstanceLimitsResponse> DescribeEC2InstanceLimitsAsync(DescribeEC2InstanceLimitsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFleetAttributes


        /// <summary>
        /// Retrieves core properties, including configuration, status, and metadata, for a fleet.
        /// 
        /// 
        ///  
        /// <para>
        /// To get attributes for one or more fleets, provide a list of fleet IDs or fleet ARNs.
        /// To get attributes for all fleets, do not specify a fleet identifier. When requesting
        /// attributes for multiple fleets, use the pagination parameters to retrieve results
        /// as a set of sequential pages. If successful, a <a>FleetAttributes</a> object is returned
        /// for each fleet requested, unless the fleet identifier is not found.
        /// </para>
        ///  <note> 
        /// <para>
        /// Some API operations may limit the number of fleet IDs allowed in one request. If a
        /// request exceeds this limit, the request fails and the error message includes the maximum
        /// allowed number.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetAttributes service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetAttributes">REST API Reference for DescribeFleetAttributes Operation</seealso>
        DescribeFleetAttributesResponse DescribeFleetAttributes(DescribeFleetAttributesRequest request);



        /// <summary>
        /// Retrieves core properties, including configuration, status, and metadata, for a fleet.
        /// 
        /// 
        ///  
        /// <para>
        /// To get attributes for one or more fleets, provide a list of fleet IDs or fleet ARNs.
        /// To get attributes for all fleets, do not specify a fleet identifier. When requesting
        /// attributes for multiple fleets, use the pagination parameters to retrieve results
        /// as a set of sequential pages. If successful, a <a>FleetAttributes</a> object is returned
        /// for each fleet requested, unless the fleet identifier is not found.
        /// </para>
        ///  <note> 
        /// <para>
        /// Some API operations may limit the number of fleet IDs allowed in one request. If a
        /// request exceeds this limit, the request fails and the error message includes the maximum
        /// allowed number.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleetAttributes service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetAttributes">REST API Reference for DescribeFleetAttributes Operation</seealso>
        Task<DescribeFleetAttributesResponse> DescribeFleetAttributesAsync(DescribeFleetAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFleetCapacity


        /// <summary>
        /// Retrieves the current capacity statistics for one or more fleets. These statistics
        /// present a snapshot of the fleet's instances and provide insight on current or imminent
        /// scaling activity. To get statistics on game hosting activity in the fleet, see <a>DescribeFleetUtilization</a>.
        /// 
        ///  
        /// <para>
        /// You can request capacity for all fleets or specify a list of one or more fleet identifiers.
        /// When requesting multiple fleets, use the pagination parameters to retrieve results
        /// as a set of sequential pages. If successful, a <a>FleetCapacity</a> object is returned
        /// for each requested fleet ID. When a list of fleet IDs is provided, attribute objects
        /// are returned only for fleets that currently exist.
        /// </para>
        ///  <note> 
        /// <para>
        /// Some API operations may limit the number of fleet IDs allowed in one request. If a
        /// request exceeds this limit, the request fails and the error message includes the maximum
        /// allowed.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/monitoring-cloudwatch.html#gamelift-metrics-fleet">GameLift
        /// Metrics for Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetCapacity service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetCapacity service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetCapacity">REST API Reference for DescribeFleetCapacity Operation</seealso>
        DescribeFleetCapacityResponse DescribeFleetCapacity(DescribeFleetCapacityRequest request);



        /// <summary>
        /// Retrieves the current capacity statistics for one or more fleets. These statistics
        /// present a snapshot of the fleet's instances and provide insight on current or imminent
        /// scaling activity. To get statistics on game hosting activity in the fleet, see <a>DescribeFleetUtilization</a>.
        /// 
        ///  
        /// <para>
        /// You can request capacity for all fleets or specify a list of one or more fleet identifiers.
        /// When requesting multiple fleets, use the pagination parameters to retrieve results
        /// as a set of sequential pages. If successful, a <a>FleetCapacity</a> object is returned
        /// for each requested fleet ID. When a list of fleet IDs is provided, attribute objects
        /// are returned only for fleets that currently exist.
        /// </para>
        ///  <note> 
        /// <para>
        /// Some API operations may limit the number of fleet IDs allowed in one request. If a
        /// request exceeds this limit, the request fails and the error message includes the maximum
        /// allowed.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/monitoring-cloudwatch.html#gamelift-metrics-fleet">GameLift
        /// Metrics for Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetCapacity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleetCapacity service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetCapacity">REST API Reference for DescribeFleetCapacity Operation</seealso>
        Task<DescribeFleetCapacityResponse> DescribeFleetCapacityAsync(DescribeFleetCapacityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFleetEvents


        /// <summary>
        /// Retrieves entries from the specified fleet's event log. You can specify a time range
        /// to limit the result set. Use the pagination parameters to retrieve results as a set
        /// of sequential pages. If successful, a collection of event log entries matching the
        /// request are returned.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetEvents service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetEvents">REST API Reference for DescribeFleetEvents Operation</seealso>
        DescribeFleetEventsResponse DescribeFleetEvents(DescribeFleetEventsRequest request);



        /// <summary>
        /// Retrieves entries from the specified fleet's event log. You can specify a time range
        /// to limit the result set. Use the pagination parameters to retrieve results as a set
        /// of sequential pages. If successful, a collection of event log entries matching the
        /// request are returned.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleetEvents service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetEvents">REST API Reference for DescribeFleetEvents Operation</seealso>
        Task<DescribeFleetEventsResponse> DescribeFleetEventsAsync(DescribeFleetEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFleetPortSettings


        /// <summary>
        /// Retrieves a fleet's inbound connection permissions. Connection permissions specify
        /// the range of IP addresses and port settings that incoming traffic can use to access
        /// server processes in the fleet. Game sessions that are running on instances in the
        /// fleet use connections that fall in this range. 
        /// 
        ///  
        /// <para>
        /// To get a fleet's inbound connection permissions, specify the fleet's unique identifier.
        /// If successful, a collection of <a>IpPermission</a> objects is returned for the requested
        /// fleet ID. If the requested fleet has been deleted, the result set is empty.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="fleetId">A unique identifier for a fleet to retrieve port settings for. You can use either the fleet ID or ARN value.</param>
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
        DescribeFleetPortSettingsResponse DescribeFleetPortSettings(string fleetId);

        /// <summary>
        /// Retrieves a fleet's inbound connection permissions. Connection permissions specify
        /// the range of IP addresses and port settings that incoming traffic can use to access
        /// server processes in the fleet. Game sessions that are running on instances in the
        /// fleet use connections that fall in this range. 
        /// 
        ///  
        /// <para>
        /// To get a fleet's inbound connection permissions, specify the fleet's unique identifier.
        /// If successful, a collection of <a>IpPermission</a> objects is returned for the requested
        /// fleet ID. If the requested fleet has been deleted, the result set is empty.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetPortSettings service method.</param>
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
        DescribeFleetPortSettingsResponse DescribeFleetPortSettings(DescribeFleetPortSettingsRequest request);


        /// <summary>
        /// Retrieves a fleet's inbound connection permissions. Connection permissions specify
        /// the range of IP addresses and port settings that incoming traffic can use to access
        /// server processes in the fleet. Game sessions that are running on instances in the
        /// fleet use connections that fall in this range. 
        /// 
        ///  
        /// <para>
        /// To get a fleet's inbound connection permissions, specify the fleet's unique identifier.
        /// If successful, a collection of <a>IpPermission</a> objects is returned for the requested
        /// fleet ID. If the requested fleet has been deleted, the result set is empty.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="fleetId">A unique identifier for a fleet to retrieve port settings for. You can use either the fleet ID or ARN value.</param>
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
        /// Retrieves a fleet's inbound connection permissions. Connection permissions specify
        /// the range of IP addresses and port settings that incoming traffic can use to access
        /// server processes in the fleet. Game sessions that are running on instances in the
        /// fleet use connections that fall in this range. 
        /// 
        ///  
        /// <para>
        /// To get a fleet's inbound connection permissions, specify the fleet's unique identifier.
        /// If successful, a collection of <a>IpPermission</a> objects is returned for the requested
        /// fleet ID. If the requested fleet has been deleted, the result set is empty.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetPortSettings service method.</param>
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
        Task<DescribeFleetPortSettingsResponse> DescribeFleetPortSettingsAsync(DescribeFleetPortSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFleetUtilization


        /// <summary>
        /// Retrieves utilization statistics for one or more fleets. These statistics provide
        /// insight into how available hosting resources are currently being used. To get statistics
        /// on available hosting resources, see <a>DescribeFleetCapacity</a>.
        /// 
        ///  
        /// <para>
        /// You can request utilization data for all fleets, or specify a list of one or more
        /// fleet IDs. When requesting multiple fleets, use the pagination parameters to retrieve
        /// results as a set of sequential pages. If successful, a <a>FleetUtilization</a> object
        /// is returned for each requested fleet ID, unless the fleet identifier is not found.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// Some API operations may limit the number of fleet IDs allowed in one request. If a
        /// request exceeds this limit, the request fails and the error message includes the maximum
        /// allowed.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/monitoring-cloudwatch.html#gamelift-metrics-fleet">GameLift
        /// Metrics for Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetUtilization service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetUtilization service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetUtilization">REST API Reference for DescribeFleetUtilization Operation</seealso>
        DescribeFleetUtilizationResponse DescribeFleetUtilization(DescribeFleetUtilizationRequest request);



        /// <summary>
        /// Retrieves utilization statistics for one or more fleets. These statistics provide
        /// insight into how available hosting resources are currently being used. To get statistics
        /// on available hosting resources, see <a>DescribeFleetCapacity</a>.
        /// 
        ///  
        /// <para>
        /// You can request utilization data for all fleets, or specify a list of one or more
        /// fleet IDs. When requesting multiple fleets, use the pagination parameters to retrieve
        /// results as a set of sequential pages. If successful, a <a>FleetUtilization</a> object
        /// is returned for each requested fleet ID, unless the fleet identifier is not found.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// Some API operations may limit the number of fleet IDs allowed in one request. If a
        /// request exceeds this limit, the request fails and the error message includes the maximum
        /// allowed.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/monitoring-cloudwatch.html#gamelift-metrics-fleet">GameLift
        /// Metrics for Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetUtilization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleetUtilization service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetUtilization">REST API Reference for DescribeFleetUtilization Operation</seealso>
        Task<DescribeFleetUtilizationResponse> DescribeFleetUtilizationAsync(DescribeFleetUtilizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeGameServer


        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Retrieves information for a registered game server. Information includes game server
        /// status, health check info, and the instance that the game server is running on. 
        /// </para>
        ///  
        /// <para>
        /// To retrieve game server information, specify the game server ID. If successful, the
        /// requested game server object is returned. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RegisterGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ClaimGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeregisterGameServer</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameServer service method.</param>
        /// 
        /// <returns>The response from the DescribeGameServer service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameServer">REST API Reference for DescribeGameServer Operation</seealso>
        DescribeGameServerResponse DescribeGameServer(DescribeGameServerRequest request);



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Retrieves information for a registered game server. Information includes game server
        /// status, health check info, and the instance that the game server is running on. 
        /// </para>
        ///  
        /// <para>
        /// To retrieve game server information, specify the game server ID. If successful, the
        /// requested game server object is returned. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RegisterGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ClaimGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeregisterGameServer</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGameServer service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameServer">REST API Reference for DescribeGameServer Operation</seealso>
        Task<DescribeGameServerResponse> DescribeGameServerAsync(DescribeGameServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeGameServerGroup


        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Retrieves information on a game server group. This operation returns only properties
        /// related to GameLift FleetIQ. To view or update properties for the corresponding Auto
        /// Scaling group, such as launch template, auto scaling policies, and maximum/minimum
        /// group size, access the Auto Scaling group directly.
        /// </para>
        ///  
        /// <para>
        /// To get attributes for a game server group, provide a group name or ARN value. If successful,
        /// a <a>GameServerGroup</a> object is returned.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerInstances</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameServerGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeGameServerGroup service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameServerGroup">REST API Reference for DescribeGameServerGroup Operation</seealso>
        DescribeGameServerGroupResponse DescribeGameServerGroup(DescribeGameServerGroupRequest request);



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Retrieves information on a game server group. This operation returns only properties
        /// related to GameLift FleetIQ. To view or update properties for the corresponding Auto
        /// Scaling group, such as launch template, auto scaling policies, and maximum/minimum
        /// group size, access the Auto Scaling group directly.
        /// </para>
        ///  
        /// <para>
        /// To get attributes for a game server group, provide a group name or ARN value. If successful,
        /// a <a>GameServerGroup</a> object is returned.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerInstances</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameServerGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGameServerGroup service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameServerGroup">REST API Reference for DescribeGameServerGroup Operation</seealso>
        Task<DescribeGameServerGroupResponse> DescribeGameServerGroupAsync(DescribeGameServerGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeGameServerInstances


        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Retrieves status information about the Amazon EC2 instances associated with a GameLift
        /// FleetIQ game server group. Use this operation to detect when instances are active
        /// or not available to host new game servers. If you are looking for instance configuration
        /// information, call <a>DescribeGameServerGroup</a> or access the corresponding Auto
        /// Scaling group properties.
        /// </para>
        ///  
        /// <para>
        /// To request status for all instances in the game server group, provide a game server
        /// group ID only. To request status for specific instances, provide the game server group
        /// ID and one or more instance IDs. Use the pagination parameters to retrieve results
        /// in sequential segments. If successful, a collection of <code>GameServerInstance</code>
        /// objects is returned. 
        /// </para>
        ///  
        /// <para>
        /// This operation is not designed to be called with every game server claim request;
        /// this practice can cause you to exceed your API limit, which results in errors. Instead,
        /// as a best practice, cache the results and refresh your cache no more than once every
        /// 10 seconds.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerInstances</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameServerInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeGameServerInstances service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameServerInstances">REST API Reference for DescribeGameServerInstances Operation</seealso>
        DescribeGameServerInstancesResponse DescribeGameServerInstances(DescribeGameServerInstancesRequest request);



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Retrieves status information about the Amazon EC2 instances associated with a GameLift
        /// FleetIQ game server group. Use this operation to detect when instances are active
        /// or not available to host new game servers. If you are looking for instance configuration
        /// information, call <a>DescribeGameServerGroup</a> or access the corresponding Auto
        /// Scaling group properties.
        /// </para>
        ///  
        /// <para>
        /// To request status for all instances in the game server group, provide a game server
        /// group ID only. To request status for specific instances, provide the game server group
        /// ID and one or more instance IDs. Use the pagination parameters to retrieve results
        /// in sequential segments. If successful, a collection of <code>GameServerInstance</code>
        /// objects is returned. 
        /// </para>
        ///  
        /// <para>
        /// This operation is not designed to be called with every game server claim request;
        /// this practice can cause you to exceed your API limit, which results in errors. Instead,
        /// as a best practice, cache the results and refresh your cache no more than once every
        /// 10 seconds.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerInstances</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameServerInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGameServerInstances service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameServerInstances">REST API Reference for DescribeGameServerInstances Operation</seealso>
        Task<DescribeGameServerInstancesResponse> DescribeGameServerInstancesAsync(DescribeGameServerInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeGameSessionDetails


        /// <summary>
        /// Retrieves properties, including the protection policy in force, for one or more game
        /// sessions. This operation can be used in several ways: (1) provide a <code>GameSessionId</code>
        /// or <code>GameSessionArn</code> to request details for a specific game session; (2)
        /// provide either a <code>FleetId</code> or an <code>AliasId</code> to request properties
        /// for all game sessions running on a fleet. 
        /// 
        ///  
        /// <para>
        /// To get game session record(s), specify just one of the following: game session ID,
        /// fleet ID, or alias ID. You can filter this request by game session status. Use the
        /// pagination parameters to retrieve results as a set of sequential pages. If successful,
        /// a <a>GameSessionDetail</a> object is returned for each session matching the request.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessionDetails service method.</param>
        /// 
        /// <returns>The response from the DescribeGameSessionDetails service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionDetails">REST API Reference for DescribeGameSessionDetails Operation</seealso>
        DescribeGameSessionDetailsResponse DescribeGameSessionDetails(DescribeGameSessionDetailsRequest request);



        /// <summary>
        /// Retrieves properties, including the protection policy in force, for one or more game
        /// sessions. This operation can be used in several ways: (1) provide a <code>GameSessionId</code>
        /// or <code>GameSessionArn</code> to request details for a specific game session; (2)
        /// provide either a <code>FleetId</code> or an <code>AliasId</code> to request properties
        /// for all game sessions running on a fleet. 
        /// 
        ///  
        /// <para>
        /// To get game session record(s), specify just one of the following: game session ID,
        /// fleet ID, or alias ID. You can filter this request by game session status. Use the
        /// pagination parameters to retrieve results as a set of sequential pages. If successful,
        /// a <a>GameSessionDetail</a> object is returned for each session matching the request.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessionDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGameSessionDetails service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionDetails">REST API Reference for DescribeGameSessionDetails Operation</seealso>
        Task<DescribeGameSessionDetailsResponse> DescribeGameSessionDetailsAsync(DescribeGameSessionDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeGameSessionPlacement


        /// <summary>
        /// Retrieves properties and current status of a game session placement request. To get
        /// game session placement details, specify the placement ID. If successful, a <a>GameSessionPlacement</a>
        /// object is returned.
        /// 
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessionPlacement service method.</param>
        /// 
        /// <returns>The response from the DescribeGameSessionPlacement service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionPlacement">REST API Reference for DescribeGameSessionPlacement Operation</seealso>
        DescribeGameSessionPlacementResponse DescribeGameSessionPlacement(DescribeGameSessionPlacementRequest request);



        /// <summary>
        /// Retrieves properties and current status of a game session placement request. To get
        /// game session placement details, specify the placement ID. If successful, a <a>GameSessionPlacement</a>
        /// object is returned.
        /// 
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessionPlacement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGameSessionPlacement service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionPlacement">REST API Reference for DescribeGameSessionPlacement Operation</seealso>
        Task<DescribeGameSessionPlacementResponse> DescribeGameSessionPlacementAsync(DescribeGameSessionPlacementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeGameSessionQueues


        /// <summary>
        /// Retrieves the properties for one or more game session queues. When requesting multiple
        /// queues, use the pagination parameters to retrieve results as a set of sequential pages.
        /// If successful, a <a>GameSessionQueue</a> object is returned for each requested queue.
        /// When specifying a list of queues, objects are returned only for queues that currently
        /// exist in the Region.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-console.html">
        /// View Your Queues</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionQueues</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameSessionQueue</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessionQueues service method.</param>
        /// 
        /// <returns>The response from the DescribeGameSessionQueues service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionQueues">REST API Reference for DescribeGameSessionQueues Operation</seealso>
        DescribeGameSessionQueuesResponse DescribeGameSessionQueues(DescribeGameSessionQueuesRequest request);



        /// <summary>
        /// Retrieves the properties for one or more game session queues. When requesting multiple
        /// queues, use the pagination parameters to retrieve results as a set of sequential pages.
        /// If successful, a <a>GameSessionQueue</a> object is returned for each requested queue.
        /// When specifying a list of queues, objects are returned only for queues that currently
        /// exist in the Region.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-console.html">
        /// View Your Queues</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionQueues</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameSessionQueue</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessionQueues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGameSessionQueues service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionQueues">REST API Reference for DescribeGameSessionQueues Operation</seealso>
        Task<DescribeGameSessionQueuesResponse> DescribeGameSessionQueuesAsync(DescribeGameSessionQueuesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeGameSessions


        /// <summary>
        /// Retrieves a set of one or more game sessions. Request a specific game session or request
        /// all game sessions on a fleet. Alternatively, use <a>SearchGameSessions</a> to request
        /// a set of active game sessions that are filtered by certain criteria. To retrieve protection
        /// policy settings for game sessions, use <a>DescribeGameSessionDetails</a>.
        /// 
        ///  
        /// <para>
        /// To get game sessions, specify one of the following: game session ID, fleet ID, or
        /// alias ID. You can filter this request by game session status. Use the pagination parameters
        /// to retrieve results as a set of sequential pages. If successful, a <a>GameSession</a>
        /// object is returned for each game session matching the request.
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessions service method.</param>
        /// 
        /// <returns>The response from the DescribeGameSessions service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessions">REST API Reference for DescribeGameSessions Operation</seealso>
        DescribeGameSessionsResponse DescribeGameSessions(DescribeGameSessionsRequest request);



        /// <summary>
        /// Retrieves a set of one or more game sessions. Request a specific game session or request
        /// all game sessions on a fleet. Alternatively, use <a>SearchGameSessions</a> to request
        /// a set of active game sessions that are filtered by certain criteria. To retrieve protection
        /// policy settings for game sessions, use <a>DescribeGameSessionDetails</a>.
        /// 
        ///  
        /// <para>
        /// To get game sessions, specify one of the following: game session ID, fleet ID, or
        /// alias ID. You can filter this request by game session status. Use the pagination parameters
        /// to retrieve results as a set of sequential pages. If successful, a <a>GameSession</a>
        /// object is returned for each game session matching the request.
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGameSessions service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessions">REST API Reference for DescribeGameSessions Operation</seealso>
        Task<DescribeGameSessionsResponse> DescribeGameSessionsAsync(DescribeGameSessionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeInstances


        /// <summary>
        /// Retrieves information about a fleet's instances, including instance IDs. Use this
        /// operation to get details on all instances in the fleet or get details on one specific
        /// instance.
        /// 
        ///  
        /// <para>
        /// To get a specific instance, specify fleet ID and instance ID. To get all instances
        /// in a fleet, specify a fleet ID only. Use the pagination parameters to retrieve results
        /// as a set of sequential pages. If successful, an <a>Instance</a> object is returned
        /// for each result.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-remote-access.html">Remotely
        /// Access Fleet Instances</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-debug.html">Debug
        /// Fleet Issues</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeInstances</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetInstanceAccess</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request);



        /// <summary>
        /// Retrieves information about a fleet's instances, including instance IDs. Use this
        /// operation to get details on all instances in the fleet or get details on one specific
        /// instance.
        /// 
        ///  
        /// <para>
        /// To get a specific instance, specify fleet ID and instance ID. To get all instances
        /// in a fleet, specify a fleet ID only. Use the pagination parameters to retrieve results
        /// as a set of sequential pages. If successful, an <a>Instance</a> object is returned
        /// for each result.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-remote-access.html">Remotely
        /// Access Fleet Instances</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-debug.html">Debug
        /// Fleet Issues</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeInstances</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetInstanceAccess</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMatchmaking


        /// <summary>
        /// Retrieves one or more matchmaking tickets. Use this operation to retrieve ticket information,
        /// including--after a successful match is made--connection information for the resulting
        /// new game session. 
        /// 
        ///  
        /// <para>
        /// To request matchmaking tickets, provide a list of up to 10 ticket IDs. If the request
        /// is successful, a ticket object is returned for each requested ID that currently exists.
        /// </para>
        ///  
        /// <para>
        /// This operation is not designed to be continually called to track matchmaking ticket
        /// status. This practice can cause you to exceed your API limit, which results in errors.
        /// Instead, as a best practice, set up an Amazon Simple Notification Service (SNS) to
        /// receive notifications, and provide the topic ARN in the matchmaking configuration.
        /// Continuously poling ticket status with <a>DescribeMatchmaking</a> should only be used
        /// for games in development with low matchmaking usage.
        /// </para>
        ///   
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-client.html">
        /// Add FlexMatch to a Game Client</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-notification.html">
        /// Set Up FlexMatch Event Notification</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AcceptMatch</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartMatchBackfill</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMatchmaking service method.</param>
        /// 
        /// <returns>The response from the DescribeMatchmaking service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmaking">REST API Reference for DescribeMatchmaking Operation</seealso>
        DescribeMatchmakingResponse DescribeMatchmaking(DescribeMatchmakingRequest request);



        /// <summary>
        /// Retrieves one or more matchmaking tickets. Use this operation to retrieve ticket information,
        /// including--after a successful match is made--connection information for the resulting
        /// new game session. 
        /// 
        ///  
        /// <para>
        /// To request matchmaking tickets, provide a list of up to 10 ticket IDs. If the request
        /// is successful, a ticket object is returned for each requested ID that currently exists.
        /// </para>
        ///  
        /// <para>
        /// This operation is not designed to be continually called to track matchmaking ticket
        /// status. This practice can cause you to exceed your API limit, which results in errors.
        /// Instead, as a best practice, set up an Amazon Simple Notification Service (SNS) to
        /// receive notifications, and provide the topic ARN in the matchmaking configuration.
        /// Continuously poling ticket status with <a>DescribeMatchmaking</a> should only be used
        /// for games in development with low matchmaking usage.
        /// </para>
        ///   
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-client.html">
        /// Add FlexMatch to a Game Client</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-notification.html">
        /// Set Up FlexMatch Event Notification</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AcceptMatch</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartMatchBackfill</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMatchmaking service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMatchmaking service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmaking">REST API Reference for DescribeMatchmaking Operation</seealso>
        Task<DescribeMatchmakingResponse> DescribeMatchmakingAsync(DescribeMatchmakingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMatchmakingConfigurations


        /// <summary>
        /// Retrieves the details of FlexMatch matchmaking configurations. 
        /// 
        ///  
        /// <para>
        /// This operation offers the following options: (1) retrieve all matchmaking configurations,
        /// (2) retrieve configurations for a specified list, or (3) retrieve all configurations
        /// that use a specified rule set name. When requesting multiple items, use the pagination
        /// parameters to retrieve results as a set of sequential pages. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a configuration is returned for each requested name. When specifying
        /// a list of names, only configurations that currently exist are returned. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/matchmaker-build.html">
        /// Setting Up FlexMatch Matchmakers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMatchmakingConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeMatchmakingConfigurations service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmakingConfigurations">REST API Reference for DescribeMatchmakingConfigurations Operation</seealso>
        DescribeMatchmakingConfigurationsResponse DescribeMatchmakingConfigurations(DescribeMatchmakingConfigurationsRequest request);



        /// <summary>
        /// Retrieves the details of FlexMatch matchmaking configurations. 
        /// 
        ///  
        /// <para>
        /// This operation offers the following options: (1) retrieve all matchmaking configurations,
        /// (2) retrieve configurations for a specified list, or (3) retrieve all configurations
        /// that use a specified rule set name. When requesting multiple items, use the pagination
        /// parameters to retrieve results as a set of sequential pages. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a configuration is returned for each requested name. When specifying
        /// a list of names, only configurations that currently exist are returned. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/matchmaker-build.html">
        /// Setting Up FlexMatch Matchmakers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMatchmakingConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMatchmakingConfigurations service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmakingConfigurations">REST API Reference for DescribeMatchmakingConfigurations Operation</seealso>
        Task<DescribeMatchmakingConfigurationsResponse> DescribeMatchmakingConfigurationsAsync(DescribeMatchmakingConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMatchmakingRuleSets


        /// <summary>
        /// Retrieves the details for FlexMatch matchmaking rule sets. You can request all existing
        /// rule sets for the Region, or provide a list of one or more rule set names. When requesting
        /// multiple items, use the pagination parameters to retrieve results as a set of sequential
        /// pages. If successful, a rule set is returned for each requested name. 
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-rulesets.html">Build
        /// a Rule Set</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMatchmakingRuleSets service method.</param>
        /// 
        /// <returns>The response from the DescribeMatchmakingRuleSets service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmakingRuleSets">REST API Reference for DescribeMatchmakingRuleSets Operation</seealso>
        DescribeMatchmakingRuleSetsResponse DescribeMatchmakingRuleSets(DescribeMatchmakingRuleSetsRequest request);



        /// <summary>
        /// Retrieves the details for FlexMatch matchmaking rule sets. You can request all existing
        /// rule sets for the Region, or provide a list of one or more rule set names. When requesting
        /// multiple items, use the pagination parameters to retrieve results as a set of sequential
        /// pages. If successful, a rule set is returned for each requested name. 
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-rulesets.html">Build
        /// a Rule Set</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMatchmakingRuleSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMatchmakingRuleSets service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmakingRuleSets">REST API Reference for DescribeMatchmakingRuleSets Operation</seealso>
        Task<DescribeMatchmakingRuleSetsResponse> DescribeMatchmakingRuleSetsAsync(DescribeMatchmakingRuleSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePlayerSessions


        /// <summary>
        /// Retrieves properties for one or more player sessions. This operation can be used in
        /// several ways: (1) provide a <code>PlayerSessionId</code> to request properties for
        /// a specific player session; (2) provide a <code>GameSessionId</code> to request properties
        /// for all player sessions in the specified game session; (3) provide a <code>PlayerId</code>
        /// to request properties for all player sessions of a specified player. 
        /// 
        ///  
        /// <para>
        /// To get game session record(s), specify only one of the following: a player session
        /// ID, a game session ID, or a player ID. You can filter this request by player session
        /// status. Use the pagination parameters to retrieve results as a set of sequential pages.
        /// If successful, a <a>PlayerSession</a> object is returned for each session matching
        /// the request.
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
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
        /// <param name="request">Container for the necessary parameters to execute the DescribePlayerSessions service method.</param>
        /// 
        /// <returns>The response from the DescribePlayerSessions service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribePlayerSessions">REST API Reference for DescribePlayerSessions Operation</seealso>
        DescribePlayerSessionsResponse DescribePlayerSessions(DescribePlayerSessionsRequest request);



        /// <summary>
        /// Retrieves properties for one or more player sessions. This operation can be used in
        /// several ways: (1) provide a <code>PlayerSessionId</code> to request properties for
        /// a specific player session; (2) provide a <code>GameSessionId</code> to request properties
        /// for all player sessions in the specified game session; (3) provide a <code>PlayerId</code>
        /// to request properties for all player sessions of a specified player. 
        /// 
        ///  
        /// <para>
        /// To get game session record(s), specify only one of the following: a player session
        /// ID, a game session ID, or a player ID. You can filter this request by player session
        /// status. Use the pagination parameters to retrieve results as a set of sequential pages.
        /// If successful, a <a>PlayerSession</a> object is returned for each session matching
        /// the request.
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
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
        /// <param name="request">Container for the necessary parameters to execute the DescribePlayerSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePlayerSessions service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribePlayerSessions">REST API Reference for DescribePlayerSessions Operation</seealso>
        Task<DescribePlayerSessionsResponse> DescribePlayerSessionsAsync(DescribePlayerSessionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRuntimeConfiguration


        /// <summary>
        /// Retrieves a fleet's runtime configuration settings. The runtime configuration tells
        /// Amazon GameLift which server processes to run (and how) on each instance in the fleet.
        /// 
        ///  
        /// <para>
        /// To get a runtime configuration, specify the fleet's unique identifier. If successful,
        /// a <a>RuntimeConfiguration</a> object is returned for the requested fleet. If the requested
        /// fleet has been deleted, the result set is empty.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-multiprocess.html">Running
        /// Multiple Processes on a Fleet</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuntimeConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeRuntimeConfiguration service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeRuntimeConfiguration">REST API Reference for DescribeRuntimeConfiguration Operation</seealso>
        DescribeRuntimeConfigurationResponse DescribeRuntimeConfiguration(DescribeRuntimeConfigurationRequest request);



        /// <summary>
        /// Retrieves a fleet's runtime configuration settings. The runtime configuration tells
        /// Amazon GameLift which server processes to run (and how) on each instance in the fleet.
        /// 
        ///  
        /// <para>
        /// To get a runtime configuration, specify the fleet's unique identifier. If successful,
        /// a <a>RuntimeConfiguration</a> object is returned for the requested fleet. If the requested
        /// fleet has been deleted, the result set is empty.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-multiprocess.html">Running
        /// Multiple Processes on a Fleet</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuntimeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRuntimeConfiguration service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeRuntimeConfiguration">REST API Reference for DescribeRuntimeConfiguration Operation</seealso>
        Task<DescribeRuntimeConfigurationResponse> DescribeRuntimeConfigurationAsync(DescribeRuntimeConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeScalingPolicies


        /// <summary>
        /// Retrieves all scaling policies applied to a fleet.
        /// 
        ///  
        /// <para>
        /// To get a fleet's scaling policies, specify the fleet ID. You can filter this request
        /// by policy status, such as to retrieve only active scaling policies. Use the pagination
        /// parameters to retrieve results as a set of sequential pages. If successful, set of
        /// <a>ScalingPolicy</a> objects is returned for the fleet.
        /// </para>
        ///  
        /// <para>
        /// A fleet may have all of its scaling policies suspended (<a>StopFleetActions</a>).
        /// This operation does not affect the status of the scaling policies, which remains ACTIVE.
        /// To see whether a fleet's scaling policies are in force or suspended, call <a>DescribeFleetAttributes</a>
        /// and check the stopped actions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Manage scaling policies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutScalingPolicy</a> (auto-scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScalingPolicies</a> (auto-scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScalingPolicy</a> (auto-scaling)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPolicies service method.</param>
        /// 
        /// <returns>The response from the DescribeScalingPolicies service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeScalingPolicies">REST API Reference for DescribeScalingPolicies Operation</seealso>
        DescribeScalingPoliciesResponse DescribeScalingPolicies(DescribeScalingPoliciesRequest request);



        /// <summary>
        /// Retrieves all scaling policies applied to a fleet.
        /// 
        ///  
        /// <para>
        /// To get a fleet's scaling policies, specify the fleet ID. You can filter this request
        /// by policy status, such as to retrieve only active scaling policies. Use the pagination
        /// parameters to retrieve results as a set of sequential pages. If successful, set of
        /// <a>ScalingPolicy</a> objects is returned for the fleet.
        /// </para>
        ///  
        /// <para>
        /// A fleet may have all of its scaling policies suspended (<a>StopFleetActions</a>).
        /// This operation does not affect the status of the scaling policies, which remains ACTIVE.
        /// To see whether a fleet's scaling policies are in force or suspended, call <a>DescribeFleetAttributes</a>
        /// and check the stopped actions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Manage scaling policies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutScalingPolicy</a> (auto-scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScalingPolicies</a> (auto-scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScalingPolicy</a> (auto-scaling)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScalingPolicies service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeScalingPolicies">REST API Reference for DescribeScalingPolicies Operation</seealso>
        Task<DescribeScalingPoliciesResponse> DescribeScalingPoliciesAsync(DescribeScalingPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeScript


        /// <summary>
        /// Retrieves properties for a Realtime script. 
        /// 
        ///  
        /// <para>
        /// To request a script record, specify the script ID. If successful, an object containing
        /// the script properties is returned.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
        /// GameLift Realtime Servers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListScripts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScript</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScript service method.</param>
        /// 
        /// <returns>The response from the DescribeScript service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeScript">REST API Reference for DescribeScript Operation</seealso>
        DescribeScriptResponse DescribeScript(DescribeScriptRequest request);



        /// <summary>
        /// Retrieves properties for a Realtime script. 
        /// 
        ///  
        /// <para>
        /// To request a script record, specify the script ID. If successful, an object containing
        /// the script properties is returned.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
        /// GameLift Realtime Servers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListScripts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScript</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScript service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScript service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeScript">REST API Reference for DescribeScript Operation</seealso>
        Task<DescribeScriptResponse> DescribeScriptAsync(DescribeScriptRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeVpcPeeringAuthorizations


        /// <summary>
        /// Retrieves valid VPC peering authorizations that are pending for the AWS account. This
        /// operation returns all VPC peering authorizations and requests for peering. This includes
        /// those initiated and received by this account. 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringAuthorizations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringConnection</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringConnections</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringConnection</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringAuthorizations service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcPeeringAuthorizations service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeVpcPeeringAuthorizations">REST API Reference for DescribeVpcPeeringAuthorizations Operation</seealso>
        DescribeVpcPeeringAuthorizationsResponse DescribeVpcPeeringAuthorizations(DescribeVpcPeeringAuthorizationsRequest request);



        /// <summary>
        /// Retrieves valid VPC peering authorizations that are pending for the AWS account. This
        /// operation returns all VPC peering authorizations and requests for peering. This includes
        /// those initiated and received by this account. 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringAuthorizations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringConnection</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringConnections</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringConnection</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringAuthorizations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcPeeringAuthorizations service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeVpcPeeringAuthorizations">REST API Reference for DescribeVpcPeeringAuthorizations Operation</seealso>
        Task<DescribeVpcPeeringAuthorizationsResponse> DescribeVpcPeeringAuthorizationsAsync(DescribeVpcPeeringAuthorizationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeVpcPeeringConnections


        /// <summary>
        /// Retrieves information on VPC peering connections. Use this operation to get peering
        /// information for all fleets or for one specific fleet ID. 
        /// 
        ///  
        /// <para>
        /// To retrieve connection information, call this operation from the AWS account that
        /// is used to manage the Amazon GameLift fleets. Specify a fleet ID or leave the parameter
        /// empty to retrieve all connection records. If successful, the retrieved information
        /// includes both active and pending connections. Active connections identify the IpV4
        /// CIDR block that the VPC uses to connect. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringAuthorizations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringConnection</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringConnections</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringConnection</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcPeeringConnections service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request);



        /// <summary>
        /// Retrieves information on VPC peering connections. Use this operation to get peering
        /// information for all fleets or for one specific fleet ID. 
        /// 
        ///  
        /// <para>
        /// To retrieve connection information, call this operation from the AWS account that
        /// is used to manage the Amazon GameLift fleets. Specify a fleet ID or leave the parameter
        /// empty to retrieve all connection records. If successful, the retrieved information
        /// includes both active and pending connections. Active connections identify the IpV4
        /// CIDR block that the VPC uses to connect. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringAuthorizations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringAuthorization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateVpcPeeringConnection</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeVpcPeeringConnections</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteVpcPeeringConnection</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcPeeringConnections service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        Task<DescribeVpcPeeringConnectionsResponse> DescribeVpcPeeringConnectionsAsync(DescribeVpcPeeringConnectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetGameSessionLogUrl


        /// <summary>
        /// Retrieves the location of stored game session logs for a specified game session. When
        /// a game session is terminated, Amazon GameLift automatically stores the logs in Amazon
        /// S3 and retains them for 14 days. Use this URL to download the logs.
        /// 
        ///  <note> 
        /// <para>
        /// See the <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_gamelift">AWS
        /// Service Limits</a> page for maximum log file sizes. Log files that exceed this limit
        /// are not saved.
        /// </para>
        ///  </note> <ul> <li> 
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
        /// <param name="gameSessionId">A unique identifier for the game session to get logs for. </param>
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
        GetGameSessionLogUrlResponse GetGameSessionLogUrl(string gameSessionId);

        /// <summary>
        /// Retrieves the location of stored game session logs for a specified game session. When
        /// a game session is terminated, Amazon GameLift automatically stores the logs in Amazon
        /// S3 and retains them for 14 days. Use this URL to download the logs.
        /// 
        ///  <note> 
        /// <para>
        /// See the <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_gamelift">AWS
        /// Service Limits</a> page for maximum log file sizes. Log files that exceed this limit
        /// are not saved.
        /// </para>
        ///  </note> <ul> <li> 
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
        /// <param name="request">Container for the necessary parameters to execute the GetGameSessionLogUrl service method.</param>
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
        GetGameSessionLogUrlResponse GetGameSessionLogUrl(GetGameSessionLogUrlRequest request);


        /// <summary>
        /// Retrieves the location of stored game session logs for a specified game session. When
        /// a game session is terminated, Amazon GameLift automatically stores the logs in Amazon
        /// S3 and retains them for 14 days. Use this URL to download the logs.
        /// 
        ///  <note> 
        /// <para>
        /// See the <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_gamelift">AWS
        /// Service Limits</a> page for maximum log file sizes. Log files that exceed this limit
        /// are not saved.
        /// </para>
        ///  </note> <ul> <li> 
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
        /// <param name="gameSessionId">A unique identifier for the game session to get logs for. </param>
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
        /// Retrieves the location of stored game session logs for a specified game session. When
        /// a game session is terminated, Amazon GameLift automatically stores the logs in Amazon
        /// S3 and retains them for 14 days. Use this URL to download the logs.
        /// 
        ///  <note> 
        /// <para>
        /// See the <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_gamelift">AWS
        /// Service Limits</a> page for maximum log file sizes. Log files that exceed this limit
        /// are not saved.
        /// </para>
        ///  </note> <ul> <li> 
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
        /// <param name="request">Container for the necessary parameters to execute the GetGameSessionLogUrl service method.</param>
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
        Task<GetGameSessionLogUrlResponse> GetGameSessionLogUrlAsync(GetGameSessionLogUrlRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInstanceAccess


        /// <summary>
        /// Requests remote access to a fleet instance. Remote access is useful for debugging,
        /// gathering benchmarking data, or observing activity in real time. 
        /// 
        ///  
        /// <para>
        /// To remotely access an instance, you need credentials that match the operating system
        /// of the instance. For a Windows instance, Amazon GameLift returns a user name and password
        /// as strings for use with a Windows Remote Desktop client. For a Linux instance, Amazon
        /// GameLift returns a user name and RSA private key, also as strings, for use with an
        /// SSH client. The private key must be saved in the proper format to a <code>.pem</code>
        /// file before using. If you're making this request using the AWS CLI, saving the secret
        /// can be handled as part of the GetInstanceAccess request, as shown in one of the examples
        /// for this operation. 
        /// </para>
        ///  
        /// <para>
        /// To request access to a specific instance, specify the IDs of both the instance and
        /// the fleet it belongs to. You can retrieve a fleet's instance IDs by calling <a>DescribeInstances</a>.
        /// If successful, an <a>InstanceAccess</a> object is returned that contains the instance's
        /// IP address and a set of credentials.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-remote-access.html">Remotely
        /// Access Fleet Instances</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-debug.html">Debug
        /// Fleet Issues</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeInstances</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetInstanceAccess</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceAccess service method.</param>
        /// 
        /// <returns>The response from the GetInstanceAccess service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetInstanceAccess">REST API Reference for GetInstanceAccess Operation</seealso>
        GetInstanceAccessResponse GetInstanceAccess(GetInstanceAccessRequest request);



        /// <summary>
        /// Requests remote access to a fleet instance. Remote access is useful for debugging,
        /// gathering benchmarking data, or observing activity in real time. 
        /// 
        ///  
        /// <para>
        /// To remotely access an instance, you need credentials that match the operating system
        /// of the instance. For a Windows instance, Amazon GameLift returns a user name and password
        /// as strings for use with a Windows Remote Desktop client. For a Linux instance, Amazon
        /// GameLift returns a user name and RSA private key, also as strings, for use with an
        /// SSH client. The private key must be saved in the proper format to a <code>.pem</code>
        /// file before using. If you're making this request using the AWS CLI, saving the secret
        /// can be handled as part of the GetInstanceAccess request, as shown in one of the examples
        /// for this operation. 
        /// </para>
        ///  
        /// <para>
        /// To request access to a specific instance, specify the IDs of both the instance and
        /// the fleet it belongs to. You can retrieve a fleet's instance IDs by calling <a>DescribeInstances</a>.
        /// If successful, an <a>InstanceAccess</a> object is returned that contains the instance's
        /// IP address and a set of credentials.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-remote-access.html">Remotely
        /// Access Fleet Instances</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-debug.html">Debug
        /// Fleet Issues</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeInstances</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetInstanceAccess</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInstanceAccess service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetInstanceAccess">REST API Reference for GetInstanceAccess Operation</seealso>
        Task<GetInstanceAccessResponse> GetInstanceAccessAsync(GetInstanceAccessRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAliases


        /// <summary>
        /// Retrieves all aliases for this AWS account. You can filter the result set by alias
        /// name and/or routing strategy type. Use the pagination parameters to retrieve results
        /// in sequential pages.
        /// 
        ///  <note> 
        /// <para>
        /// Returned aliases are not listed in any particular order.
        /// </para>
        ///  </note> <ul> <li> 
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
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        ListAliasesResponse ListAliases(ListAliasesRequest request);



        /// <summary>
        /// Retrieves all aliases for this AWS account. You can filter the result set by alias
        /// name and/or routing strategy type. Use the pagination parameters to retrieve results
        /// in sequential pages.
        /// 
        ///  <note> 
        /// <para>
        /// Returned aliases are not listed in any particular order.
        /// </para>
        ///  </note> <ul> <li> 
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
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListBuilds


        /// <summary>
        /// Retrieves build resources for all builds associated with the AWS account in use. You
        /// can limit results to builds that are in a specific status by using the <code>Status</code>
        /// parameter. Use the pagination parameters to retrieve results in a set of sequential
        /// pages. 
        /// 
        ///  <note> 
        /// <para>
        /// Build resources are not listed in any particular order.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">
        /// Upload a Custom Server Build</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        /// <param name="request">Container for the necessary parameters to execute the ListBuilds service method.</param>
        /// 
        /// <returns>The response from the ListBuilds service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListBuilds">REST API Reference for ListBuilds Operation</seealso>
        ListBuildsResponse ListBuilds(ListBuildsRequest request);



        /// <summary>
        /// Retrieves build resources for all builds associated with the AWS account in use. You
        /// can limit results to builds that are in a specific status by using the <code>Status</code>
        /// parameter. Use the pagination parameters to retrieve results in a set of sequential
        /// pages. 
        /// 
        ///  <note> 
        /// <para>
        /// Build resources are not listed in any particular order.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">
        /// Upload a Custom Server Build</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        /// <param name="request">Container for the necessary parameters to execute the ListBuilds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBuilds service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListBuilds">REST API Reference for ListBuilds Operation</seealso>
        Task<ListBuildsResponse> ListBuildsAsync(ListBuildsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFleets


        /// <summary>
        /// Retrieves a collection of fleet resources for this AWS account. You can filter the
        /// result set to find only those fleets that are deployed with a specific build or script.
        /// Use the pagination parameters to retrieve results in sequential pages.
        /// 
        ///  <note> 
        /// <para>
        /// Fleet resources are not listed in a particular order.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleets service method.</param>
        /// 
        /// <returns>The response from the ListFleets service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListFleets">REST API Reference for ListFleets Operation</seealso>
        ListFleetsResponse ListFleets(ListFleetsRequest request);



        /// <summary>
        /// Retrieves a collection of fleet resources for this AWS account. You can filter the
        /// result set to find only those fleets that are deployed with a specific build or script.
        /// Use the pagination parameters to retrieve results in sequential pages.
        /// 
        ///  <note> 
        /// <para>
        /// Fleet resources are not listed in a particular order.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFleets service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListFleets">REST API Reference for ListFleets Operation</seealso>
        Task<ListFleetsResponse> ListFleetsAsync(ListFleetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGameServerGroups


        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Retrieves information on all game servers groups that exist in the current AWS account
        /// for the selected Region. Use the pagination parameters to retrieve results in a set
        /// of sequential segments. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerInstances</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGameServerGroups service method.</param>
        /// 
        /// <returns>The response from the ListGameServerGroups service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListGameServerGroups">REST API Reference for ListGameServerGroups Operation</seealso>
        ListGameServerGroupsResponse ListGameServerGroups(ListGameServerGroupsRequest request);



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Retrieves information on all game servers groups that exist in the current AWS account
        /// for the selected Region. Use the pagination parameters to retrieve results in a set
        /// of sequential segments. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerInstances</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGameServerGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGameServerGroups service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListGameServerGroups">REST API Reference for ListGameServerGroups Operation</seealso>
        Task<ListGameServerGroupsResponse> ListGameServerGroupsAsync(ListGameServerGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGameServers


        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Retrieves information on all game servers that are currently active in a specified
        /// game server group. You can opt to sort the list by game server age. Use the pagination
        /// parameters to retrieve results in a set of sequential segments. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RegisterGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ClaimGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeregisterGameServer</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGameServers service method.</param>
        /// 
        /// <returns>The response from the ListGameServers service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListGameServers">REST API Reference for ListGameServers Operation</seealso>
        ListGameServersResponse ListGameServers(ListGameServersRequest request);



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Retrieves information on all game servers that are currently active in a specified
        /// game server group. You can opt to sort the list by game server age. Use the pagination
        /// parameters to retrieve results in a set of sequential segments. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RegisterGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ClaimGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeregisterGameServer</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGameServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGameServers service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListGameServers">REST API Reference for ListGameServers Operation</seealso>
        Task<ListGameServersResponse> ListGameServersAsync(ListGameServersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListScripts


        /// <summary>
        /// Retrieves script records for all Realtime scripts that are associated with the AWS
        /// account in use. 
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
        /// GameLift Realtime Servers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListScripts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScript</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScripts service method.</param>
        /// 
        /// <returns>The response from the ListScripts service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListScripts">REST API Reference for ListScripts Operation</seealso>
        ListScriptsResponse ListScripts(ListScriptsRequest request);



        /// <summary>
        /// Retrieves script records for all Realtime scripts that are associated with the AWS
        /// account in use. 
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
        /// GameLift Realtime Servers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListScripts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScript</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScripts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListScripts service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListScripts">REST API Reference for ListScripts Operation</seealso>
        Task<ListScriptsResponse> ListScriptsAsync(ListScriptsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves all tags that are assigned to a GameLift resource. Resource tags are used
        /// to organize AWS resources for a range of purposes. This operation handles the permissions
        /// necessary to manage tags for the following GameLift resource types:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Build
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Script
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Fleet
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GameSessionQueue
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MatchmakingConfiguration
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MatchmakingRuleSet
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To list tags for a resource, specify the unique ARN value for the resource.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// AWS Resources</a> in the <i>AWS General Reference</i> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="http://aws.amazon.com/answers/account-management/aws-tagging-strategies/">
        /// AWS Tagging Strategies</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>TagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UntagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListTagsForResource</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Retrieves all tags that are assigned to a GameLift resource. Resource tags are used
        /// to organize AWS resources for a range of purposes. This operation handles the permissions
        /// necessary to manage tags for the following GameLift resource types:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Build
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Script
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Fleet
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GameSessionQueue
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MatchmakingConfiguration
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MatchmakingRuleSet
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To list tags for a resource, specify the unique ARN value for the resource.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// AWS Resources</a> in the <i>AWS General Reference</i> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="http://aws.amazon.com/answers/account-management/aws-tagging-strategies/">
        /// AWS Tagging Strategies</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>TagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UntagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListTagsForResource</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutScalingPolicy


        /// <summary>
        /// Creates or updates a scaling policy for a fleet. Scaling policies are used to automatically
        /// scale a fleet's hosting capacity to meet player demand. An active scaling policy instructs
        /// Amazon GameLift to track a fleet metric and automatically change the fleet's capacity
        /// when a certain threshold is reached. There are two types of scaling policies: target-based
        /// and rule-based. Use a target-based policy to quickly and efficiently manage fleet
        /// scaling; this option is the most commonly used. Use rule-based policies when you need
        /// to exert fine-grained control over auto-scaling. 
        /// 
        ///  
        /// <para>
        /// Fleets can have multiple scaling policies of each type in force at the same time;
        /// you can have one target-based policy, one or multiple rule-based scaling policies,
        /// or both. We recommend caution, however, because multiple auto-scaling policies can
        /// have unintended consequences.
        /// </para>
        ///  
        /// <para>
        /// You can temporarily suspend all scaling policies for a fleet by calling <a>StopFleetActions</a>
        /// with the fleet action AUTO_SCALING. To resume scaling policies, call <a>StartFleetActions</a>
        /// with the same fleet action. To stop just one scaling policy--or to permanently remove
        /// it, you must delete the policy with <a>DeleteScalingPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// Learn more about how to work with auto-scaling in <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-autoscaling.html">Set
        /// Up Fleet Automatic Scaling</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Target-based policy</b> 
        /// </para>
        ///  
        /// <para>
        /// A target-based policy tracks a single metric: PercentAvailableGameSessions. This metric
        /// tells us how much of a fleet's hosting capacity is ready to host game sessions but
        /// is not currently in use. This is the fleet's buffer; it measures the additional player
        /// demand that the fleet could handle at current capacity. With a target-based policy,
        /// you set your ideal buffer size and leave it to Amazon GameLift to take whatever action
        /// is needed to maintain that target. 
        /// </para>
        ///  
        /// <para>
        /// For example, you might choose to maintain a 10% buffer for a fleet that has the capacity
        /// to host 100 simultaneous game sessions. This policy tells Amazon GameLift to take
        /// action whenever the fleet's available capacity falls below or rises above 10 game
        /// sessions. Amazon GameLift will start new instances or stop unused instances in order
        /// to return to the 10% buffer. 
        /// </para>
        ///  
        /// <para>
        /// To create or update a target-based policy, specify a fleet ID and name, and set the
        /// policy type to "TargetBased". Specify the metric to track (PercentAvailableGameSessions)
        /// and reference a <a>TargetConfiguration</a> object with your desired buffer value.
        /// Exclude all other parameters. On a successful request, the policy name is returned.
        /// The scaling policy is automatically in force as soon as it's successfully created.
        /// If the fleet's auto-scaling actions are temporarily suspended, the new policy will
        /// be in force once the fleet actions are restarted.
        /// </para>
        ///  
        /// <para>
        ///  <b>Rule-based policy</b> 
        /// </para>
        ///  
        /// <para>
        /// A rule-based policy tracks specified fleet metric, sets a threshold value, and specifies
        /// the type of action to initiate when triggered. With a rule-based policy, you can select
        /// from several available fleet metrics. Each policy specifies whether to scale up or
        /// scale down (and by how much), so you need one policy for each type of action. 
        /// </para>
        ///  
        /// <para>
        /// For example, a policy may make the following statement: "If the percentage of idle
        /// instances is greater than 20% for more than 15 minutes, then reduce the fleet capacity
        /// by 10%."
        /// </para>
        ///  
        /// <para>
        /// A policy's rule statement has the following structure:
        /// </para>
        ///  
        /// <para>
        /// If <code>[MetricName]</code> is <code>[ComparisonOperator]</code> <code>[Threshold]</code>
        /// for <code>[EvaluationPeriods]</code> minutes, then <code>[ScalingAdjustmentType]</code>
        /// to/by <code>[ScalingAdjustment]</code>.
        /// </para>
        ///  
        /// <para>
        /// To implement the example, the rule statement would look like this:
        /// </para>
        ///  
        /// <para>
        /// If <code>[PercentIdleInstances]</code> is <code>[GreaterThanThreshold]</code> <code>[20]</code>
        /// for <code>[15]</code> minutes, then <code>[PercentChangeInCapacity]</code> to/by <code>[10]</code>.
        /// </para>
        ///  
        /// <para>
        /// To create or update a scaling policy, specify a unique combination of name and fleet
        /// ID, and set the policy type to "RuleBased". Specify the parameter values for a policy
        /// rule statement. On a successful request, the policy name is returned. Scaling policies
        /// are automatically in force as soon as they're successfully created. If the fleet's
        /// auto-scaling actions are temporarily suspended, the new policy will be in force once
        /// the fleet actions are restarted.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Manage scaling policies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutScalingPolicy</a> (auto-scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScalingPolicies</a> (auto-scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScalingPolicy</a> (auto-scaling)
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
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the PutScalingPolicy service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest request);



        /// <summary>
        /// Creates or updates a scaling policy for a fleet. Scaling policies are used to automatically
        /// scale a fleet's hosting capacity to meet player demand. An active scaling policy instructs
        /// Amazon GameLift to track a fleet metric and automatically change the fleet's capacity
        /// when a certain threshold is reached. There are two types of scaling policies: target-based
        /// and rule-based. Use a target-based policy to quickly and efficiently manage fleet
        /// scaling; this option is the most commonly used. Use rule-based policies when you need
        /// to exert fine-grained control over auto-scaling. 
        /// 
        ///  
        /// <para>
        /// Fleets can have multiple scaling policies of each type in force at the same time;
        /// you can have one target-based policy, one or multiple rule-based scaling policies,
        /// or both. We recommend caution, however, because multiple auto-scaling policies can
        /// have unintended consequences.
        /// </para>
        ///  
        /// <para>
        /// You can temporarily suspend all scaling policies for a fleet by calling <a>StopFleetActions</a>
        /// with the fleet action AUTO_SCALING. To resume scaling policies, call <a>StartFleetActions</a>
        /// with the same fleet action. To stop just one scaling policy--or to permanently remove
        /// it, you must delete the policy with <a>DeleteScalingPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// Learn more about how to work with auto-scaling in <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-autoscaling.html">Set
        /// Up Fleet Automatic Scaling</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Target-based policy</b> 
        /// </para>
        ///  
        /// <para>
        /// A target-based policy tracks a single metric: PercentAvailableGameSessions. This metric
        /// tells us how much of a fleet's hosting capacity is ready to host game sessions but
        /// is not currently in use. This is the fleet's buffer; it measures the additional player
        /// demand that the fleet could handle at current capacity. With a target-based policy,
        /// you set your ideal buffer size and leave it to Amazon GameLift to take whatever action
        /// is needed to maintain that target. 
        /// </para>
        ///  
        /// <para>
        /// For example, you might choose to maintain a 10% buffer for a fleet that has the capacity
        /// to host 100 simultaneous game sessions. This policy tells Amazon GameLift to take
        /// action whenever the fleet's available capacity falls below or rises above 10 game
        /// sessions. Amazon GameLift will start new instances or stop unused instances in order
        /// to return to the 10% buffer. 
        /// </para>
        ///  
        /// <para>
        /// To create or update a target-based policy, specify a fleet ID and name, and set the
        /// policy type to "TargetBased". Specify the metric to track (PercentAvailableGameSessions)
        /// and reference a <a>TargetConfiguration</a> object with your desired buffer value.
        /// Exclude all other parameters. On a successful request, the policy name is returned.
        /// The scaling policy is automatically in force as soon as it's successfully created.
        /// If the fleet's auto-scaling actions are temporarily suspended, the new policy will
        /// be in force once the fleet actions are restarted.
        /// </para>
        ///  
        /// <para>
        ///  <b>Rule-based policy</b> 
        /// </para>
        ///  
        /// <para>
        /// A rule-based policy tracks specified fleet metric, sets a threshold value, and specifies
        /// the type of action to initiate when triggered. With a rule-based policy, you can select
        /// from several available fleet metrics. Each policy specifies whether to scale up or
        /// scale down (and by how much), so you need one policy for each type of action. 
        /// </para>
        ///  
        /// <para>
        /// For example, a policy may make the following statement: "If the percentage of idle
        /// instances is greater than 20% for more than 15 minutes, then reduce the fleet capacity
        /// by 10%."
        /// </para>
        ///  
        /// <para>
        /// A policy's rule statement has the following structure:
        /// </para>
        ///  
        /// <para>
        /// If <code>[MetricName]</code> is <code>[ComparisonOperator]</code> <code>[Threshold]</code>
        /// for <code>[EvaluationPeriods]</code> minutes, then <code>[ScalingAdjustmentType]</code>
        /// to/by <code>[ScalingAdjustment]</code>.
        /// </para>
        ///  
        /// <para>
        /// To implement the example, the rule statement would look like this:
        /// </para>
        ///  
        /// <para>
        /// If <code>[PercentIdleInstances]</code> is <code>[GreaterThanThreshold]</code> <code>[20]</code>
        /// for <code>[15]</code> minutes, then <code>[PercentChangeInCapacity]</code> to/by <code>[10]</code>.
        /// </para>
        ///  
        /// <para>
        /// To create or update a scaling policy, specify a unique combination of name and fleet
        /// ID, and set the policy type to "RuleBased". Specify the parameter values for a policy
        /// rule statement. On a successful request, the policy name is returned. Scaling policies
        /// are automatically in force as soon as they're successfully created. If the fleet's
        /// auto-scaling actions are temporarily suspended, the new policy will be in force once
        /// the fleet actions are restarted.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Manage scaling policies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutScalingPolicy</a> (auto-scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScalingPolicies</a> (auto-scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScalingPolicy</a> (auto-scaling)
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
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutScalingPolicy service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterGameServer


        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Creates a new game server resource and notifies GameLift FleetIQ that the game server
        /// is ready to host gameplay and players. This operation is called by a game server process
        /// that is running on an instance in a game server group. Registering game servers enables
        /// GameLift FleetIQ to track available game servers and enables game clients and services
        /// to claim a game server for a new game session. 
        /// </para>
        ///  
        /// <para>
        /// To register a game server, identify the game server group and instance where the game
        /// server is running, and provide a unique identifier for the game server. You can also
        /// include connection and game server data. When a game client or service requests a
        /// game server by calling <a>ClaimGameServer</a>, this information is returned in the
        /// response.
        /// </para>
        ///  
        /// <para>
        /// Once a game server is successfully registered, it is put in status <code>AVAILABLE</code>.
        /// A request to register a game server may fail if the instance it is running on is in
        /// the process of shutting down as part of instance balancing or scale-down activity.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RegisterGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ClaimGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeregisterGameServer</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterGameServer service method.</param>
        /// 
        /// <returns>The response from the RegisterGameServer service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/RegisterGameServer">REST API Reference for RegisterGameServer Operation</seealso>
        RegisterGameServerResponse RegisterGameServer(RegisterGameServerRequest request);



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Creates a new game server resource and notifies GameLift FleetIQ that the game server
        /// is ready to host gameplay and players. This operation is called by a game server process
        /// that is running on an instance in a game server group. Registering game servers enables
        /// GameLift FleetIQ to track available game servers and enables game clients and services
        /// to claim a game server for a new game session. 
        /// </para>
        ///  
        /// <para>
        /// To register a game server, identify the game server group and instance where the game
        /// server is running, and provide a unique identifier for the game server. You can also
        /// include connection and game server data. When a game client or service requests a
        /// game server by calling <a>ClaimGameServer</a>, this information is returned in the
        /// response.
        /// </para>
        ///  
        /// <para>
        /// Once a game server is successfully registered, it is put in status <code>AVAILABLE</code>.
        /// A request to register a game server may fail if the instance it is running on is in
        /// the process of shutting down as part of instance balancing or scale-down activity.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RegisterGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ClaimGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeregisterGameServer</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterGameServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterGameServer service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/RegisterGameServer">REST API Reference for RegisterGameServer Operation</seealso>
        Task<RegisterGameServerResponse> RegisterGameServerAsync(RegisterGameServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-cli-uploading.html#gamelift-build-cli-uploading-create-build">
        /// Create a Build with Files in S3</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        /// <param name="buildId">A unique identifier for a build to get credentials for. You can use either the build ID or ARN value. </param>
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
        RequestUploadCredentialsResponse RequestUploadCredentials(string buildId);

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
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-cli-uploading.html#gamelift-build-cli-uploading-create-build">
        /// Create a Build with Files in S3</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        /// <param name="request">Container for the necessary parameters to execute the RequestUploadCredentials service method.</param>
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
        RequestUploadCredentialsResponse RequestUploadCredentials(RequestUploadCredentialsRequest request);


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
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-cli-uploading.html#gamelift-build-cli-uploading-create-build">
        /// Create a Build with Files in S3</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        /// <param name="buildId">A unique identifier for a build to get credentials for. You can use either the build ID or ARN value. </param>
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
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-cli-uploading.html#gamelift-build-cli-uploading-create-build">
        /// Create a Build with Files in S3</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        /// <param name="request">Container for the necessary parameters to execute the RequestUploadCredentials service method.</param>
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
        Task<RequestUploadCredentialsResponse> RequestUploadCredentialsAsync(RequestUploadCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResolveAlias


        /// <summary>
        /// Retrieves the fleet ID that an alias is currently pointing to.
        /// 
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
        /// <param name="aliasId">The unique identifier of the alias that you want to retrieve a fleet ID for. You can use either the alias ID or ARN value.</param>
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
        ResolveAliasResponse ResolveAlias(string aliasId);

        /// <summary>
        /// Retrieves the fleet ID that an alias is currently pointing to.
        /// 
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
        /// <param name="request">Container for the necessary parameters to execute the ResolveAlias service method.</param>
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
        ResolveAliasResponse ResolveAlias(ResolveAliasRequest request);


        /// <summary>
        /// Retrieves the fleet ID that an alias is currently pointing to.
        /// 
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
        /// <param name="aliasId">The unique identifier of the alias that you want to retrieve a fleet ID for. You can use either the alias ID or ARN value.</param>
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
        /// Retrieves the fleet ID that an alias is currently pointing to.
        /// 
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
        /// <param name="request">Container for the necessary parameters to execute the ResolveAlias service method.</param>
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
        Task<ResolveAliasResponse> ResolveAliasAsync(ResolveAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResumeGameServerGroup


        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Reinstates activity on a game server group after it has been suspended. A game server
        /// group might be suspended by the<a>SuspendGameServerGroup</a> operation, or it might
        /// be suspended involuntarily due to a configuration problem. In the second case, you
        /// can manually resume activity on the group once the configuration problem has been
        /// resolved. Refer to the game server group status and status reason for more information
        /// on why group activity is suspended.
        /// </para>
        ///  
        /// <para>
        /// To resume activity, specify a game server group ARN and the type of activity to be
        /// resumed. If successful, a <a>GameServerGroup</a> object is returned showing that the
        /// resumed activity is no longer listed in <code>SuspendedActions</code>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerInstances</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeGameServerGroup service method.</param>
        /// 
        /// <returns>The response from the ResumeGameServerGroup service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ResumeGameServerGroup">REST API Reference for ResumeGameServerGroup Operation</seealso>
        ResumeGameServerGroupResponse ResumeGameServerGroup(ResumeGameServerGroupRequest request);



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Reinstates activity on a game server group after it has been suspended. A game server
        /// group might be suspended by the<a>SuspendGameServerGroup</a> operation, or it might
        /// be suspended involuntarily due to a configuration problem. In the second case, you
        /// can manually resume activity on the group once the configuration problem has been
        /// resolved. Refer to the game server group status and status reason for more information
        /// on why group activity is suspended.
        /// </para>
        ///  
        /// <para>
        /// To resume activity, specify a game server group ARN and the type of activity to be
        /// resumed. If successful, a <a>GameServerGroup</a> object is returned showing that the
        /// resumed activity is no longer listed in <code>SuspendedActions</code>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerInstances</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeGameServerGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResumeGameServerGroup service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ResumeGameServerGroup">REST API Reference for ResumeGameServerGroup Operation</seealso>
        Task<ResumeGameServerGroupResponse> ResumeGameServerGroupAsync(ResumeGameServerGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchGameSessions


        /// <summary>
        /// Retrieves all active game sessions that match a set of search criteria and sorts them
        /// in a specified order. You can search or sort by the following game session attributes:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>gameSessionId</b> -- A unique identifier for the game session. You can use either
        /// a <code>GameSessionId</code> or <code>GameSessionArn</code> value. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>gameSessionName</b> -- Name assigned to a game session. This value is set when
        /// requesting a new game session with <a>CreateGameSession</a> or updating with <a>UpdateGameSession</a>.
        /// Game session names do not need to be unique to a game session.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>gameSessionProperties</b> -- Custom data defined in a game session's <code>GameProperty</code>
        /// parameter. <code>GameProperty</code> values are stored as key:value pairs; the filter
        /// expression must indicate the key and a string to search the data values for. For example,
        /// to search for game sessions with custom data containing the key:value pair "gameMode:brawl",
        /// specify the following: <code>gameSessionProperties.gameMode = "brawl"</code>. All
        /// custom data values are searched as strings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>maximumSessions</b> -- Maximum number of player sessions allowed for a game session.
        /// This value is set when requesting a new game session with <a>CreateGameSession</a>
        /// or updating with <a>UpdateGameSession</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>creationTimeMillis</b> -- Value indicating when a game session was created. It
        /// is expressed in Unix time as milliseconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>playerSessionCount</b> -- Number of players currently connected to a game session.
        /// This value changes rapidly as players join the session or drop out.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>hasAvailablePlayerSessions</b> -- Boolean value indicating whether a game session
        /// has reached its maximum number of players. It is highly recommended that all search
        /// requests include this filter attribute to optimize search performance and return only
        /// sessions that players can join. 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Returned values for <code>playerSessionCount</code> and <code>hasAvailablePlayerSessions</code>
        /// change quickly as players join sessions and others drop out. Results should be considered
        /// a snapshot in time. Be sure to refresh search results often, and handle sessions that
        /// fill up before a player can join. 
        /// </para>
        ///  </note> 
        /// <para>
        /// To search or sort, specify either a fleet ID or an alias ID, and provide a search
        /// filter expression, a sort expression, or both. If successful, a collection of <a>GameSession</a>
        /// objects matching the request is returned. Use the pagination parameters to retrieve
        /// results as a set of sequential pages. 
        /// </para>
        ///  
        /// <para>
        /// You can search for game sessions one fleet at a time only. To find game sessions across
        /// multiple fleets, you must search each fleet separately and combine the results. This
        /// search feature finds only game sessions that are in <code>ACTIVE</code> status. To
        /// locate games in statuses other than active, use <a>DescribeGameSessionDetails</a>.
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
        /// <param name="request">Container for the necessary parameters to execute the SearchGameSessions service method.</param>
        /// 
        /// <returns>The response from the SearchGameSessions service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/SearchGameSessions">REST API Reference for SearchGameSessions Operation</seealso>
        SearchGameSessionsResponse SearchGameSessions(SearchGameSessionsRequest request);



        /// <summary>
        /// Retrieves all active game sessions that match a set of search criteria and sorts them
        /// in a specified order. You can search or sort by the following game session attributes:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>gameSessionId</b> -- A unique identifier for the game session. You can use either
        /// a <code>GameSessionId</code> or <code>GameSessionArn</code> value. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>gameSessionName</b> -- Name assigned to a game session. This value is set when
        /// requesting a new game session with <a>CreateGameSession</a> or updating with <a>UpdateGameSession</a>.
        /// Game session names do not need to be unique to a game session.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>gameSessionProperties</b> -- Custom data defined in a game session's <code>GameProperty</code>
        /// parameter. <code>GameProperty</code> values are stored as key:value pairs; the filter
        /// expression must indicate the key and a string to search the data values for. For example,
        /// to search for game sessions with custom data containing the key:value pair "gameMode:brawl",
        /// specify the following: <code>gameSessionProperties.gameMode = "brawl"</code>. All
        /// custom data values are searched as strings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>maximumSessions</b> -- Maximum number of player sessions allowed for a game session.
        /// This value is set when requesting a new game session with <a>CreateGameSession</a>
        /// or updating with <a>UpdateGameSession</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>creationTimeMillis</b> -- Value indicating when a game session was created. It
        /// is expressed in Unix time as milliseconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>playerSessionCount</b> -- Number of players currently connected to a game session.
        /// This value changes rapidly as players join the session or drop out.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>hasAvailablePlayerSessions</b> -- Boolean value indicating whether a game session
        /// has reached its maximum number of players. It is highly recommended that all search
        /// requests include this filter attribute to optimize search performance and return only
        /// sessions that players can join. 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Returned values for <code>playerSessionCount</code> and <code>hasAvailablePlayerSessions</code>
        /// change quickly as players join sessions and others drop out. Results should be considered
        /// a snapshot in time. Be sure to refresh search results often, and handle sessions that
        /// fill up before a player can join. 
        /// </para>
        ///  </note> 
        /// <para>
        /// To search or sort, specify either a fleet ID or an alias ID, and provide a search
        /// filter expression, a sort expression, or both. If successful, a collection of <a>GameSession</a>
        /// objects matching the request is returned. Use the pagination parameters to retrieve
        /// results as a set of sequential pages. 
        /// </para>
        ///  
        /// <para>
        /// You can search for game sessions one fleet at a time only. To find game sessions across
        /// multiple fleets, you must search each fleet separately and combine the results. This
        /// search feature finds only game sessions that are in <code>ACTIVE</code> status. To
        /// locate games in statuses other than active, use <a>DescribeGameSessionDetails</a>.
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
        /// <param name="request">Container for the necessary parameters to execute the SearchGameSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchGameSessions service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/SearchGameSessions">REST API Reference for SearchGameSessions Operation</seealso>
        Task<SearchGameSessionsResponse> SearchGameSessionsAsync(SearchGameSessionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartFleetActions


        /// <summary>
        /// Resumes activity on a fleet that was suspended with <a>StopFleetActions</a>. Currently,
        /// this operation is used to restart a fleet's auto-scaling activity. 
        /// 
        ///  
        /// <para>
        /// To start fleet actions, specify the fleet ID and the type of actions to restart. When
        /// auto-scaling fleet actions are restarted, Amazon GameLift once again initiates scaling
        /// events as triggered by the fleet's scaling policies. If actions on the fleet were
        /// never stopped, this operation will have no effect. You can view a fleet's stopped
        /// actions using <a>DescribeFleetAttributes</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFleetActions service method.</param>
        /// 
        /// <returns>The response from the StartFleetActions service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartFleetActions">REST API Reference for StartFleetActions Operation</seealso>
        StartFleetActionsResponse StartFleetActions(StartFleetActionsRequest request);



        /// <summary>
        /// Resumes activity on a fleet that was suspended with <a>StopFleetActions</a>. Currently,
        /// this operation is used to restart a fleet's auto-scaling activity. 
        /// 
        ///  
        /// <para>
        /// To start fleet actions, specify the fleet ID and the type of actions to restart. When
        /// auto-scaling fleet actions are restarted, Amazon GameLift once again initiates scaling
        /// events as triggered by the fleet's scaling policies. If actions on the fleet were
        /// never stopped, this operation will have no effect. You can view a fleet's stopped
        /// actions using <a>DescribeFleetAttributes</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFleetActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartFleetActions service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartFleetActions">REST API Reference for StartFleetActions Operation</seealso>
        Task<StartFleetActionsResponse> StartFleetActionsAsync(StartFleetActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartGameSessionPlacement


        /// <summary>
        /// Places a request for a new game session in a queue (see <a>CreateGameSessionQueue</a>).
        /// When processing a placement request, Amazon GameLift searches for available resources
        /// on the queue's destinations, scanning each until it finds resources or the placement
        /// request times out.
        /// 
        ///  
        /// <para>
        /// A game session placement request can also request player sessions. When a new game
        /// session is successfully created, Amazon GameLift creates a player session for each
        /// player included in the request.
        /// </para>
        ///  
        /// <para>
        /// When placing a game session, by default Amazon GameLift tries each fleet in the order
        /// they are listed in the queue configuration. Ideally, a queue's destinations are listed
        /// in preference order.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, when requesting a game session with players, you can also provide latency
        /// data for each player in relevant Regions. Latency data indicates the performance lag
        /// a player experiences when connected to a fleet in the Region. Amazon GameLift uses
        /// latency data to reorder the list of destinations to place the game session in a Region
        /// with minimal lag. If latency data is provided for multiple players, Amazon GameLift
        /// calculates each Region's average lag for all players and reorders to get the best
        /// game play across all players. 
        /// </para>
        ///  
        /// <para>
        /// To place a new game session request, specify the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The queue name and a set of game session properties and settings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A unique ID (such as a UUID) for the placement. You use this ID to track the status
        /// of the placement request
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) A set of player data and a unique player ID for each player that you are
        /// joining to the new game session (player data is optional, but if you include it, you
        /// must also provide a unique ID for each player)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Latency data for all players (if you want to optimize game play for the players)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If successful, a new game session placement is created.
        /// </para>
        ///  
        /// <para>
        /// To track the status of a placement request, call <a>DescribeGameSessionPlacement</a>
        /// and check the request's status. If the status is <code>FULFILLED</code>, a new game
        /// session has been created and a game session ARN and Region are referenced. If the
        /// placement request times out, you can resubmit the request or retry it with a different
        /// queue. 
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
        /// <param name="request">Container for the necessary parameters to execute the StartGameSessionPlacement service method.</param>
        /// 
        /// <returns>The response from the StartGameSessionPlacement service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartGameSessionPlacement">REST API Reference for StartGameSessionPlacement Operation</seealso>
        StartGameSessionPlacementResponse StartGameSessionPlacement(StartGameSessionPlacementRequest request);



        /// <summary>
        /// Places a request for a new game session in a queue (see <a>CreateGameSessionQueue</a>).
        /// When processing a placement request, Amazon GameLift searches for available resources
        /// on the queue's destinations, scanning each until it finds resources or the placement
        /// request times out.
        /// 
        ///  
        /// <para>
        /// A game session placement request can also request player sessions. When a new game
        /// session is successfully created, Amazon GameLift creates a player session for each
        /// player included in the request.
        /// </para>
        ///  
        /// <para>
        /// When placing a game session, by default Amazon GameLift tries each fleet in the order
        /// they are listed in the queue configuration. Ideally, a queue's destinations are listed
        /// in preference order.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, when requesting a game session with players, you can also provide latency
        /// data for each player in relevant Regions. Latency data indicates the performance lag
        /// a player experiences when connected to a fleet in the Region. Amazon GameLift uses
        /// latency data to reorder the list of destinations to place the game session in a Region
        /// with minimal lag. If latency data is provided for multiple players, Amazon GameLift
        /// calculates each Region's average lag for all players and reorders to get the best
        /// game play across all players. 
        /// </para>
        ///  
        /// <para>
        /// To place a new game session request, specify the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The queue name and a set of game session properties and settings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A unique ID (such as a UUID) for the placement. You use this ID to track the status
        /// of the placement request
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) A set of player data and a unique player ID for each player that you are
        /// joining to the new game session (player data is optional, but if you include it, you
        /// must also provide a unique ID for each player)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Latency data for all players (if you want to optimize game play for the players)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If successful, a new game session placement is created.
        /// </para>
        ///  
        /// <para>
        /// To track the status of a placement request, call <a>DescribeGameSessionPlacement</a>
        /// and check the request's status. If the status is <code>FULFILLED</code>, a new game
        /// session has been created and a game session ARN and Region are referenced. If the
        /// placement request times out, you can resubmit the request or retry it with a different
        /// queue. 
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
        /// <param name="request">Container for the necessary parameters to execute the StartGameSessionPlacement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartGameSessionPlacement service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartGameSessionPlacement">REST API Reference for StartGameSessionPlacement Operation</seealso>
        Task<StartGameSessionPlacementResponse> StartGameSessionPlacementAsync(StartGameSessionPlacementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartMatchBackfill


        /// <summary>
        /// Finds new players to fill open slots in an existing game session. This operation can
        /// be used to add players to matched games that start with fewer than the maximum number
        /// of players or to replace players when they drop out. By backfilling with the same
        /// matchmaker used to create the original match, you ensure that new players meet the
        /// match criteria and maintain a consistent experience throughout the game session. You
        /// can backfill a match anytime after a game session has been created. 
        /// 
        ///  
        /// <para>
        /// To request a match backfill, specify a unique ticket ID, the existing game session's
        /// ARN, a matchmaking configuration, and a set of data that describes all current players
        /// in the game session. If successful, a match backfill ticket is created and returned
        /// with status set to QUEUED. The ticket is placed in the matchmaker's ticket pool and
        /// processed. Track the status of the ticket to respond as needed. 
        /// </para>
        ///  
        /// <para>
        /// The process of finding backfill matches is essentially identical to the initial matchmaking
        /// process. The matchmaker searches the pool and groups tickets together to form potential
        /// matches, allowing only one backfill ticket per potential match. Once the a match is
        /// formed, the matchmaker creates player sessions for the new players. All tickets in
        /// the match are updated with the game session's connection information, and the <a>GameSession</a>
        /// object is updated to include matchmaker data on the new players. For more detail on
        /// how match backfill requests are processed, see <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/gamelift-match.html">
        /// How Amazon GameLift FlexMatch Works</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-backfill.html">
        /// Backfill Existing Games with FlexMatch</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/gamelift-match.html">
        /// How GameLift FlexMatch Works</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AcceptMatch</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartMatchBackfill</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMatchBackfill service method.</param>
        /// 
        /// <returns>The response from the StartMatchBackfill service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartMatchBackfill">REST API Reference for StartMatchBackfill Operation</seealso>
        StartMatchBackfillResponse StartMatchBackfill(StartMatchBackfillRequest request);



        /// <summary>
        /// Finds new players to fill open slots in an existing game session. This operation can
        /// be used to add players to matched games that start with fewer than the maximum number
        /// of players or to replace players when they drop out. By backfilling with the same
        /// matchmaker used to create the original match, you ensure that new players meet the
        /// match criteria and maintain a consistent experience throughout the game session. You
        /// can backfill a match anytime after a game session has been created. 
        /// 
        ///  
        /// <para>
        /// To request a match backfill, specify a unique ticket ID, the existing game session's
        /// ARN, a matchmaking configuration, and a set of data that describes all current players
        /// in the game session. If successful, a match backfill ticket is created and returned
        /// with status set to QUEUED. The ticket is placed in the matchmaker's ticket pool and
        /// processed. Track the status of the ticket to respond as needed. 
        /// </para>
        ///  
        /// <para>
        /// The process of finding backfill matches is essentially identical to the initial matchmaking
        /// process. The matchmaker searches the pool and groups tickets together to form potential
        /// matches, allowing only one backfill ticket per potential match. Once the a match is
        /// formed, the matchmaker creates player sessions for the new players. All tickets in
        /// the match are updated with the game session's connection information, and the <a>GameSession</a>
        /// object is updated to include matchmaker data on the new players. For more detail on
        /// how match backfill requests are processed, see <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/gamelift-match.html">
        /// How Amazon GameLift FlexMatch Works</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-backfill.html">
        /// Backfill Existing Games with FlexMatch</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/gamelift-match.html">
        /// How GameLift FlexMatch Works</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AcceptMatch</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartMatchBackfill</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMatchBackfill service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMatchBackfill service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartMatchBackfill">REST API Reference for StartMatchBackfill Operation</seealso>
        Task<StartMatchBackfillResponse> StartMatchBackfillAsync(StartMatchBackfillRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartMatchmaking


        /// <summary>
        /// Uses FlexMatch to create a game match for a group of players based on custom matchmaking
        /// rules. If you're also using GameLift hosting, a new game session is started for the
        /// matched players. Each matchmaking request identifies one or more players to find a
        /// match for, and specifies the type of match to build, including the team configuration
        /// and the rules for an acceptable match. When a matchmaking request identifies a group
        /// of players who want to play together, FlexMatch finds additional players to fill the
        /// match. Match type, rules, and other features are defined in a <code>MatchmakingConfiguration</code>.
        /// 
        /// 
        ///  
        /// <para>
        /// To start matchmaking, provide a unique ticket ID, specify a matchmaking configuration,
        /// and include the players to be matched. For each player, you must also include the
        /// player attribute values that are required by the matchmaking configuration (in the
        /// rule set). If successful, a matchmaking ticket is returned with status set to <code>QUEUED</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Track the status of the ticket to respond as needed. If you're also using GameLift
        /// hosting, a successfully completed ticket contains game session connection information.
        /// Ticket status updates are tracked using event notification through Amazon Simple Notification
        /// Service (SNS), which is defined in the matchmaking configuration.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-client.html">
        /// Add FlexMatch to a Game Client</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-notification.html">
        /// Set Up FlexMatch Event Notification</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-tasks.html">
        /// FlexMatch Integration Roadmap</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/gamelift-match.html">
        /// How GameLift FlexMatch Works</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AcceptMatch</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartMatchBackfill</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMatchmaking service method.</param>
        /// 
        /// <returns>The response from the StartMatchmaking service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartMatchmaking">REST API Reference for StartMatchmaking Operation</seealso>
        StartMatchmakingResponse StartMatchmaking(StartMatchmakingRequest request);



        /// <summary>
        /// Uses FlexMatch to create a game match for a group of players based on custom matchmaking
        /// rules. If you're also using GameLift hosting, a new game session is started for the
        /// matched players. Each matchmaking request identifies one or more players to find a
        /// match for, and specifies the type of match to build, including the team configuration
        /// and the rules for an acceptable match. When a matchmaking request identifies a group
        /// of players who want to play together, FlexMatch finds additional players to fill the
        /// match. Match type, rules, and other features are defined in a <code>MatchmakingConfiguration</code>.
        /// 
        /// 
        ///  
        /// <para>
        /// To start matchmaking, provide a unique ticket ID, specify a matchmaking configuration,
        /// and include the players to be matched. For each player, you must also include the
        /// player attribute values that are required by the matchmaking configuration (in the
        /// rule set). If successful, a matchmaking ticket is returned with status set to <code>QUEUED</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Track the status of the ticket to respond as needed. If you're also using GameLift
        /// hosting, a successfully completed ticket contains game session connection information.
        /// Ticket status updates are tracked using event notification through Amazon Simple Notification
        /// Service (SNS), which is defined in the matchmaking configuration.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-client.html">
        /// Add FlexMatch to a Game Client</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-notification.html">
        /// Set Up FlexMatch Event Notification</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-tasks.html">
        /// FlexMatch Integration Roadmap</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/gamelift-match.html">
        /// How GameLift FlexMatch Works</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AcceptMatch</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartMatchBackfill</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMatchmaking service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMatchmaking service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartMatchmaking">REST API Reference for StartMatchmaking Operation</seealso>
        Task<StartMatchmakingResponse> StartMatchmakingAsync(StartMatchmakingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopFleetActions


        /// <summary>
        /// Suspends activity on a fleet. Currently, this operation is used to stop a fleet's
        /// auto-scaling activity. It is used to temporarily stop triggering scaling events. The
        /// policies can be retained and auto-scaling activity can be restarted using <a>StartFleetActions</a>.
        /// You can view a fleet's stopped actions using <a>DescribeFleetAttributes</a>.
        /// 
        ///  
        /// <para>
        /// To stop fleet actions, specify the fleet ID and the type of actions to suspend. When
        /// auto-scaling fleet actions are stopped, Amazon GameLift no longer initiates scaling
        /// events except in response to manual changes using <a>UpdateFleetCapacity</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopFleetActions service method.</param>
        /// 
        /// <returns>The response from the StopFleetActions service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopFleetActions">REST API Reference for StopFleetActions Operation</seealso>
        StopFleetActionsResponse StopFleetActions(StopFleetActionsRequest request);



        /// <summary>
        /// Suspends activity on a fleet. Currently, this operation is used to stop a fleet's
        /// auto-scaling activity. It is used to temporarily stop triggering scaling events. The
        /// policies can be retained and auto-scaling activity can be restarted using <a>StartFleetActions</a>.
        /// You can view a fleet's stopped actions using <a>DescribeFleetAttributes</a>.
        /// 
        ///  
        /// <para>
        /// To stop fleet actions, specify the fleet ID and the type of actions to suspend. When
        /// auto-scaling fleet actions are stopped, Amazon GameLift no longer initiates scaling
        /// events except in response to manual changes using <a>UpdateFleetCapacity</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopFleetActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopFleetActions service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopFleetActions">REST API Reference for StopFleetActions Operation</seealso>
        Task<StopFleetActionsResponse> StopFleetActionsAsync(StopFleetActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopGameSessionPlacement


        /// <summary>
        /// Cancels a game session placement that is in <code>PENDING</code> status. To stop a
        /// placement, provide the placement ID values. If successful, the placement is moved
        /// to <code>CANCELLED</code> status.
        /// 
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
        /// <param name="request">Container for the necessary parameters to execute the StopGameSessionPlacement service method.</param>
        /// 
        /// <returns>The response from the StopGameSessionPlacement service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopGameSessionPlacement">REST API Reference for StopGameSessionPlacement Operation</seealso>
        StopGameSessionPlacementResponse StopGameSessionPlacement(StopGameSessionPlacementRequest request);



        /// <summary>
        /// Cancels a game session placement that is in <code>PENDING</code> status. To stop a
        /// placement, provide the placement ID values. If successful, the placement is moved
        /// to <code>CANCELLED</code> status.
        /// 
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
        /// <param name="request">Container for the necessary parameters to execute the StopGameSessionPlacement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopGameSessionPlacement service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopGameSessionPlacement">REST API Reference for StopGameSessionPlacement Operation</seealso>
        Task<StopGameSessionPlacementResponse> StopGameSessionPlacementAsync(StopGameSessionPlacementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopMatchmaking


        /// <summary>
        /// Cancels a matchmaking ticket or match backfill ticket that is currently being processed.
        /// To stop the matchmaking operation, specify the ticket ID. If successful, work on the
        /// ticket is stopped, and the ticket status is changed to <code>CANCELLED</code>.
        /// 
        ///  
        /// <para>
        /// This call is also used to turn off automatic backfill for an individual game session.
        /// This is for game sessions that are created with a matchmaking configuration that has
        /// automatic backfill enabled. The ticket ID is included in the <code>MatchmakerData</code>
        /// of an updated game session object, which is provided to the game server.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the operation is successful, the service sends back an empty JSON struct with the
        /// HTTP 200 response (not an empty HTTP body).
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-client.html">
        /// Add FlexMatch to a Game Client</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AcceptMatch</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartMatchBackfill</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopMatchmaking service method.</param>
        /// 
        /// <returns>The response from the StopMatchmaking service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopMatchmaking">REST API Reference for StopMatchmaking Operation</seealso>
        StopMatchmakingResponse StopMatchmaking(StopMatchmakingRequest request);



        /// <summary>
        /// Cancels a matchmaking ticket or match backfill ticket that is currently being processed.
        /// To stop the matchmaking operation, specify the ticket ID. If successful, work on the
        /// ticket is stopped, and the ticket status is changed to <code>CANCELLED</code>.
        /// 
        ///  
        /// <para>
        /// This call is also used to turn off automatic backfill for an individual game session.
        /// This is for game sessions that are created with a matchmaking configuration that has
        /// automatic backfill enabled. The ticket ID is included in the <code>MatchmakerData</code>
        /// of an updated game session object, which is provided to the game server.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the operation is successful, the service sends back an empty JSON struct with the
        /// HTTP 200 response (not an empty HTTP body).
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-client.html">
        /// Add FlexMatch to a Game Client</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopMatchmaking</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AcceptMatch</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartMatchBackfill</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopMatchmaking service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopMatchmaking service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopMatchmaking">REST API Reference for StopMatchmaking Operation</seealso>
        Task<StopMatchmakingResponse> StopMatchmakingAsync(StopMatchmakingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SuspendGameServerGroup


        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Temporarily stops activity on a game server group without terminating instances or
        /// the game server group. You can restart activity by calling <a>ResumeGameServerGroup</a>.
        /// You can suspend the following activity:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Instance type replacement</b> - This activity evaluates the current game hosting
        /// viability of all Spot instance types that are defined for the game server group. It
        /// updates the Auto Scaling group to remove nonviable Spot Instance types, which have
        /// a higher chance of game server interruptions. It then balances capacity across the
        /// remaining viable Spot Instance types. When this activity is suspended, the Auto Scaling
        /// group continues with its current balance, regardless of viability. Instance protection,
        /// utilization metrics, and capacity scaling activities continue to be active. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To suspend activity, specify a game server group ARN and the type of activity to be
        /// suspended. If successful, a <a>GameServerGroup</a> object is returned showing that
        /// the activity is listed in <code>SuspendedActions</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerInstances</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SuspendGameServerGroup service method.</param>
        /// 
        /// <returns>The response from the SuspendGameServerGroup service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/SuspendGameServerGroup">REST API Reference for SuspendGameServerGroup Operation</seealso>
        SuspendGameServerGroupResponse SuspendGameServerGroup(SuspendGameServerGroupRequest request);



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Temporarily stops activity on a game server group without terminating instances or
        /// the game server group. You can restart activity by calling <a>ResumeGameServerGroup</a>.
        /// You can suspend the following activity:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Instance type replacement</b> - This activity evaluates the current game hosting
        /// viability of all Spot instance types that are defined for the game server group. It
        /// updates the Auto Scaling group to remove nonviable Spot Instance types, which have
        /// a higher chance of game server interruptions. It then balances capacity across the
        /// remaining viable Spot Instance types. When this activity is suspended, the Auto Scaling
        /// group continues with its current balance, regardless of viability. Instance protection,
        /// utilization metrics, and capacity scaling activities continue to be active. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To suspend activity, specify a game server group ARN and the type of activity to be
        /// suspended. If successful, a <a>GameServerGroup</a> object is returned showing that
        /// the activity is listed in <code>SuspendedActions</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerInstances</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SuspendGameServerGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SuspendGameServerGroup service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/SuspendGameServerGroup">REST API Reference for SuspendGameServerGroup Operation</seealso>
        Task<SuspendGameServerGroupResponse> SuspendGameServerGroupAsync(SuspendGameServerGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns a tag to a GameLift resource. AWS resource tags provide an additional management
        /// tool set. You can use tags to organize resources, create IAM permissions policies
        /// to manage access to groups of resources, customize AWS cost breakdowns, etc. This
        /// operation handles the permissions necessary to manage tags for the following GameLift
        /// resource types:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Build
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Script
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Fleet
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GameSessionQueue
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MatchmakingConfiguration
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MatchmakingRuleSet
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To add a tag to a resource, specify the unique ARN value for the resource and provide
        /// a tag list containing one or more tags. The operation succeeds even if the list includes
        /// tags that are already assigned to the specified resource. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// AWS Resources</a> in the <i>AWS General Reference</i> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="http://aws.amazon.com/answers/account-management/aws-tagging-strategies/">
        /// AWS Tagging Strategies</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>TagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UntagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListTagsForResource</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Assigns a tag to a GameLift resource. AWS resource tags provide an additional management
        /// tool set. You can use tags to organize resources, create IAM permissions policies
        /// to manage access to groups of resources, customize AWS cost breakdowns, etc. This
        /// operation handles the permissions necessary to manage tags for the following GameLift
        /// resource types:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Build
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Script
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Fleet
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GameSessionQueue
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MatchmakingConfiguration
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MatchmakingRuleSet
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To add a tag to a resource, specify the unique ARN value for the resource and provide
        /// a tag list containing one or more tags. The operation succeeds even if the list includes
        /// tags that are already assigned to the specified resource. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// AWS Resources</a> in the <i>AWS General Reference</i> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="http://aws.amazon.com/answers/account-management/aws-tagging-strategies/">
        /// AWS Tagging Strategies</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>TagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UntagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListTagsForResource</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag that is assigned to a GameLift resource. Resource tags are used to organize
        /// AWS resources for a range of purposes. This operation handles the permissions necessary
        /// to manage tags for the following GameLift resource types:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Build
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Script
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Fleet
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GameSessionQueue
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MatchmakingConfiguration
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MatchmakingRuleSet
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To remove a tag from a resource, specify the unique ARN value for the resource and
        /// provide a string list containing one or more tags to be removed. This operation succeeds
        /// even if the list includes tags that are not currently assigned to the specified resource.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// AWS Resources</a> in the <i>AWS General Reference</i> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="http://aws.amazon.com/answers/account-management/aws-tagging-strategies/">
        /// AWS Tagging Strategies</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>TagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UntagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListTagsForResource</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes a tag that is assigned to a GameLift resource. Resource tags are used to organize
        /// AWS resources for a range of purposes. This operation handles the permissions necessary
        /// to manage tags for the following GameLift resource types:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Build
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Script
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Fleet
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GameSessionQueue
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MatchmakingConfiguration
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MatchmakingRuleSet
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To remove a tag from a resource, specify the unique ARN value for the resource and
        /// provide a string list containing one or more tags to be removed. This operation succeeds
        /// even if the list includes tags that are not currently assigned to the specified resource.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// AWS Resources</a> in the <i>AWS General Reference</i> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="http://aws.amazon.com/answers/account-management/aws-tagging-strategies/">
        /// AWS Tagging Strategies</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>TagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UntagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListTagsForResource</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAlias


        /// <summary>
        /// Updates properties for an alias. To update properties, specify the alias ID to be
        /// updated and provide the information to be changed. To reassign an alias to another
        /// fleet, provide an updated routing strategy. If successful, the updated alias record
        /// is returned.
        /// 
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        UpdateAliasResponse UpdateAlias(UpdateAliasRequest request);



        /// <summary>
        /// Updates properties for an alias. To update properties, specify the alias ID to be
        /// updated and provide the information to be changed. To reassign an alias to another
        /// fleet, provide an updated routing strategy. If successful, the updated alias record
        /// is returned.
        /// 
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateBuild


        /// <summary>
        /// Updates metadata in a build resource, including the build name and version. To update
        /// the metadata, specify the build ID to update and provide the new values. If successful,
        /// a build object containing the updated metadata is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">
        /// Upload a Custom Server Build</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateBuild service method.</param>
        /// 
        /// <returns>The response from the UpdateBuild service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateBuild">REST API Reference for UpdateBuild Operation</seealso>
        UpdateBuildResponse UpdateBuild(UpdateBuildRequest request);



        /// <summary>
        /// Updates metadata in a build resource, including the build name and version. To update
        /// the metadata, specify the build ID to update and provide the new values. If successful,
        /// a build object containing the updated metadata is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">
        /// Upload a Custom Server Build</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateBuild service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBuild service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateBuild">REST API Reference for UpdateBuild Operation</seealso>
        Task<UpdateBuildResponse> UpdateBuildAsync(UpdateBuildRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFleetAttributes


        /// <summary>
        /// Updates fleet properties, including name and description, for a fleet. To update metadata,
        /// specify the fleet ID and the property values that you want to change. If successful,
        /// the fleet ID for the updated fleet is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
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
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetAttributes service method.</param>
        /// 
        /// <returns>The response from the UpdateFleetAttributes service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
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
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetAttributes">REST API Reference for UpdateFleetAttributes Operation</seealso>
        UpdateFleetAttributesResponse UpdateFleetAttributes(UpdateFleetAttributesRequest request);



        /// <summary>
        /// Updates fleet properties, including name and description, for a fleet. To update metadata,
        /// specify the fleet ID and the property values that you want to change. If successful,
        /// the fleet ID for the updated fleet is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
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
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFleetAttributes service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
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
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetAttributes">REST API Reference for UpdateFleetAttributes Operation</seealso>
        Task<UpdateFleetAttributesResponse> UpdateFleetAttributesAsync(UpdateFleetAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFleetCapacity


        /// <summary>
        /// Updates capacity settings for a fleet. Use this operation to specify the number of
        /// EC2 instances (hosts) that you want this fleet to contain. Before calling this operation,
        /// you may want to call <a>DescribeEC2InstanceLimits</a> to get the maximum capacity
        /// based on the fleet's EC2 instance type.
        /// 
        ///  
        /// <para>
        /// Specify minimum and maximum number of instances. Amazon GameLift will not change fleet
        /// capacity to values fall outside of this range. This is particularly important when
        /// using auto-scaling (see <a>PutScalingPolicy</a>) to allow capacity to adjust based
        /// on player demand while imposing limits on automatic adjustments.
        /// </para>
        ///  
        /// <para>
        /// To update fleet capacity, specify the fleet ID and the number of instances you want
        /// the fleet to host. If successful, Amazon GameLift starts or terminates instances so
        /// that the fleet's active instance count matches the desired instance count. You can
        /// view a fleet's current capacity information by calling <a>DescribeFleetCapacity</a>.
        /// If the desired instance count is higher than the instance type's limit, the "Limit
        /// Exceeded" exception occurs.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
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
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetCapacity service method.</param>
        /// 
        /// <returns>The response from the UpdateFleetCapacity service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
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
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetCapacity">REST API Reference for UpdateFleetCapacity Operation</seealso>
        UpdateFleetCapacityResponse UpdateFleetCapacity(UpdateFleetCapacityRequest request);



        /// <summary>
        /// Updates capacity settings for a fleet. Use this operation to specify the number of
        /// EC2 instances (hosts) that you want this fleet to contain. Before calling this operation,
        /// you may want to call <a>DescribeEC2InstanceLimits</a> to get the maximum capacity
        /// based on the fleet's EC2 instance type.
        /// 
        ///  
        /// <para>
        /// Specify minimum and maximum number of instances. Amazon GameLift will not change fleet
        /// capacity to values fall outside of this range. This is particularly important when
        /// using auto-scaling (see <a>PutScalingPolicy</a>) to allow capacity to adjust based
        /// on player demand while imposing limits on automatic adjustments.
        /// </para>
        ///  
        /// <para>
        /// To update fleet capacity, specify the fleet ID and the number of instances you want
        /// the fleet to host. If successful, Amazon GameLift starts or terminates instances so
        /// that the fleet's active instance count matches the desired instance count. You can
        /// view a fleet's current capacity information by calling <a>DescribeFleetCapacity</a>.
        /// If the desired instance count is higher than the instance type's limit, the "Limit
        /// Exceeded" exception occurs.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
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
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetCapacity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFleetCapacity service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
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
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetCapacity">REST API Reference for UpdateFleetCapacity Operation</seealso>
        Task<UpdateFleetCapacityResponse> UpdateFleetCapacityAsync(UpdateFleetCapacityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFleetPortSettings


        /// <summary>
        /// Updates port settings for a fleet. To update settings, specify the fleet ID to be
        /// updated and list the permissions you want to update. List the permissions you want
        /// to add in <code>InboundPermissionAuthorizations</code>, and permissions you want to
        /// remove in <code>InboundPermissionRevocations</code>. Permissions to be removed must
        /// match existing fleet permissions. If successful, the fleet ID for the updated fleet
        /// is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
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
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetPortSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateFleetPortSettings service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
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
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetPortSettings">REST API Reference for UpdateFleetPortSettings Operation</seealso>
        UpdateFleetPortSettingsResponse UpdateFleetPortSettings(UpdateFleetPortSettingsRequest request);



        /// <summary>
        /// Updates port settings for a fleet. To update settings, specify the fleet ID to be
        /// updated and list the permissions you want to update. List the permissions you want
        /// to add in <code>InboundPermissionAuthorizations</code>, and permissions you want to
        /// remove in <code>InboundPermissionRevocations</code>. Permissions to be removed must
        /// match existing fleet permissions. If successful, the fleet ID for the updated fleet
        /// is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
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
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetPortSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFleetPortSettings service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
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
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetPortSettings">REST API Reference for UpdateFleetPortSettings Operation</seealso>
        Task<UpdateFleetPortSettingsResponse> UpdateFleetPortSettingsAsync(UpdateFleetPortSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateGameServer


        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Updates information about a registered game server to help GameLift FleetIQ to track
        /// game server availability. This operation is called by a game server process that is
        /// running on an instance in a game server group. 
        /// </para>
        ///  
        /// <para>
        /// Use this operation to update the following types of game server information. You can
        /// make all three types of updates in the same request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To update the game server's utilization status, identify the game server and game
        /// server group and specify the current utilization status. Use this status to identify
        /// when game servers are currently hosting games and when they are available to be claimed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To report health status, identify the game server and game server group and set health
        /// check to <code>HEALTHY</code>. If a game server does not report health status for
        /// a certain length of time, the game server is no longer considered healthy. As a result,
        /// it will be eventually deregistered from the game server group to avoid affecting utilization
        /// metrics. The best practice is to report health every 60 seconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To change game server metadata, provide updated game server data.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Once a game server is successfully updated, the relevant statuses and timestamps are
        /// updated.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RegisterGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ClaimGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeregisterGameServer</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameServer service method.</param>
        /// 
        /// <returns>The response from the UpdateGameServer service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameServer">REST API Reference for UpdateGameServer Operation</seealso>
        UpdateGameServerResponse UpdateGameServer(UpdateGameServerRequest request);



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Updates information about a registered game server to help GameLift FleetIQ to track
        /// game server availability. This operation is called by a game server process that is
        /// running on an instance in a game server group. 
        /// </para>
        ///  
        /// <para>
        /// Use this operation to update the following types of game server information. You can
        /// make all three types of updates in the same request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To update the game server's utilization status, identify the game server and game
        /// server group and specify the current utilization status. Use this status to identify
        /// when game servers are currently hosting games and when they are available to be claimed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To report health status, identify the game server and game server group and set health
        /// check to <code>HEALTHY</code>. If a game server does not report health status for
        /// a certain length of time, the game server is no longer considered healthy. As a result,
        /// it will be eventually deregistered from the game server group to avoid affecting utilization
        /// metrics. The best practice is to report health every 60 seconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To change game server metadata, provide updated game server data.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Once a game server is successfully updated, the relevant statuses and timestamps are
        /// updated.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RegisterGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ClaimGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeregisterGameServer</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGameServer service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameServer">REST API Reference for UpdateGameServer Operation</seealso>
        Task<UpdateGameServerResponse> UpdateGameServerAsync(UpdateGameServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateGameServerGroup


        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Updates GameLift FleetIQ-specific properties for a game server group. Many Auto Scaling
        /// group properties are updated on the Auto Scaling group directly, including the launch
        /// template, Auto Scaling policies, and maximum/minimum/desired instance counts.
        /// </para>
        ///  
        /// <para>
        /// To update the game server group, specify the game server group ID and provide the
        /// updated values. Before applying the updates, the new values are validated to ensure
        /// that GameLift FleetIQ can continue to perform instance balancing activity. If successful,
        /// a <a>GameServerGroup</a> object is returned.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerInstances</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameServerGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGameServerGroup service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameServerGroup">REST API Reference for UpdateGameServerGroup Operation</seealso>
        UpdateGameServerGroupResponse UpdateGameServerGroup(UpdateGameServerGroupRequest request);



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift FleetIQ solution and game server
        /// groups.</b> 
        /// 
        ///  
        /// <para>
        /// Updates GameLift FleetIQ-specific properties for a game server group. Many Auto Scaling
        /// group properties are updated on the Auto Scaling group directly, including the launch
        /// template, Auto Scaling policies, and maximum/minimum/desired instance counts.
        /// </para>
        ///  
        /// <para>
        /// To update the game server group, specify the game server group ID and provide the
        /// updated values. Before applying the updates, the new values are validated to ensure
        /// that GameLift FleetIQ can continue to perform instance balancing activity. If successful,
        /// a <a>GameServerGroup</a> object is returned.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
        /// FleetIQ Guide</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGameServerGroups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResumeGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SuspendGameServerGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameServerInstances</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameServerGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGameServerGroup service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameServerGroup">REST API Reference for UpdateGameServerGroup Operation</seealso>
        Task<UpdateGameServerGroupResponse> UpdateGameServerGroupAsync(UpdateGameServerGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateGameSession


        /// <summary>
        /// Updates game session properties. This includes the session name, maximum player count,
        /// protection policy, which controls whether or not an active game session can be terminated
        /// during a scale-down event, and the player session creation policy, which controls
        /// whether or not new players can join the session. To update a game session, specify
        /// the game session ID and the values you want to change. If successful, an updated <a>GameSession</a>
        /// object is returned. 
        /// 
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameSession service method.</param>
        /// 
        /// <returns>The response from the UpdateGameSession service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
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
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameSession">REST API Reference for UpdateGameSession Operation</seealso>
        UpdateGameSessionResponse UpdateGameSession(UpdateGameSessionRequest request);



        /// <summary>
        /// Updates game session properties. This includes the session name, maximum player count,
        /// protection policy, which controls whether or not an active game session can be terminated
        /// during a scale-down event, and the player session creation policy, which controls
        /// whether or not new players can join the session. To update a game session, specify
        /// the game session ID and the values you want to change. If successful, an updated <a>GameSession</a>
        /// object is returned. 
        /// 
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGameSession service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
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
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameSession">REST API Reference for UpdateGameSession Operation</seealso>
        Task<UpdateGameSessionResponse> UpdateGameSessionAsync(UpdateGameSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateGameSessionQueue


        /// <summary>
        /// Updates settings for a game session queue, which determines how new game session requests
        /// in the queue are processed. To update settings, specify the queue name to be updated
        /// and provide the new settings. When updating destinations, provide a complete list
        /// of destinations. 
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-intro.html">
        /// Using Multi-Region Queues</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionQueues</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameSessionQueue</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameSessionQueue service method.</param>
        /// 
        /// <returns>The response from the UpdateGameSessionQueue service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameSessionQueue">REST API Reference for UpdateGameSessionQueue Operation</seealso>
        UpdateGameSessionQueueResponse UpdateGameSessionQueue(UpdateGameSessionQueueRequest request);



        /// <summary>
        /// Updates settings for a game session queue, which determines how new game session requests
        /// in the queue are processed. To update settings, specify the queue name to be updated
        /// and provide the new settings. When updating destinations, provide a complete list
        /// of destinations. 
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-intro.html">
        /// Using Multi-Region Queues</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionQueues</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSessionQueue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteGameSessionQueue</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameSessionQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGameSessionQueue service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameSessionQueue">REST API Reference for UpdateGameSessionQueue Operation</seealso>
        Task<UpdateGameSessionQueueResponse> UpdateGameSessionQueueAsync(UpdateGameSessionQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateMatchmakingConfiguration


        /// <summary>
        /// Updates settings for a FlexMatch matchmaking configuration. These changes affect all
        /// matches and game sessions that are created after the update. To update settings, specify
        /// the configuration name to be updated and provide the new settings. 
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-configuration.html">
        /// Design a FlexMatch Matchmaker</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMatchmakingConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateMatchmakingConfiguration service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateMatchmakingConfiguration">REST API Reference for UpdateMatchmakingConfiguration Operation</seealso>
        UpdateMatchmakingConfigurationResponse UpdateMatchmakingConfiguration(UpdateMatchmakingConfigurationRequest request);



        /// <summary>
        /// Updates settings for a FlexMatch matchmaking configuration. These changes affect all
        /// matches and game sessions that are created after the update. To update settings, specify
        /// the configuration name to be updated and provide the new settings. 
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-configuration.html">
        /// Design a FlexMatch Matchmaker</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMatchmakingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMatchmakingConfiguration service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateMatchmakingConfiguration">REST API Reference for UpdateMatchmakingConfiguration Operation</seealso>
        Task<UpdateMatchmakingConfigurationResponse> UpdateMatchmakingConfigurationAsync(UpdateMatchmakingConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRuntimeConfiguration


        /// <summary>
        /// Updates the current runtime configuration for the specified fleet, which tells Amazon
        /// GameLift how to launch server processes on instances in the fleet. You can update
        /// a fleet's runtime configuration at any time after the fleet is created; it does not
        /// need to be in an <code>ACTIVE</code> status.
        /// 
        ///  
        /// <para>
        /// To update runtime configuration, specify the fleet ID and provide a <code>RuntimeConfiguration</code>
        /// object with an updated set of server process configurations.
        /// </para>
        ///  
        /// <para>
        /// Each instance in a Amazon GameLift fleet checks regularly for an updated runtime configuration
        /// and changes how it launches server processes to comply with the latest version. Existing
        /// server processes are not affected by the update; runtime configuration changes are
        /// applied gradually as existing processes shut down and new processes are launched during
        /// Amazon GameLift's normal process recycling activity.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
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
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuntimeConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateRuntimeConfiguration service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateRuntimeConfiguration">REST API Reference for UpdateRuntimeConfiguration Operation</seealso>
        UpdateRuntimeConfigurationResponse UpdateRuntimeConfiguration(UpdateRuntimeConfigurationRequest request);



        /// <summary>
        /// Updates the current runtime configuration for the specified fleet, which tells Amazon
        /// GameLift how to launch server processes on instances in the fleet. You can update
        /// a fleet's runtime configuration at any time after the fleet is created; it does not
        /// need to be in an <code>ACTIVE</code> status.
        /// 
        ///  
        /// <para>
        /// To update runtime configuration, specify the fleet ID and provide a <code>RuntimeConfiguration</code>
        /// object with an updated set of server process configurations.
        /// </para>
        ///  
        /// <para>
        /// Each instance in a Amazon GameLift fleet checks regularly for an updated runtime configuration
        /// and changes how it launches server processes to comply with the latest version. Existing
        /// server processes are not affected by the update; runtime configuration changes are
        /// applied gradually as existing processes shut down and new processes are launched during
        /// Amazon GameLift's normal process recycling activity.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
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
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
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
        ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuntimeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRuntimeConfiguration service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateRuntimeConfiguration">REST API Reference for UpdateRuntimeConfiguration Operation</seealso>
        Task<UpdateRuntimeConfigurationResponse> UpdateRuntimeConfigurationAsync(UpdateRuntimeConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateScript


        /// <summary>
        /// Updates Realtime script metadata and content.
        /// 
        ///  
        /// <para>
        /// To update script metadata, specify the script ID and provide updated name and/or version
        /// values. 
        /// </para>
        ///  
        /// <para>
        /// To update script content, provide an updated zip file by pointing to either a local
        /// file or an Amazon S3 bucket location. You can use either method regardless of how
        /// the original script was uploaded. Use the <i>Version</i> parameter to track updates
        /// to the script.
        /// </para>
        ///  
        /// <para>
        /// If the call is successful, the updated metadata is stored in the script record and
        /// a revised script is uploaded to the Amazon GameLift service. Once the script is updated
        /// and acquired by a fleet instance, the new version is used for all new game sessions.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
        /// GameLift Realtime Servers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListScripts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScript</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScript service method.</param>
        /// 
        /// <returns>The response from the UpdateScript service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateScript">REST API Reference for UpdateScript Operation</seealso>
        UpdateScriptResponse UpdateScript(UpdateScriptRequest request);



        /// <summary>
        /// Updates Realtime script metadata and content.
        /// 
        ///  
        /// <para>
        /// To update script metadata, specify the script ID and provide updated name and/or version
        /// values. 
        /// </para>
        ///  
        /// <para>
        /// To update script content, provide an updated zip file by pointing to either a local
        /// file or an Amazon S3 bucket location. You can use either method regardless of how
        /// the original script was uploaded. Use the <i>Version</i> parameter to track updates
        /// to the script.
        /// </para>
        ///  
        /// <para>
        /// If the call is successful, the updated metadata is stored in the script record and
        /// a revised script is uploaded to the Amazon GameLift service. Once the script is updated
        /// and acquired by a fleet instance, the new version is used for all new game sessions.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
        /// GameLift Realtime Servers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListScripts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateScript</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScript</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScript service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateScript service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateScript">REST API Reference for UpdateScript Operation</seealso>
        Task<UpdateScriptResponse> UpdateScriptAsync(UpdateScriptRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ValidateMatchmakingRuleSet


        /// <summary>
        /// Validates the syntax of a matchmaking rule or rule set. This operation checks that
        /// the rule set is using syntactically correct JSON and that it conforms to allowed property
        /// expressions. To validate syntax, provide a rule set JSON string.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-rulesets.html">Build
        /// a Rule Set</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateMatchmakingRuleSet service method.</param>
        /// 
        /// <returns>The response from the ValidateMatchmakingRuleSet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ValidateMatchmakingRuleSet">REST API Reference for ValidateMatchmakingRuleSet Operation</seealso>
        ValidateMatchmakingRuleSetResponse ValidateMatchmakingRuleSet(ValidateMatchmakingRuleSetRequest request);



        /// <summary>
        /// Validates the syntax of a matchmaking rule or rule set. This operation checks that
        /// the rule set is using syntactically correct JSON and that it conforms to allowed property
        /// expressions. To validate syntax, provide a rule set JSON string.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-rulesets.html">Build
        /// a Rule Set</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeMatchmakingRuleSets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ValidateMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteMatchmakingRuleSet</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateMatchmakingRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateMatchmakingRuleSet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ValidateMatchmakingRuleSet">REST API Reference for ValidateMatchmakingRuleSet Operation</seealso>
        Task<ValidateMatchmakingRuleSetResponse> ValidateMatchmakingRuleSetAsync(ValidateMatchmakingRuleSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}