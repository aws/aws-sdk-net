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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.GameLift.Model;

namespace Amazon.GameLift
{
    /// <summary>
    /// Interface for accessing GameLift
    ///
    /// GameLift Service 
    /// <para>
    /// Amazon Web Services provides solutions for hosting session-based multiplayer game
    /// servers in the cloud, including tools for deploying, operating, and scaling game servers.
    /// Built on Amazon Web Services global computing infrastructure, GameLift helps you deliver
    /// high-performance, high-reliability, low-cost game servers while dynamically scaling
    /// your resource usage to meet player demand. 
    /// </para>
    ///  
    /// <para>
    ///  <b>About GameLift solutions</b> 
    /// </para>
    ///  
    /// <para>
    /// Get more information on these GameLift solutions in the <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/">GameLift
    /// Developer Guide</a>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// GameLift managed hosting -- GameLift offers a fully managed service to set up and
    /// maintain computing machines for hosting, manage game session and player session life
    /// cycle, and handle security, storage, and performance tracking. You can use automatic
    /// scaling tools to balance player demand and hosting costs, configure your game session
    /// management to minimize player latency, and add FlexMatch for matchmaking.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Managed hosting with Realtime Servers -- With GameLift Realtime Servers, you can quickly
    /// configure and set up ready-to-go game servers for your game. Realtime Servers provides
    /// a game server framework with core GameLift infrastructure already built in. Then use
    /// the full range of GameLift managed hosting features, including FlexMatch, for your
    /// game.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// GameLift FleetIQ -- Use GameLift FleetIQ as a standalone service while hosting your
    /// games using EC2 instances and Auto Scaling groups. GameLift FleetIQ provides optimizations
    /// for game hosting, including boosting the viability of low-cost Spot Instances gaming.
    /// For a complete solution, pair the GameLift FleetIQ and FlexMatch standalone services.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// GameLift FlexMatch -- Add matchmaking to your game hosting solution. FlexMatch is
    /// a customizable matchmaking service for multiplayer games. Use FlexMatch as integrated
    /// with GameLift managed hosting or incorporate FlexMatch as a standalone service into
    /// your own hosting solution.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>About this API Reference</b> 
    /// </para>
    ///  
    /// <para>
    /// This reference guide describes the low-level service API for Amazon Web Services.
    /// With each topic in this guide, you can find links to language-specific SDK guides
    /// and the Amazon Web Services CLI reference. Useful links:
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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IGameLiftPaginatorFactory Paginators { get; }
#endif


        
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
        /// Add FlexMatch to a game client</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-events.html">
        /// FlexMatch events</a> (reference)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>StartMatchmaking</a> | <a>DescribeMatchmaking</a> | <a>StopMatchmaking</a> | <a>AcceptMatch</a>
        /// | <a>StartMatchBackfill</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the AcceptMatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptMatch operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptMatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/AcceptMatch">REST API Reference for AcceptMatch Operation</seealso>
        IAsyncResult BeginAcceptMatch(AcceptMatchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptMatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptMatch.</param>
        /// 
        /// <returns>Returns a  AcceptMatchResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/AcceptMatch">REST API Reference for AcceptMatch Operation</seealso>
        AcceptMatchResponse EndAcceptMatch(IAsyncResult asyncResult);

        #endregion
        
        #region  ClaimGameServer


        /// <summary>
        /// <b>This operation is used with the GameLift FleetIQ solution and game server groups.</b>
        /// 
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>RegisterGameServer</a> | <a>ListGameServers</a> | <a>ClaimGameServer</a> | <a>DescribeGameServer</a>
        /// | <a>UpdateGameServer</a> | <a>DeregisterGameServer</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/reference-awssdk-fleetiq.html">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the ClaimGameServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ClaimGameServer operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndClaimGameServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ClaimGameServer">REST API Reference for ClaimGameServer Operation</seealso>
        IAsyncResult BeginClaimGameServer(ClaimGameServerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ClaimGameServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginClaimGameServer.</param>
        /// 
        /// <returns>Returns a  ClaimGameServerResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ClaimGameServer">REST API Reference for ClaimGameServer Operation</seealso>
        ClaimGameServerResponse EndClaimGameServer(IAsyncResult asyncResult);

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
        /// Amazon Web Services supports two types of routing strategies for aliases: simple and
        /// terminal. A simple alias points to an active fleet. A terminal alias is used to display
        /// messaging or link to a URL instead of routing players to an active fleet. For example,
        /// you might use a terminal alias when a game version is no longer supported and you
        /// want to direct players to an upgrade site. 
        /// </para>
        ///  
        /// <para>
        /// To create a fleet alias, specify an alias name, routing strategy, and optional description.
        /// Each simple alias can point to only one fleet, but a fleet can have multiple aliases.
        /// If successful, a new alias record is returned, including an alias ID and an ARN. You
        /// can reassign an alias to another fleet by calling <code>UpdateAlias</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateAlias</a> | <a>ListAliases</a> | <a>DescribeAlias</a> | <a>UpdateAlias</a>
        /// | <a>DeleteAlias</a> | <a>ResolveAlias</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        IAsyncResult BeginCreateAlias(CreateAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAlias.</param>
        /// 
        /// <returns>Returns a  CreateAliasResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        CreateAliasResponse EndCreateAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBuild


        /// <summary>
        /// Creates a new Amazon Web Services build resource for your game server binary files.
        /// Game server binaries must be combined into a zip file for use with Amazon Web Services.
        /// 
        /// 
        ///  <important> 
        /// <para>
        /// When setting up a new game build for GameLift, we recommend using the Amazon Web Services
        /// CLI command <b> <a href="https://docs.aws.amazon.com/cli/latest/reference/gamelift/upload-build.html">upload-build</a>
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
        /// To create a new game build with build files that are in an Amazon S3 location under
        /// an Amazon Web Services account that you control. To use this option, you must first
        /// give Amazon Web Services access to the Amazon S3 bucket. With permissions in place,
        /// call <code>CreateBuild</code> and specify a build name, operating system, and the
        /// Amazon S3 storage location of your game build.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To directly upload your build files to a GameLift Amazon S3 location. To use this
        /// option, first call <code>CreateBuild</code> and specify a build name and operating
        /// system. This operation creates a new build resource and also returns an Amazon S3
        /// location with temporary access credentials. Use the credentials to manually upload
        /// your build files to the specified Amazon S3 location. For more information, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UploadingObjects.html">Uploading
        /// Objects</a> in the <i>Amazon S3 Developer Guide</i>. Build files can be uploaded to
        /// the GameLift Amazon S3 location once only; that can't be updated. 
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateBuild</a> | <a>ListBuilds</a> | <a>DescribeBuild</a> | <a>UpdateBuild</a>
        /// | <a>DeleteBuild</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the CreateBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBuild operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBuild
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateBuild">REST API Reference for CreateBuild Operation</seealso>
        IAsyncResult BeginCreateBuild(CreateBuildRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBuild operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBuild.</param>
        /// 
        /// <returns>Returns a  CreateBuildResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateBuild">REST API Reference for CreateBuild Operation</seealso>
        CreateBuildResponse EndCreateBuild(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFleet


        /// <summary>
        /// Creates a fleet of Amazon Elastic Compute Cloud (Amazon Elastic Compute Cloud) instances
        /// to host your custom game server or Realtime Servers. Use this operation to configure
        /// the computing resources for your fleet and provide instructions for running game servers
        /// on each instance.
        /// 
        ///  
        /// <para>
        /// Most GameLift fleets can deploy instances to multiple locations, including the home
        /// Region (where the fleet is created) and an optional set of remote locations. Fleets
        /// that are created in the following Amazon Web Services Regions support multiple locations:
        /// us-east-1 (N. Virginia), us-west-2 (Oregon), eu-central-1 (Frankfurt), eu-west-1 (Ireland),
        /// ap-southeast-2 (Sydney), ap-northeast-1 (Tokyo), and ap-northeast-2 (Seoul). Fleets
        /// that are created in other GameLift Regions can deploy instances in the fleet's home
        /// Region only. All fleet instances use the same configuration regardless of location;
        /// however, you can adjust capacity settings and turn auto-scaling on/off for each location.
        /// </para>
        ///  
        /// <para>
        /// To create a fleet, choose the hardware for your instances, specify a game server build
        /// or Realtime script to deploy, and provide a runtime configuration to direct GameLift
        /// how to start and run game servers on each instance in the fleet. Set permissions for
        /// inbound traffic to your game servers, and enable optional features as needed. When
        /// creating a multi-location fleet, provide a list of additional remote locations.
        /// </para>
        ///  
        /// <para>
        /// If you need to debug your fleet, fetch logs, view performance metrics or other actions
        /// on the fleet, create the development fleet with port 22/3389 open. As a best practice,
        /// we recommend opening ports for remote access only when you need them and closing them
        /// when you're finished. 
        /// </para>
        ///  
        /// <para>
        /// If successful, this operation creates a new Fleet resource and places it in <code>NEW</code>
        /// status, which prompts GameLift to initiate the <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creation-workflow.html">fleet
        /// creation workflow</a>. You can track fleet creation by checking fleet status using
        /// <a>DescribeFleetAttributes</a> and <a>DescribeFleetLocationAttributes</a>/, or by
        /// monitoring fleet creation events using <a>DescribeFleetEvents</a>. As soon as the
        /// fleet status changes to <code>ACTIVE</code>, you can enable automatic scaling for
        /// the fleet with <a>PutScalingPolicy</a> and set capacity for the home Region with <a>UpdateFleetCapacity</a>.
        /// When the status of each remote location reaches <code>ACTIVE</code>, you can set capacity
        /// by location using <a>UpdateFleetCapacity</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-debug.html#fleets-creating-debug-creation">Debug
        /// fleet creation issues</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Multi-location
        /// fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateFleet</a> | <a>UpdateFleetCapacity</a> | <a>PutScalingPolicy</a> | <a>DescribeEC2InstanceLimits</a>
        /// | <a>DescribeFleetAttributes</a> | <a>DescribeFleetLocationAttributes</a> | <a>UpdateFleetAttributes</a>
        /// | <a>StopFleetActions</a> | <a>DeleteFleet</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        CreateFleetResponse CreateFleet(CreateFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        IAsyncResult BeginCreateFleet(CreateFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFleet.</param>
        /// 
        /// <returns>Returns a  CreateFleetResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        CreateFleetResponse EndCreateFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFleetLocations


        /// <summary>
        /// Adds remote locations to a fleet and begins populating the new locations with EC2
        /// instances. The new instances conform to the fleet's instance type, auto-scaling, and
        /// other configuration settings. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation cannot be used with fleets that don't support remote locations. Fleets
        /// can have multiple locations only if they reside in Amazon Web Services Regions that
        /// support this feature (see <a>CreateFleet</a> for the complete list) and were created
        /// after the feature was released in March 2021.
        /// </para>
        ///  </note> 
        /// <para>
        /// To add fleet locations, specify the fleet to be updated and provide a list of one
        /// or more locations. 
        /// </para>
        ///  
        /// <para>
        /// If successful, this operation returns the list of added locations with their status
        /// set to <code>NEW</code>. GameLift initiates the process of starting an instance in
        /// each added location. You can track the status of each new location by monitoring location
        /// creation events using <a>DescribeFleetEvents</a>. Alternatively, you can poll location
        /// status by calling <a>DescribeFleetLocationAttributes</a>. After a location status
        /// becomes <code>ACTIVE</code>, you can adjust the location's capacity as needed with
        /// <a>UpdateFleetCapacity</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Multi-location
        /// fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateFleetLocations</a> | <a>DescribeFleetLocationAttributes</a> | <a>DescribeFleetLocationCapacity</a>
        /// | <a>DescribeFleetLocationUtilization</a> | <a>DescribeFleetAttributes</a> | <a>DescribeFleetCapacity</a>
        /// | <a>DescribeFleetUtilization</a> | <a>UpdateFleetCapacity</a> | <a>StopFleetActions</a>
        /// | <a>DeleteFleetLocations</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleetLocations service method.</param>
        /// 
        /// <returns>The response from the CreateFleetLocations service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateFleetLocations">REST API Reference for CreateFleetLocations Operation</seealso>
        CreateFleetLocationsResponse CreateFleetLocations(CreateFleetLocationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleetLocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleetLocations operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFleetLocations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateFleetLocations">REST API Reference for CreateFleetLocations Operation</seealso>
        IAsyncResult BeginCreateFleetLocations(CreateFleetLocationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFleetLocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFleetLocations.</param>
        /// 
        /// <returns>Returns a  CreateFleetLocationsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateFleetLocations">REST API Reference for CreateFleetLocations Operation</seealso>
        CreateFleetLocationsResponse EndCreateFleetLocations(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGameServerGroup


        /// <summary>
        /// <b>This operation is used with the GameLift FleetIQ solution and game server groups.</b>
        /// 
        /// 
        ///  
        /// <para>
        /// Creates a GameLift FleetIQ game server group for managing game hosting on a collection
        /// of Amazon Elastic Compute Cloud instances for game hosting. This operation creates
        /// the game server group, creates an Auto Scaling group in your Amazon Web Services account,
        /// and establishes a link between the two groups. You can view the status of your game
        /// server groups in the GameLift console. Game server group metrics and events are emitted
        /// to Amazon CloudWatch.
        /// </para>
        ///  
        /// <para>
        /// Before creating a new game server group, you must have the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon Elastic Compute Cloud launch template that specifies how to launch Amazon
        /// Elastic Compute Cloud instances with your game server build. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">
        /// Launching an Instance from a Launch Template</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An IAM role that extends limited access to your Amazon Web Services account to allow
        /// GameLift FleetIQ to create and interact with the Auto Scaling group. For more information,
        /// see <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-iam-permissions-roles.html">Create
        /// IAM roles for cross-service interaction</a> in the <i>GameLift FleetIQ Developer Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To create a new game server group, specify a unique group name, IAM role and Amazon
        /// Elastic Compute Cloud launch template, and provide a list of instance types that can
        /// be used in the group. You must also set initial maximum and minimum limits on the
        /// group's instance count. You can optionally set an Auto Scaling policy with target
        /// tracking based on a GameLift FleetIQ metric.
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateGameServerGroup</a> | <a>ListGameServerGroups</a> | <a>DescribeGameServerGroup</a>
        /// | <a>UpdateGameServerGroup</a> | <a>DeleteGameServerGroup</a> | <a>ResumeGameServerGroup</a>
        /// | <a>SuspendGameServerGroup</a> | <a>DescribeGameServerInstances</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/reference-awssdk-fleetiq.html">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the CreateGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGameServerGroup operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGameServerGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameServerGroup">REST API Reference for CreateGameServerGroup Operation</seealso>
        IAsyncResult BeginCreateGameServerGroup(CreateGameServerGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGameServerGroup.</param>
        /// 
        /// <returns>Returns a  CreateGameServerGroupResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameServerGroup">REST API Reference for CreateGameServerGroup Operation</seealso>
        CreateGameServerGroupResponse EndCreateGameServerGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGameSession


        /// <summary>
        /// Creates a multiplayer game session for players in a specific fleet location. This
        /// operation prompts an available server process to start a game session and retrieves
        /// connection information for the new game session. As an alternative, consider using
        /// the GameLift game session placement feature with 
        /// 
        ///  
        /// <para>
        /// with <a>StartGameSessionPlacement</a>, which uses FleetIQ algorithms and queues to
        /// optimize the placement process.
        /// </para>
        ///  
        /// <para>
        /// When creating a game session, you specify exactly where you want to place it and provide
        /// a set of game session configuration settings. The fleet must be in <code>ACTIVE</code>
        /// status before a game session can be created in it. 
        /// </para>
        ///  
        /// <para>
        /// This operation can be used in the following ways: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To create a game session on an instance in a fleet's home Region, provide a fleet
        /// or alias ID along with your game session configuration. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a game session on an instance in a fleet's remote location, provide a fleet
        /// or alias ID and a location name, along with your game session configuration. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If successful, a workflow is initiated to start a new game session. A <code>GameSession</code>
        /// object is returned containing the game session configuration and status. When the
        /// status is <code>ACTIVE</code>, game session connection information is provided and
        /// player sessions can be created for the game session. By default, newly created game
        /// sessions are open to new players. You can restrict new player access by using <a>UpdateGameSession</a>
        /// to change the game session's player session creation policy.
        /// </para>
        ///  
        /// <para>
        /// Game session logs are retained for all active game sessions for 14 days. To access
        /// the logs, call <a>GetGameSessionLogUrl</a> to download the log files.
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon Web Services Local.</i> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html#gamelift-sdk-server-startsession">Start
        /// a game session</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateGameSession</a> | <a>DescribeGameSessions</a> | <a>DescribeGameSessionDetails</a>
        /// | <a>SearchGameSessions</a> | <a>UpdateGameSession</a> | <a>GetGameSessionLogUrl</a>
        /// | <a>StartGameSessionPlacement</a> | <a>DescribeGameSessionPlacement</a> | <a>StopGameSessionPlacement</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameSession">REST API Reference for CreateGameSession Operation</seealso>
        CreateGameSessionResponse CreateGameSession(CreateGameSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGameSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGameSession operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGameSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameSession">REST API Reference for CreateGameSession Operation</seealso>
        IAsyncResult BeginCreateGameSession(CreateGameSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGameSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGameSession.</param>
        /// 
        /// <returns>Returns a  CreateGameSessionResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameSession">REST API Reference for CreateGameSession Operation</seealso>
        CreateGameSessionResponse EndCreateGameSession(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGameSessionQueue


        /// <summary>
        /// Creates a placement queue that processes requests for new game sessions. A queue uses
        /// FleetIQ algorithms to determine the best placement locations and find an available
        /// game server there, then prompts the game server process to start a new game session.
        /// 
        /// 
        ///  
        /// <para>
        /// A game session queue is configured with a set of destinations (GameLift fleets or
        /// aliases), which determine the locations where the queue can place new game sessions.
        /// These destinations can span multiple fleet types (Spot and On-Demand), instance types,
        /// and Amazon Web Services Regions. If the queue includes multi-location fleets, the
        /// queue is able to place game sessions in all of a fleet's remote locations. You can
        /// opt to filter out individual locations if needed.
        /// </para>
        ///  
        /// <para>
        /// The queue configuration also determines how FleetIQ selects the best available placement
        /// for a new game session. Before searching for an available game server, FleetIQ first
        /// prioritizes the queue's destinations and locations, with the best placement locations
        /// on top. You can set up the queue to use the FleetIQ default prioritization or provide
        /// an alternate set of priorities.
        /// </para>
        ///  
        /// <para>
        /// To create a new queue, provide a name, timeout value, and a list of destinations.
        /// Optionally, specify a sort configuration and/or a filter, and define a set of latency
        /// cap policies. You can also include the ARN for an Amazon Simple Notification Service
        /// (SNS) topic to receive notifications of game session placement activity. Notifications
        /// using SNS or CloudWatch events is the preferred way to track placement activity.
        /// </para>
        ///  
        /// <para>
        /// If successful, a new <code>GameSessionQueue</code> object is returned with an assigned
        /// queue ARN. New game session requests, which are submitted to queue with <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_StartGameSessionPlacement.html">StartGameSessionPlacement</a>
        /// or <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_StartMatchmaking.html">StartMatchmaking</a>,
        /// reference a queue's name or ARN. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-design.html">
        /// Design a game session queue</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-creating.html">
        /// Create a game session queue</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateGameSessionQueue.html">CreateGameSessionQueue</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeGameSessionQueues.html">DescribeGameSessionQueues</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_UpdateGameSessionQueue.html">UpdateGameSessionQueue</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DeleteGameSessionQueue.html">DeleteGameSessionQueue</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameSessionQueue">REST API Reference for CreateGameSessionQueue Operation</seealso>
        CreateGameSessionQueueResponse CreateGameSessionQueue(CreateGameSessionQueueRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGameSessionQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGameSessionQueue operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGameSessionQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameSessionQueue">REST API Reference for CreateGameSessionQueue Operation</seealso>
        IAsyncResult BeginCreateGameSessionQueue(CreateGameSessionQueueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGameSessionQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGameSessionQueue.</param>
        /// 
        /// <returns>Returns a  CreateGameSessionQueueResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameSessionQueue">REST API Reference for CreateGameSessionQueue Operation</seealso>
        CreateGameSessionQueueResponse EndCreateGameSessionQueue(IAsyncResult asyncResult);

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
        /// In addition, you must set up an Amazon Simple Notification Service topic to receive
        /// matchmaking notifications. Provide the topic ARN in the matchmaking configuration.
        /// An alternative method, continuously polling ticket status with <a>DescribeMatchmaking</a>,
        /// is only suitable for games in development with low matchmaking usage.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-configuration.html">
        /// Design a FlexMatch matchmaker</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-notification.html">
        /// Set up FlexMatch event notification</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> | <a>DescribeMatchmakingConfigurations</a>
        /// | <a>UpdateMatchmakingConfiguration</a> | <a>DeleteMatchmakingConfiguration</a> |
        /// <a>CreateMatchmakingRuleSet</a> | <a>DescribeMatchmakingRuleSets</a> | <a>ValidateMatchmakingRuleSet</a>
        /// | <a>DeleteMatchmakingRuleSet</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the CreateMatchmakingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchmakingConfiguration operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMatchmakingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateMatchmakingConfiguration">REST API Reference for CreateMatchmakingConfiguration Operation</seealso>
        IAsyncResult BeginCreateMatchmakingConfiguration(CreateMatchmakingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMatchmakingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMatchmakingConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateMatchmakingConfigurationResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateMatchmakingConfiguration">REST API Reference for CreateMatchmakingConfiguration Operation</seealso>
        CreateMatchmakingConfigurationResponse EndCreateMatchmakingConfiguration(IAsyncResult asyncResult);

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
        /// a rule set</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-configuration.html">Design
        /// a matchmaker</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-intro.html">Matchmaking
        /// with FlexMatch</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> | <a>DescribeMatchmakingConfigurations</a>
        /// | <a>UpdateMatchmakingConfiguration</a> | <a>DeleteMatchmakingConfiguration</a> |
        /// <a>CreateMatchmakingRuleSet</a> | <a>DescribeMatchmakingRuleSets</a> | <a>ValidateMatchmakingRuleSet</a>
        /// | <a>DeleteMatchmakingRuleSet</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the CreateMatchmakingRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchmakingRuleSet operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMatchmakingRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateMatchmakingRuleSet">REST API Reference for CreateMatchmakingRuleSet Operation</seealso>
        IAsyncResult BeginCreateMatchmakingRuleSet(CreateMatchmakingRuleSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMatchmakingRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMatchmakingRuleSet.</param>
        /// 
        /// <returns>Returns a  CreateMatchmakingRuleSetResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateMatchmakingRuleSet">REST API Reference for CreateMatchmakingRuleSet Operation</seealso>
        CreateMatchmakingRuleSetResponse EndCreateMatchmakingRuleSet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePlayerSession


        /// <summary>
        /// Reserves an open player slot in a game session for a player. New player sessions can
        /// be created in any game session with an open slot that is in <code>ACTIVE</code> status
        /// and has a player creation policy of <code>ACCEPT_ALL</code>. You can add a group of
        /// players to a game session with <a>CreatePlayerSessions</a>. 
        /// 
        ///  
        /// <para>
        /// To create a player session, specify a game session ID, player ID, and optionally a
        /// set of player data. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a slot is reserved in the game session for the player and a new <a>PlayerSession</a>
        /// object is returned with a player session ID. The player references the player session
        /// ID when sending a connection request to the game session, and the game server can
        /// use it to validate the player reservation with the GameLift service. Player sessions
        /// cannot be updated. 
        /// </para>
        ///  
        /// <para>
        /// The maximum number of players per game session is 200. It is not adjustable. 
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon Web Services Local.</i> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreatePlayerSession</a> | <a>CreatePlayerSessions</a> | <a>DescribePlayerSessions</a>
        /// | <a>StartGameSessionPlacement</a> | <a>DescribeGameSessionPlacement</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Reserves an open player slot in a game session for a player. New player sessions can
        /// be created in any game session with an open slot that is in <code>ACTIVE</code> status
        /// and has a player creation policy of <code>ACCEPT_ALL</code>. You can add a group of
        /// players to a game session with <a>CreatePlayerSessions</a>. 
        /// 
        ///  
        /// <para>
        /// To create a player session, specify a game session ID, player ID, and optionally a
        /// set of player data. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a slot is reserved in the game session for the player and a new <a>PlayerSession</a>
        /// object is returned with a player session ID. The player references the player session
        /// ID when sending a connection request to the game session, and the game server can
        /// use it to validate the player reservation with the GameLift service. Player sessions
        /// cannot be updated. 
        /// </para>
        ///  
        /// <para>
        /// The maximum number of players per game session is 200. It is not adjustable. 
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon Web Services Local.</i> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreatePlayerSession</a> | <a>CreatePlayerSessions</a> | <a>DescribePlayerSessions</a>
        /// | <a>StartGameSessionPlacement</a> | <a>DescribeGameSessionPlacement</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the CreatePlayerSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlayerSession operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePlayerSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSession">REST API Reference for CreatePlayerSession Operation</seealso>
        IAsyncResult BeginCreatePlayerSession(CreatePlayerSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlayerSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlayerSession.</param>
        /// 
        /// <returns>Returns a  CreatePlayerSessionResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSession">REST API Reference for CreatePlayerSession Operation</seealso>
        CreatePlayerSessionResponse EndCreatePlayerSession(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePlayerSessions


        /// <summary>
        /// Reserves open slots in a game session for a group of players. New player sessions
        /// can be created in any game session with an open slot that is in <code>ACTIVE</code>
        /// status and has a player creation policy of <code>ACCEPT_ALL</code>. To add a single
        /// player to a game session, use <a>CreatePlayerSession</a>. 
        /// 
        ///  
        /// <para>
        /// To create player sessions, specify a game session ID and a list of player IDs. Optionally,
        /// provide a set of player data for each player ID. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a slot is reserved in the game session for each player, and new <a>PlayerSession</a>
        /// objects are returned with player session IDs. Each player references their player
        /// session ID when sending a connection request to the game session, and the game server
        /// can use it to validate the player reservation with the GameLift service. Player sessions
        /// cannot be updated.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of players per game session is 200. It is not adjustable. 
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon Web Services Local.</i> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreatePlayerSession</a> | <a>CreatePlayerSessions</a> | <a>DescribePlayerSessions</a>
        /// | <a>StartGameSessionPlacement</a> | <a>DescribeGameSessionPlacement</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Reserves open slots in a game session for a group of players. New player sessions
        /// can be created in any game session with an open slot that is in <code>ACTIVE</code>
        /// status and has a player creation policy of <code>ACCEPT_ALL</code>. To add a single
        /// player to a game session, use <a>CreatePlayerSession</a>. 
        /// 
        ///  
        /// <para>
        /// To create player sessions, specify a game session ID and a list of player IDs. Optionally,
        /// provide a set of player data for each player ID. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a slot is reserved in the game session for each player, and new <a>PlayerSession</a>
        /// objects are returned with player session IDs. Each player references their player
        /// session ID when sending a connection request to the game session, and the game server
        /// can use it to validate the player reservation with the GameLift service. Player sessions
        /// cannot be updated.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of players per game session is 200. It is not adjustable. 
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon Web Services Local.</i> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreatePlayerSession</a> | <a>CreatePlayerSessions</a> | <a>DescribePlayerSessions</a>
        /// | <a>StartGameSessionPlacement</a> | <a>DescribeGameSessionPlacement</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the CreatePlayerSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlayerSessions operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePlayerSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSessions">REST API Reference for CreatePlayerSessions Operation</seealso>
        IAsyncResult BeginCreatePlayerSessions(CreatePlayerSessionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlayerSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlayerSessions.</param>
        /// 
        /// <returns>Returns a  CreatePlayerSessionsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSessions">REST API Reference for CreatePlayerSessions Operation</seealso>
        CreatePlayerSessionsResponse EndCreatePlayerSessions(IAsyncResult asyncResult);

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
        /// An Amazon Simple Storage Service (Amazon S3) bucket under your Amazon Web Services
        /// account. Use the <i>StorageLocation</i> parameter for this option. You'll need to
        /// have an Identity Access Management (IAM) role that allows the Amazon Web Services
        /// service to access your S3 bucket. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the call is successful, a new script record is created with a unique script ID.
        /// If the script file is provided as a local file, the file is uploaded to an Amazon
        /// Web Services-owned S3 bucket and the script record's storage location reflects this
        /// location. If the script file is provided as an S3 bucket, Amazon Web Services accesses
        /// the file at this storage location as needed for deployment.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
        /// Web Services Realtime Servers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/setting-up-role.html">Set
        /// Up a Role for Amazon Web Services Access</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateScript</a> | <a>ListScripts</a> | <a>DescribeScript</a> | <a>UpdateScript</a>
        /// | <a>DeleteScript</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the CreateScript operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateScript operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateScript
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateScript">REST API Reference for CreateScript Operation</seealso>
        IAsyncResult BeginCreateScript(CreateScriptRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateScript operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateScript.</param>
        /// 
        /// <returns>Returns a  CreateScriptResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateScript">REST API Reference for CreateScript Operation</seealso>
        CreateScriptResponse EndCreateScript(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVpcPeeringAuthorization


        /// <summary>
        /// Requests authorization to create or delete a peer connection between the VPC for your
        /// Amazon Web Services fleet and a virtual private cloud (VPC) in your Amazon Web Services
        /// account. VPC peering enables the game servers on your fleet to communicate directly
        /// with other Amazon Web Services resources. Once you've received authorization, call
        /// <a>CreateVpcPeeringConnection</a> to establish the peering connection. For more information,
        /// see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
        /// Peering with Amazon Web Services Fleets</a>.
        /// 
        ///  
        /// <para>
        /// You can peer with VPCs that are owned by any Amazon Web Services account you have
        /// access to, including the account that you use to manage your Amazon Web Services fleets.
        /// You cannot peer with VPCs that are in different Regions.
        /// </para>
        ///  
        /// <para>
        /// To request authorization to create a connection, call this operation from the Amazon
        /// Web Services account with the VPC that you want to peer to your Amazon Web Services
        /// fleet. For example, to enable your game servers to retrieve data from a DynamoDB table,
        /// use the account that manages that DynamoDB resource. Identify the following values:
        /// (1) The ID of the VPC that you want to peer with, and (2) the ID of the Amazon Web
        /// Services account that you use to manage Amazon Web Services. If successful, VPC peering
        /// is authorized for the specified VPC. 
        /// </para>
        ///  
        /// <para>
        /// To request authorization to delete a connection, call this operation from the Amazon
        /// Web Services account with the VPC that is peered with your Amazon Web Services fleet.
        /// Identify the following values: (1) VPC ID that you want to delete the peering connection
        /// for, and (2) ID of the Amazon Web Services account that you use to manage Amazon Web
        /// Services. 
        /// </para>
        ///  
        /// <para>
        /// The authorization remains valid for 24 hours unless it is canceled by a call to <a>DeleteVpcPeeringAuthorization</a>.
        /// You must create or delete the peering connection while the authorization is valid.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> | <a>DescribeVpcPeeringAuthorizations</a> |
        /// <a>DeleteVpcPeeringAuthorization</a> | <a>CreateVpcPeeringConnection</a> | <a>DescribeVpcPeeringConnections</a>
        /// | <a>DeleteVpcPeeringConnection</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the CreateVpcPeeringAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringAuthorization operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcPeeringAuthorization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateVpcPeeringAuthorization">REST API Reference for CreateVpcPeeringAuthorization Operation</seealso>
        IAsyncResult BeginCreateVpcPeeringAuthorization(CreateVpcPeeringAuthorizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcPeeringAuthorization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcPeeringAuthorization.</param>
        /// 
        /// <returns>Returns a  CreateVpcPeeringAuthorizationResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateVpcPeeringAuthorization">REST API Reference for CreateVpcPeeringAuthorization Operation</seealso>
        CreateVpcPeeringAuthorizationResponse EndCreateVpcPeeringAuthorization(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVpcPeeringConnection


        /// <summary>
        /// Establishes a VPC peering connection between a virtual private cloud (VPC) in an Amazon
        /// Web Services account with the VPC for your Amazon Web Services fleet. VPC peering
        /// enables the game servers on your fleet to communicate directly with other Amazon Web
        /// Services resources. You can peer with VPCs in any Amazon Web Services account that
        /// you have access to, including the account that you use to manage your Amazon Web Services
        /// fleets. You cannot peer with VPCs that are in different Regions. For more information,
        /// see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
        /// Peering with Amazon Web Services Fleets</a>.
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
        /// To establish the connection, call this operation from the Amazon Web Services account
        /// that is used to manage the Amazon Web Services fleets. Identify the following values:
        /// (1) The ID of the fleet you want to be enable a VPC peering connection for; (2) The
        /// Amazon Web Services account with the VPC that you want to peer with; and (3) The ID
        /// of the VPC you want to peer with. This operation is asynchronous. If successful, a
        /// <a>VpcPeeringConnection</a> request is created. You can use continuous polling to
        /// track the request's status using <a>DescribeVpcPeeringConnections</a>, or by monitoring
        /// fleet events for success or failure using <a>DescribeFleetEvents</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> | <a>DescribeVpcPeeringAuthorizations</a> |
        /// <a>DeleteVpcPeeringAuthorization</a> | <a>CreateVpcPeeringConnection</a> | <a>DescribeVpcPeeringConnections</a>
        /// | <a>DeleteVpcPeeringConnection</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the CreateVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringConnection operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcPeeringConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateVpcPeeringConnection">REST API Reference for CreateVpcPeeringConnection Operation</seealso>
        IAsyncResult BeginCreateVpcPeeringConnection(CreateVpcPeeringConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcPeeringConnection.</param>
        /// 
        /// <returns>Returns a  CreateVpcPeeringConnectionResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateVpcPeeringConnection">REST API Reference for CreateVpcPeeringConnection Operation</seealso>
        CreateVpcPeeringConnectionResponse EndCreateVpcPeeringConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAlias


        /// <summary>
        /// Deletes an alias. This operation removes all record of the alias. Game clients attempting
        /// to access a server process using the deleted alias receive an error. To delete an
        /// alias, specify the alias ID to be deleted.
        /// 
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateAlias</a> | <a>ListAliases</a> | <a>DescribeAlias</a> | <a>UpdateAlias</a>
        /// | <a>DeleteAlias</a> | <a>ResolveAlias</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateAlias</a> | <a>ListAliases</a> | <a>DescribeAlias</a> | <a>UpdateAlias</a>
        /// | <a>DeleteAlias</a> | <a>ResolveAlias</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        IAsyncResult BeginDeleteAlias(DeleteAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlias.</param>
        /// 
        /// <returns>Returns a  DeleteAliasResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        DeleteAliasResponse EndDeleteAlias(IAsyncResult asyncResult);

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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateBuild</a> | <a>ListBuilds</a> | <a>DescribeBuild</a> | <a>UpdateBuild</a>
        /// | <a>DeleteBuild</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
        /// </summary>
        /// <param name="buildId">A unique identifier for the build to delete. You can use either the build ID or ARN value. </param>
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateBuild</a> | <a>ListBuilds</a> | <a>DescribeBuild</a> | <a>UpdateBuild</a>
        /// | <a>DeleteBuild</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DeleteBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBuild operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBuild
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteBuild">REST API Reference for DeleteBuild Operation</seealso>
        IAsyncResult BeginDeleteBuild(DeleteBuildRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBuild operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBuild.</param>
        /// 
        /// <returns>Returns a  DeleteBuildResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteBuild">REST API Reference for DeleteBuild Operation</seealso>
        DeleteBuildResponse EndDeleteBuild(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFleet


        /// <summary>
        /// Deletes all resources and information related a fleet. Any current fleet instances,
        /// including those in remote locations, are shut down. You don't need to call <code>DeleteFleetLocations</code>
        /// separately.
        /// 
        ///  <note> 
        /// <para>
        /// If the fleet being deleted has a VPC peering connection, you first need to get a valid
        /// authorization (good for 24 hours) by calling <a>CreateVpcPeeringAuthorization</a>.
        /// You do not need to explicitly delete the VPC peering connection--this is done as part
        /// of the delete fleet process.
        /// </para>
        ///  </note> 
        /// <para>
        /// To delete a fleet, specify the fleet ID to be terminated. During the deletion process
        /// the fleet status is changed to <code>DELETING</code>. When completed, the status switches
        /// to <code>TERMINATED</code> and the fleet event <code>FLEET_DELETED</code> is sent.
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateFleetLocations</a> | <a>UpdateFleetAttributes</a> | <a>UpdateFleetCapacity</a>
        /// | <a>UpdateFleetPortSettings</a> | <a>UpdateRuntimeConfiguration</a> | <a>StopFleetActions</a>
        /// | <a>StartFleetActions</a> | <a>PutScalingPolicy</a> | <a>DeleteFleet</a> | <a>DeleteFleetLocations</a>
        /// | <a>DeleteScalingPolicy</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
        /// </summary>
        /// <param name="fleetId">A unique identifier for the fleet to be deleted. You can use either the fleet ID or ARN value.</param>
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
        /// Deletes all resources and information related a fleet. Any current fleet instances,
        /// including those in remote locations, are shut down. You don't need to call <code>DeleteFleetLocations</code>
        /// separately.
        /// 
        ///  <note> 
        /// <para>
        /// If the fleet being deleted has a VPC peering connection, you first need to get a valid
        /// authorization (good for 24 hours) by calling <a>CreateVpcPeeringAuthorization</a>.
        /// You do not need to explicitly delete the VPC peering connection--this is done as part
        /// of the delete fleet process.
        /// </para>
        ///  </note> 
        /// <para>
        /// To delete a fleet, specify the fleet ID to be terminated. During the deletion process
        /// the fleet status is changed to <code>DELETING</code>. When completed, the status switches
        /// to <code>TERMINATED</code> and the fleet event <code>FLEET_DELETED</code> is sent.
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateFleetLocations</a> | <a>UpdateFleetAttributes</a> | <a>UpdateFleetCapacity</a>
        /// | <a>UpdateFleetPortSettings</a> | <a>UpdateRuntimeConfiguration</a> | <a>StopFleetActions</a>
        /// | <a>StartFleetActions</a> | <a>PutScalingPolicy</a> | <a>DeleteFleet</a> | <a>DeleteFleetLocations</a>
        /// | <a>DeleteScalingPolicy</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        IAsyncResult BeginDeleteFleet(DeleteFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFleet.</param>
        /// 
        /// <returns>Returns a  DeleteFleetResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        DeleteFleetResponse EndDeleteFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFleetLocations


        /// <summary>
        /// Removes locations from a multi-location fleet. When deleting a location, all game
        /// server process and all instances that are still active in the location are shut down.
        /// 
        /// 
        ///  
        /// <para>
        /// To delete fleet locations, identify the fleet ID and provide a list of the locations
        /// to be deleted. 
        /// </para>
        ///  
        /// <para>
        /// If successful, GameLift sets the location status to <code>DELETING</code>, and begins
        /// to shut down existing server processes and terminate instances in each location being
        /// deleted. When completed, the location status changes to <code>TERMINATED</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateFleetLocations</a> | <a>DescribeFleetLocationAttributes</a> | <a>DescribeFleetLocationCapacity</a>
        /// | <a>DescribeFleetLocationUtilization</a> | <a>DescribeFleetAttributes</a> | <a>DescribeFleetCapacity</a>
        /// | <a>DescribeFleetUtilization</a> | <a>UpdateFleetCapacity</a> | <a>StopFleetActions</a>
        /// | <a>DeleteFleetLocations</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleetLocations service method.</param>
        /// 
        /// <returns>The response from the DeleteFleetLocations service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteFleetLocations">REST API Reference for DeleteFleetLocations Operation</seealso>
        DeleteFleetLocationsResponse DeleteFleetLocations(DeleteFleetLocationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFleetLocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleetLocations operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFleetLocations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteFleetLocations">REST API Reference for DeleteFleetLocations Operation</seealso>
        IAsyncResult BeginDeleteFleetLocations(DeleteFleetLocationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFleetLocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFleetLocations.</param>
        /// 
        /// <returns>Returns a  DeleteFleetLocationsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteFleetLocations">REST API Reference for DeleteFleetLocations Operation</seealso>
        DeleteFleetLocationsResponse EndDeleteFleetLocations(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGameServerGroup


        /// <summary>
        /// <b>This operation is used with the GameLift FleetIQ solution and game server groups.</b>
        /// 
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateGameServerGroup</a> | <a>ListGameServerGroups</a> | <a>DescribeGameServerGroup</a>
        /// | <a>UpdateGameServerGroup</a> | <a>DeleteGameServerGroup</a> | <a>ResumeGameServerGroup</a>
        /// | <a>SuspendGameServerGroup</a> | <a>DescribeGameServerInstances</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/reference-awssdk-fleetiq.html">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DeleteGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGameServerGroup operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGameServerGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteGameServerGroup">REST API Reference for DeleteGameServerGroup Operation</seealso>
        IAsyncResult BeginDeleteGameServerGroup(DeleteGameServerGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGameServerGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGameServerGroupResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteGameServerGroup">REST API Reference for DeleteGameServerGroup Operation</seealso>
        DeleteGameServerGroupResponse EndDeleteGameServerGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGameSessionQueue


        /// <summary>
        /// Deletes a game session queue. Once a queue is successfully deleted, unfulfilled <a
        /// href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_StartGameSessionPlacement.html">StartGameSessionPlacement</a>
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateGameSessionQueue.html">CreateGameSessionQueue</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeGameSessionQueues.html">DescribeGameSessionQueues</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_UpdateGameSessionQueue.html">UpdateGameSessionQueue</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DeleteGameSessionQueue.html">DeleteGameSessionQueue</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DeleteGameSessionQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGameSessionQueue operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGameSessionQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteGameSessionQueue">REST API Reference for DeleteGameSessionQueue Operation</seealso>
        IAsyncResult BeginDeleteGameSessionQueue(DeleteGameSessionQueueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGameSessionQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGameSessionQueue.</param>
        /// 
        /// <returns>Returns a  DeleteGameSessionQueueResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteGameSessionQueue">REST API Reference for DeleteGameSessionQueue Operation</seealso>
        DeleteGameSessionQueueResponse EndDeleteGameSessionQueue(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMatchmakingConfiguration


        /// <summary>
        /// Permanently removes a FlexMatch matchmaking configuration. To delete, specify the
        /// configuration name. A matchmaking configuration cannot be deleted if it is being used
        /// in any active matchmaking tickets.
        /// 
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> | <a>DescribeMatchmakingConfigurations</a>
        /// | <a>UpdateMatchmakingConfiguration</a> | <a>DeleteMatchmakingConfiguration</a> |
        /// <a>CreateMatchmakingRuleSet</a> | <a>DescribeMatchmakingRuleSets</a> | <a>ValidateMatchmakingRuleSet</a>
        /// | <a>DeleteMatchmakingRuleSet</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DeleteMatchmakingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchmakingConfiguration operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMatchmakingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteMatchmakingConfiguration">REST API Reference for DeleteMatchmakingConfiguration Operation</seealso>
        IAsyncResult BeginDeleteMatchmakingConfiguration(DeleteMatchmakingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMatchmakingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMatchmakingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteMatchmakingConfigurationResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteMatchmakingConfiguration">REST API Reference for DeleteMatchmakingConfiguration Operation</seealso>
        DeleteMatchmakingConfigurationResponse EndDeleteMatchmakingConfiguration(IAsyncResult asyncResult);

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
        /// a rule set</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> | <a>DescribeMatchmakingConfigurations</a>
        /// | <a>UpdateMatchmakingConfiguration</a> | <a>DeleteMatchmakingConfiguration</a> |
        /// <a>CreateMatchmakingRuleSet</a> | <a>DescribeMatchmakingRuleSets</a> | <a>ValidateMatchmakingRuleSet</a>
        /// | <a>DeleteMatchmakingRuleSet</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DeleteMatchmakingRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchmakingRuleSet operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMatchmakingRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteMatchmakingRuleSet">REST API Reference for DeleteMatchmakingRuleSet Operation</seealso>
        IAsyncResult BeginDeleteMatchmakingRuleSet(DeleteMatchmakingRuleSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMatchmakingRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMatchmakingRuleSet.</param>
        /// 
        /// <returns>Returns a  DeleteMatchmakingRuleSetResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteMatchmakingRuleSet">REST API Reference for DeleteMatchmakingRuleSet Operation</seealso>
        DeleteMatchmakingRuleSetResponse EndDeleteMatchmakingRuleSet(IAsyncResult asyncResult);

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
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>DescribeFleetCapacity</a> | <a>UpdateFleetCapacity</a> | <a>DescribeEC2InstanceLimits</a>
        /// | <a>PutScalingPolicy</a> | <a>DescribeScalingPolicies</a> | <a>DeleteScalingPolicy</a>
        /// | <a>StopFleetActions</a> | <a>StartFleetActions</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DeleteScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScalingPolicy operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteScalingPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteScalingPolicy">REST API Reference for DeleteScalingPolicy Operation</seealso>
        IAsyncResult BeginDeleteScalingPolicy(DeleteScalingPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScalingPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteScalingPolicyResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteScalingPolicy">REST API Reference for DeleteScalingPolicy Operation</seealso>
        DeleteScalingPolicyResponse EndDeleteScalingPolicy(IAsyncResult asyncResult);

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
        /// Web Services Realtime Servers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateScript</a> | <a>ListScripts</a> | <a>DescribeScript</a> | <a>UpdateScript</a>
        /// | <a>DeleteScript</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DeleteScript operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScript operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteScript
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteScript">REST API Reference for DeleteScript Operation</seealso>
        IAsyncResult BeginDeleteScript(DeleteScriptRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteScript operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScript.</param>
        /// 
        /// <returns>Returns a  DeleteScriptResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteScript">REST API Reference for DeleteScript Operation</seealso>
        DeleteScriptResponse EndDeleteScript(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVpcPeeringAuthorization


        /// <summary>
        /// Cancels a pending VPC peering authorization for the specified VPC. If you need to
        /// delete an existing VPC peering connection, call <a>DeleteVpcPeeringConnection</a>.
        /// 
        /// 
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> | <a>DescribeVpcPeeringAuthorizations</a> |
        /// <a>DeleteVpcPeeringAuthorization</a> | <a>CreateVpcPeeringConnection</a> | <a>DescribeVpcPeeringConnections</a>
        /// | <a>DeleteVpcPeeringConnection</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DeleteVpcPeeringAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringAuthorization operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcPeeringAuthorization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteVpcPeeringAuthorization">REST API Reference for DeleteVpcPeeringAuthorization Operation</seealso>
        IAsyncResult BeginDeleteVpcPeeringAuthorization(DeleteVpcPeeringAuthorizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcPeeringAuthorization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcPeeringAuthorization.</param>
        /// 
        /// <returns>Returns a  DeleteVpcPeeringAuthorizationResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteVpcPeeringAuthorization">REST API Reference for DeleteVpcPeeringAuthorization Operation</seealso>
        DeleteVpcPeeringAuthorizationResponse EndDeleteVpcPeeringAuthorization(IAsyncResult asyncResult);

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
        /// Once a valid authorization exists, call this operation from the Amazon Web Services
        /// account that is used to manage the Amazon Web Services fleets. Identify the connection
        /// to delete by the connection ID and fleet ID. If successful, the connection is removed.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> | <a>DescribeVpcPeeringAuthorizations</a> |
        /// <a>DeleteVpcPeeringAuthorization</a> | <a>CreateVpcPeeringConnection</a> | <a>DescribeVpcPeeringConnections</a>
        /// | <a>DeleteVpcPeeringConnection</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DeleteVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringConnection operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcPeeringConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteVpcPeeringConnection">REST API Reference for DeleteVpcPeeringConnection Operation</seealso>
        IAsyncResult BeginDeleteVpcPeeringConnection(DeleteVpcPeeringConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcPeeringConnection.</param>
        /// 
        /// <returns>Returns a  DeleteVpcPeeringConnectionResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteVpcPeeringConnection">REST API Reference for DeleteVpcPeeringConnection Operation</seealso>
        DeleteVpcPeeringConnectionResponse EndDeleteVpcPeeringConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterGameServer


        /// <summary>
        /// <b>This operation is used with the GameLift FleetIQ solution and game server groups.</b>
        /// 
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>RegisterGameServer</a> | <a>ListGameServers</a> | <a>ClaimGameServer</a> | <a>DescribeGameServer</a>
        /// | <a>UpdateGameServer</a> | <a>DeregisterGameServer</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/reference-awssdk-fleetiq.html">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DeregisterGameServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterGameServer operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterGameServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeregisterGameServer">REST API Reference for DeregisterGameServer Operation</seealso>
        IAsyncResult BeginDeregisterGameServer(DeregisterGameServerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterGameServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterGameServer.</param>
        /// 
        /// <returns>Returns a  DeregisterGameServerResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeregisterGameServer">REST API Reference for DeregisterGameServer Operation</seealso>
        DeregisterGameServerResponse EndDeregisterGameServer(IAsyncResult asyncResult);

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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateAlias</a> | <a>ListAliases</a> | <a>DescribeAlias</a> | <a>UpdateAlias</a>
        /// | <a>DeleteAlias</a> | <a>ResolveAlias</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateAlias</a> | <a>ListAliases</a> | <a>DescribeAlias</a> | <a>UpdateAlias</a>
        /// | <a>DeleteAlias</a> | <a>ResolveAlias</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlias operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeAlias">REST API Reference for DescribeAlias Operation</seealso>
        IAsyncResult BeginDescribeAlias(DescribeAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlias.</param>
        /// 
        /// <returns>Returns a  DescribeAliasResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeAlias">REST API Reference for DescribeAlias Operation</seealso>
        DescribeAliasResponse EndDescribeAlias(IAsyncResult asyncResult);

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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateBuild</a> | <a>ListBuilds</a> | <a>DescribeBuild</a> | <a>UpdateBuild</a>
        /// | <a>DeleteBuild</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
        /// </summary>
        /// <param name="buildId">A unique identifier for the build to retrieve properties for. You can use either the build ID or ARN value. </param>
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateBuild</a> | <a>ListBuilds</a> | <a>DescribeBuild</a> | <a>UpdateBuild</a>
        /// | <a>DeleteBuild</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBuild operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBuild
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeBuild">REST API Reference for DescribeBuild Operation</seealso>
        IAsyncResult BeginDescribeBuild(DescribeBuildRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBuild operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBuild.</param>
        /// 
        /// <returns>Returns a  DescribeBuildResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeBuild">REST API Reference for DescribeBuild Operation</seealso>
        DescribeBuildResponse EndDescribeBuild(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEC2InstanceLimits


        /// <summary>
        /// Retrieves the instance limits and current utilization for an Amazon Web Services Region
        /// or location. Instance limits control the number of instances, per instance type, per
        /// location, that your Amazon Web Services account can use. Learn more at <a href="http://aws.amazon.com/ec2/instance-types/">Amazon
        /// EC2 Instance Types</a>. The information returned includes the maximum number of instances
        /// allowed and your account's current usage across all fleets. This information can affect
        /// your ability to scale your GameLift fleets. You can request a limit increase for your
        /// account by using the <b>Service limits</b> page in the GameLift console.
        /// 
        ///  
        /// <para>
        /// Instance limits differ based on whether the instances are deployed in a fleet's home
        /// Region or in a remote location. For remote locations, limits also differ based on
        /// the combination of home Region and remote location. All requests must specify an Amazon
        /// Web Services Region (either explicitly or as your default settings). To get the limit
        /// for a remote location, you must also specify the location. For example, the following
        /// requests all return different results: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Request specifies the Region <code>ap-northeast-1</code> with no location. The result
        /// is limits and usage data on all instance types that are deployed in <code>us-east-2</code>,
        /// by all of the fleets that reside in <code>ap-northeast-1</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Request specifies the Region <code>us-east-1</code> with location <code>ca-central-1</code>.
        /// The result is limits and usage data on all instance types that are deployed in <code>ca-central-1</code>,
        /// by all of the fleets that reside in <code>us-east-2</code>. These limits do not affect
        /// fleets in any other Regions that deploy instances to <code>ca-central-1</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Request specifies the Region <code>eu-west-1</code> with location <code>ca-central-1</code>.
        /// The result is limits and usage data on all instance types that are deployed in <code>ca-central-1</code>,
        /// by all of the fleets that reside in <code>eu-west-1</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation can be used in the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To get limit and usage data for all instance types that are deployed in an Amazon
        /// Web Services Region by fleets that reside in the same Region: Specify the Region only.
        /// Optionally, specify a single instance type to retrieve information for.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To get limit and usage data for all instance types that are deployed to a remote location
        /// by fleets that reside in different Amazon Web Services Region: Provide both the Amazon
        /// Web Services Region and the remote location. Optionally, specify a single instance
        /// type to retrieve information for.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If successful, an <code>EC2InstanceLimits</code> object is returned with limits and
        /// usage data for each requested instance type.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateFleet</a> | <a>UpdateFleetCapacity</a> | <a>PutScalingPolicy</a> | <a>DescribeEC2InstanceLimits</a>
        /// | <a>DescribeFleetAttributes</a> | <a>DescribeFleetLocationAttributes</a> | <a>UpdateFleetAttributes</a>
        /// | <a>StopFleetActions</a> | <a>DeleteFleet</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
        /// </summary>
        /// <param name="ec2InstanceType">Name of an Amazon EC2 instance type that is supported in GameLift. A fleet instance type determines the computing resources of each instance in the fleet, including CPU, memory, storage, and networking capacity. Do not specify a value for this parameter to retrieve limits for all instance types.</param>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeEC2InstanceLimits">REST API Reference for DescribeEC2InstanceLimits Operation</seealso>
        DescribeEC2InstanceLimitsResponse DescribeEC2InstanceLimits(EC2InstanceType ec2InstanceType);

        /// <summary>
        /// Retrieves the instance limits and current utilization for an Amazon Web Services Region
        /// or location. Instance limits control the number of instances, per instance type, per
        /// location, that your Amazon Web Services account can use. Learn more at <a href="http://aws.amazon.com/ec2/instance-types/">Amazon
        /// EC2 Instance Types</a>. The information returned includes the maximum number of instances
        /// allowed and your account's current usage across all fleets. This information can affect
        /// your ability to scale your GameLift fleets. You can request a limit increase for your
        /// account by using the <b>Service limits</b> page in the GameLift console.
        /// 
        ///  
        /// <para>
        /// Instance limits differ based on whether the instances are deployed in a fleet's home
        /// Region or in a remote location. For remote locations, limits also differ based on
        /// the combination of home Region and remote location. All requests must specify an Amazon
        /// Web Services Region (either explicitly or as your default settings). To get the limit
        /// for a remote location, you must also specify the location. For example, the following
        /// requests all return different results: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Request specifies the Region <code>ap-northeast-1</code> with no location. The result
        /// is limits and usage data on all instance types that are deployed in <code>us-east-2</code>,
        /// by all of the fleets that reside in <code>ap-northeast-1</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Request specifies the Region <code>us-east-1</code> with location <code>ca-central-1</code>.
        /// The result is limits and usage data on all instance types that are deployed in <code>ca-central-1</code>,
        /// by all of the fleets that reside in <code>us-east-2</code>. These limits do not affect
        /// fleets in any other Regions that deploy instances to <code>ca-central-1</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Request specifies the Region <code>eu-west-1</code> with location <code>ca-central-1</code>.
        /// The result is limits and usage data on all instance types that are deployed in <code>ca-central-1</code>,
        /// by all of the fleets that reside in <code>eu-west-1</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation can be used in the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To get limit and usage data for all instance types that are deployed in an Amazon
        /// Web Services Region by fleets that reside in the same Region: Specify the Region only.
        /// Optionally, specify a single instance type to retrieve information for.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To get limit and usage data for all instance types that are deployed to a remote location
        /// by fleets that reside in different Amazon Web Services Region: Provide both the Amazon
        /// Web Services Region and the remote location. Optionally, specify a single instance
        /// type to retrieve information for.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If successful, an <code>EC2InstanceLimits</code> object is returned with limits and
        /// usage data for each requested instance type.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateFleet</a> | <a>UpdateFleetCapacity</a> | <a>PutScalingPolicy</a> | <a>DescribeEC2InstanceLimits</a>
        /// | <a>DescribeFleetAttributes</a> | <a>DescribeFleetLocationAttributes</a> | <a>UpdateFleetAttributes</a>
        /// | <a>StopFleetActions</a> | <a>DeleteFleet</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeEC2InstanceLimits">REST API Reference for DescribeEC2InstanceLimits Operation</seealso>
        DescribeEC2InstanceLimitsResponse DescribeEC2InstanceLimits(DescribeEC2InstanceLimitsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEC2InstanceLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEC2InstanceLimits operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEC2InstanceLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeEC2InstanceLimits">REST API Reference for DescribeEC2InstanceLimits Operation</seealso>
        IAsyncResult BeginDescribeEC2InstanceLimits(DescribeEC2InstanceLimitsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEC2InstanceLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEC2InstanceLimits.</param>
        /// 
        /// <returns>Returns a  DescribeEC2InstanceLimitsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeEC2InstanceLimits">REST API Reference for DescribeEC2InstanceLimits Operation</seealso>
        DescribeEC2InstanceLimitsResponse EndDescribeEC2InstanceLimits(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFleetAttributes


        /// <summary>
        /// Retrieves core fleet-wide properties, including the computing hardware and deployment
        /// configuration for all instances in the fleet.
        /// 
        ///  
        /// <para>
        /// This operation can be used in the following ways: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To get attributes for one or more specific fleets, provide a list of fleet IDs or
        /// fleet ARNs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To get attributes for all fleets, do not provide a fleet identifier. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When requesting attributes for multiple fleets, use the pagination parameters to retrieve
        /// results as a set of sequential pages. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a <code>FleetAttributes</code> object is returned for each fleet requested,
        /// unless the fleet identifier is not found. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Some API operations limit the number of fleet IDs that allowed in one request. If
        /// a request exceeds this limit, the request fails and the error message contains the
        /// maximum allowed number.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>ListFleets</a> | <a>DescribeEC2InstanceLimits</a> | <a>DescribeFleetAttributes</a>
        /// | <a>DescribeFleetCapacity</a> | <a>DescribeFleetEvents</a> | <a>DescribeFleetLocationAttributes</a>
        /// | <a>DescribeFleetPortSettings</a> | <a>DescribeFleetUtilization</a> | <a>DescribeRuntimeConfiguration</a>
        /// | <a>DescribeScalingPolicies</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeFleetAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAttributes operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetAttributes">REST API Reference for DescribeFleetAttributes Operation</seealso>
        IAsyncResult BeginDescribeFleetAttributes(DescribeFleetAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeFleetAttributesResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetAttributes">REST API Reference for DescribeFleetAttributes Operation</seealso>
        DescribeFleetAttributesResponse EndDescribeFleetAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFleetCapacity


        /// <summary>
        /// Retrieves the resource capacity settings for one or more fleets. The data returned
        /// includes the current fleet capacity (number of EC2 instances), and settings that can
        /// control how capacity scaling. For fleets with remote locations, this operation retrieves
        /// data for the fleet's home Region only. See <a>DescribeFleetLocationCapacity</a> to
        /// get capacity settings for a fleet's remote locations.
        /// 
        ///  
        /// <para>
        /// This operation can be used in the following ways: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To get capacity data for one or more specific fleets, provide a list of fleet IDs
        /// or fleet ARNs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To get capacity data for all fleets, do not provide a fleet identifier. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When requesting multiple fleets, use the pagination parameters to retrieve results
        /// as a set of sequential pages. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a <a>FleetCapacity</a> object is returned for each requested fleet
        /// ID. Each FleetCapacity object includes a <code>Location</code> property, which is
        /// set to the fleet's home Region. When a list of fleet IDs is provided, attribute objects
        /// are returned only for fleets that currently exist.
        /// </para>
        ///  <note> 
        /// <para>
        /// Some API operations may limit the number of fleet IDs that are allowed in one request.
        /// If a request exceeds this limit, the request fails and the error message includes
        /// the maximum allowed.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/monitoring-cloudwatch.html#gamelift-metrics-fleet">GameLift
        /// metrics for fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>ListFleets</a> | <a>DescribeEC2InstanceLimits</a> | <a>DescribeFleetAttributes</a>
        /// | <a>DescribeFleetCapacity</a> | <a>DescribeFleetEvents</a> | <a>DescribeFleetLocationAttributes</a>
        /// | <a>DescribeFleetPortSettings</a> | <a>DescribeFleetUtilization</a> | <a>DescribeRuntimeConfiguration</a>
        /// | <a>DescribeScalingPolicies</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeFleetCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetCapacity operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetCapacity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetCapacity">REST API Reference for DescribeFleetCapacity Operation</seealso>
        IAsyncResult BeginDescribeFleetCapacity(DescribeFleetCapacityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetCapacity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetCapacity.</param>
        /// 
        /// <returns>Returns a  DescribeFleetCapacityResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetCapacity">REST API Reference for DescribeFleetCapacity Operation</seealso>
        DescribeFleetCapacityResponse EndDescribeFleetCapacity(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFleetEvents


        /// <summary>
        /// Retrieves entries from a fleet's event log. Fleet events are initiated by changes
        /// in status, such as during fleet creation and termination, changes in capacity, etc.
        /// If a fleet has multiple locations, events are also initiated by changes to status
        /// and capacity in remote locations. 
        /// 
        ///  
        /// <para>
        /// You can specify a time range to limit the result set. Use the pagination parameters
        /// to retrieve results as a set of sequential pages. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a collection of event log entries matching the request are returned.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>ListFleets</a> | <a>DescribeEC2InstanceLimits</a> | <a>DescribeFleetAttributes</a>
        /// | <a>DescribeFleetCapacity</a> | <a>DescribeFleetEvents</a> | <a>DescribeFleetLocationAttributes</a>
        /// | <a>DescribeFleetPortSettings</a> | <a>DescribeFleetUtilization</a> | <a>DescribeRuntimeConfiguration</a>
        /// | <a>DescribeScalingPolicies</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeFleetEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetEvents operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetEvents">REST API Reference for DescribeFleetEvents Operation</seealso>
        IAsyncResult BeginDescribeFleetEvents(DescribeFleetEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetEvents.</param>
        /// 
        /// <returns>Returns a  DescribeFleetEventsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetEvents">REST API Reference for DescribeFleetEvents Operation</seealso>
        DescribeFleetEventsResponse EndDescribeFleetEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFleetLocationAttributes


        /// <summary>
        /// Retrieves information on a fleet's remote locations, including life-cycle status and
        /// any suspended fleet activity. 
        /// 
        ///  
        /// <para>
        /// This operation can be used in the following ways: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To get data for specific locations, provide a fleet identifier and a list of locations.
        /// Location data is returned in the order that it is requested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To get data for all locations, provide a fleet identifier only. Location data is returned
        /// in no particular order. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When requesting attributes for multiple locations, use the pagination parameters to
        /// retrieve results as a set of sequential pages. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a <code>LocationAttributes</code> object is returned for each requested
        /// location. If the fleet does not have a requested location, no information is returned.
        /// This operation does not return the home Region. To get information on a fleet's home
        /// Region, call <code>DescribeFleetAttributes</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateFleetLocations</a> | <a>DescribeFleetLocationAttributes</a> | <a>DescribeFleetLocationCapacity</a>
        /// | <a>DescribeFleetLocationUtilization</a> | <a>DescribeFleetAttributes</a> | <a>DescribeFleetCapacity</a>
        /// | <a>DescribeFleetUtilization</a> | <a>UpdateFleetCapacity</a> | <a>StopFleetActions</a>
        /// | <a>DeleteFleetLocations</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetLocationAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetLocationAttributes service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetLocationAttributes">REST API Reference for DescribeFleetLocationAttributes Operation</seealso>
        DescribeFleetLocationAttributesResponse DescribeFleetLocationAttributes(DescribeFleetLocationAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetLocationAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetLocationAttributes operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetLocationAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetLocationAttributes">REST API Reference for DescribeFleetLocationAttributes Operation</seealso>
        IAsyncResult BeginDescribeFleetLocationAttributes(DescribeFleetLocationAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetLocationAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetLocationAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeFleetLocationAttributesResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetLocationAttributes">REST API Reference for DescribeFleetLocationAttributes Operation</seealso>
        DescribeFleetLocationAttributesResponse EndDescribeFleetLocationAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFleetLocationCapacity


        /// <summary>
        /// Retrieves the resource capacity settings for a fleet location. The data returned includes
        /// the current capacity (number of EC2 instances) and some scaling settings for the requested
        /// fleet location. Use this operation to retrieve capacity information for a fleet's
        /// remote location or home Region (you can also retrieve home Region capacity by calling
        /// <code>DescribeFleetCapacity</code>).
        /// 
        ///  
        /// <para>
        /// To retrieve capacity data, identify a fleet and location. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a <code>FleetCapacity</code> object is returned for the requested fleet
        /// location. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/monitoring-cloudwatch.html#gamelift-metrics-fleet">GameLift
        /// metrics for fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateFleetLocations</a> | <a>DescribeFleetLocationAttributes</a> | <a>DescribeFleetLocationCapacity</a>
        /// | <a>DescribeFleetLocationUtilization</a> | <a>DescribeFleetAttributes</a> | <a>DescribeFleetCapacity</a>
        /// | <a>DescribeFleetUtilization</a> | <a>UpdateFleetCapacity</a> | <a>StopFleetActions</a>
        /// | <a>DeleteFleetLocations</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetLocationCapacity service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetLocationCapacity service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetLocationCapacity">REST API Reference for DescribeFleetLocationCapacity Operation</seealso>
        DescribeFleetLocationCapacityResponse DescribeFleetLocationCapacity(DescribeFleetLocationCapacityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetLocationCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetLocationCapacity operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetLocationCapacity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetLocationCapacity">REST API Reference for DescribeFleetLocationCapacity Operation</seealso>
        IAsyncResult BeginDescribeFleetLocationCapacity(DescribeFleetLocationCapacityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetLocationCapacity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetLocationCapacity.</param>
        /// 
        /// <returns>Returns a  DescribeFleetLocationCapacityResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetLocationCapacity">REST API Reference for DescribeFleetLocationCapacity Operation</seealso>
        DescribeFleetLocationCapacityResponse EndDescribeFleetLocationCapacity(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFleetLocationUtilization


        /// <summary>
        /// Retrieves current usage data for a fleet location. Utilization data provides a snapshot
        /// of current game hosting activity at the requested location. Use this operation to
        /// retrieve utilization information for a fleet's remote location or home Region (you
        /// can also retrieve home Region utilization by calling <code>DescribeFleetUtilization</code>).
        /// 
        ///  
        /// <para>
        /// To retrieve utilization data, identify a fleet and location. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a <code>FleetUtilization</code> object is returned for the requested
        /// fleet location. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/monitoring-cloudwatch.html#gamelift-metrics-fleet">GameLift
        /// metrics for fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateFleetLocations</a> | <a>DescribeFleetLocationAttributes</a> | <a>DescribeFleetLocationCapacity</a>
        /// | <a>DescribeFleetLocationUtilization</a> | <a>DescribeFleetAttributes</a> | <a>DescribeFleetCapacity</a>
        /// | <a>DescribeFleetUtilization</a> | <a>UpdateFleetCapacity</a> | <a>StopFleetActions</a>
        /// | <a>DeleteFleetLocations</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetLocationUtilization service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetLocationUtilization service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetLocationUtilization">REST API Reference for DescribeFleetLocationUtilization Operation</seealso>
        DescribeFleetLocationUtilizationResponse DescribeFleetLocationUtilization(DescribeFleetLocationUtilizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetLocationUtilization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetLocationUtilization operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetLocationUtilization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetLocationUtilization">REST API Reference for DescribeFleetLocationUtilization Operation</seealso>
        IAsyncResult BeginDescribeFleetLocationUtilization(DescribeFleetLocationUtilizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetLocationUtilization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetLocationUtilization.</param>
        /// 
        /// <returns>Returns a  DescribeFleetLocationUtilizationResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetLocationUtilization">REST API Reference for DescribeFleetLocationUtilization Operation</seealso>
        DescribeFleetLocationUtilizationResponse EndDescribeFleetLocationUtilization(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFleetPortSettings


        /// <summary>
        /// Retrieves a fleet's inbound connection permissions. Connection permissions specify
        /// the range of IP addresses and port settings that incoming traffic can use to access
        /// server processes in the fleet. Game sessions that are running on instances in the
        /// fleet must use connections that fall in this range.
        /// 
        ///  
        /// <para>
        /// This operation can be used in the following ways: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To retrieve the inbound connection permissions for a fleet, identify the fleet's unique
        /// identifier. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To check the status of recent updates to a fleet remote location, specify the fleet
        /// ID and a location. Port setting updates can take time to propagate across all locations.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If successful, a set of <a>IpPermission</a> objects is returned for the requested
        /// fleet ID. When a location is specified, a pending status is included. If the requested
        /// fleet has been deleted, the result set is empty.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>ListFleets</a> | <a>DescribeEC2InstanceLimits</a> | <a>DescribeFleetAttributes</a>
        /// | <a>DescribeFleetCapacity</a> | <a>DescribeFleetEvents</a> | <a>DescribeFleetLocationAttributes</a>
        /// | <a>DescribeFleetPortSettings</a> | <a>DescribeFleetUtilization</a> | <a>DescribeRuntimeConfiguration</a>
        /// | <a>DescribeScalingPolicies</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
        /// </summary>
        /// <param name="fleetId">A unique identifier for the fleet to retrieve port settings for. You can use either the fleet ID or ARN value.</param>
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
        /// fleet must use connections that fall in this range.
        /// 
        ///  
        /// <para>
        /// This operation can be used in the following ways: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To retrieve the inbound connection permissions for a fleet, identify the fleet's unique
        /// identifier. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To check the status of recent updates to a fleet remote location, specify the fleet
        /// ID and a location. Port setting updates can take time to propagate across all locations.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If successful, a set of <a>IpPermission</a> objects is returned for the requested
        /// fleet ID. When a location is specified, a pending status is included. If the requested
        /// fleet has been deleted, the result set is empty.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>ListFleets</a> | <a>DescribeEC2InstanceLimits</a> | <a>DescribeFleetAttributes</a>
        /// | <a>DescribeFleetCapacity</a> | <a>DescribeFleetEvents</a> | <a>DescribeFleetLocationAttributes</a>
        /// | <a>DescribeFleetPortSettings</a> | <a>DescribeFleetUtilization</a> | <a>DescribeRuntimeConfiguration</a>
        /// | <a>DescribeScalingPolicies</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeFleetPortSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetPortSettings operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetPortSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetPortSettings">REST API Reference for DescribeFleetPortSettings Operation</seealso>
        IAsyncResult BeginDescribeFleetPortSettings(DescribeFleetPortSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetPortSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetPortSettings.</param>
        /// 
        /// <returns>Returns a  DescribeFleetPortSettingsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetPortSettings">REST API Reference for DescribeFleetPortSettings Operation</seealso>
        DescribeFleetPortSettingsResponse EndDescribeFleetPortSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFleetUtilization


        /// <summary>
        /// Retrieves utilization statistics for one or more fleets. Utilization data provides
        /// a snapshot of how the fleet's hosting resources are currently being used. For fleets
        /// with remote locations, this operation retrieves data for the fleet's home Region only.
        /// See <a>DescribeFleetLocationUtilization</a> to get utilization statistics for a fleet's
        /// remote locations.
        /// 
        ///  
        /// <para>
        /// This operation can be used in the following ways: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To get utilization data for one or more specific fleets, provide a list of fleet IDs
        /// or fleet ARNs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To get utilization data for all fleets, do not provide a fleet identifier. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When requesting multiple fleets, use the pagination parameters to retrieve results
        /// as a set of sequential pages. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a <a>FleetUtilization</a> object is returned for each requested fleet
        /// ID, unless the fleet identifier is not found. Each fleet utilization object includes
        /// a <code>Location</code> property, which is set to the fleet's home Region. 
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>ListFleets</a> | <a>DescribeEC2InstanceLimits</a> | <a>DescribeFleetAttributes</a>
        /// | <a>DescribeFleetCapacity</a> | <a>DescribeFleetEvents</a> | <a>DescribeFleetLocationAttributes</a>
        /// | <a>DescribeFleetPortSettings</a> | <a>DescribeFleetUtilization</a> | <a>DescribeRuntimeConfiguration</a>
        /// | <a>DescribeScalingPolicies</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeFleetUtilization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetUtilization operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetUtilization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetUtilization">REST API Reference for DescribeFleetUtilization Operation</seealso>
        IAsyncResult BeginDescribeFleetUtilization(DescribeFleetUtilizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetUtilization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetUtilization.</param>
        /// 
        /// <returns>Returns a  DescribeFleetUtilizationResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetUtilization">REST API Reference for DescribeFleetUtilization Operation</seealso>
        DescribeFleetUtilizationResponse EndDescribeFleetUtilization(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeGameServer


        /// <summary>
        /// <b>This operation is used with the GameLift FleetIQ solution and game server groups.</b>
        /// 
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>RegisterGameServer</a> | <a>ListGameServers</a> | <a>ClaimGameServer</a> | <a>DescribeGameServer</a>
        /// | <a>UpdateGameServer</a> | <a>DeregisterGameServer</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/reference-awssdk-fleetiq.html">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeGameServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameServer operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGameServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameServer">REST API Reference for DescribeGameServer Operation</seealso>
        IAsyncResult BeginDescribeGameServer(DescribeGameServerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGameServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGameServer.</param>
        /// 
        /// <returns>Returns a  DescribeGameServerResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameServer">REST API Reference for DescribeGameServer Operation</seealso>
        DescribeGameServerResponse EndDescribeGameServer(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeGameServerGroup


        /// <summary>
        /// <b>This operation is used with the GameLift FleetIQ solution and game server groups.</b>
        /// 
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateGameServerGroup</a> | <a>ListGameServerGroups</a> | <a>DescribeGameServerGroup</a>
        /// | <a>UpdateGameServerGroup</a> | <a>DeleteGameServerGroup</a> | <a>ResumeGameServerGroup</a>
        /// | <a>SuspendGameServerGroup</a> | <a>DescribeGameServerInstances</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/reference-awssdk-fleetiq.html">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameServerGroup operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGameServerGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameServerGroup">REST API Reference for DescribeGameServerGroup Operation</seealso>
        IAsyncResult BeginDescribeGameServerGroup(DescribeGameServerGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGameServerGroup.</param>
        /// 
        /// <returns>Returns a  DescribeGameServerGroupResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameServerGroup">REST API Reference for DescribeGameServerGroup Operation</seealso>
        DescribeGameServerGroupResponse EndDescribeGameServerGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeGameServerInstances


        /// <summary>
        /// <b>This operation is used with the GameLift FleetIQ solution and game server groups.</b>
        /// 
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateGameServerGroup</a> | <a>ListGameServerGroups</a> | <a>DescribeGameServerGroup</a>
        /// | <a>UpdateGameServerGroup</a> | <a>DeleteGameServerGroup</a> | <a>ResumeGameServerGroup</a>
        /// | <a>SuspendGameServerGroup</a> | <a>DescribeGameServerInstances</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/reference-awssdk-fleetiq.html">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeGameServerInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameServerInstances operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGameServerInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameServerInstances">REST API Reference for DescribeGameServerInstances Operation</seealso>
        IAsyncResult BeginDescribeGameServerInstances(DescribeGameServerInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGameServerInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGameServerInstances.</param>
        /// 
        /// <returns>Returns a  DescribeGameServerInstancesResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameServerInstances">REST API Reference for DescribeGameServerInstances Operation</seealso>
        DescribeGameServerInstancesResponse EndDescribeGameServerInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeGameSessionDetails


        /// <summary>
        /// Retrieves additional game session properties, including the game session protection
        /// policy in force, a set of one or more game sessions in a specific fleet location.
        /// You can optionally filter the results by current game session status. Alternatively,
        /// use <a>SearchGameSessions</a> to request a set of active game sessions that are filtered
        /// by certain criteria. To retrieve all game session properties, use <a>DescribeGameSessions</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// This operation can be used in the following ways: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To retrieve details for all game sessions that are currently running on all locations
        /// in a fleet, provide a fleet or alias ID, with an optional status filter. This approach
        /// returns details from the fleet's home Region and all remote locations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To retrieve details for all game sessions that are currently running on a specific
        /// fleet location, provide a fleet or alias ID and a location name, with optional status
        /// filter. The location can be the fleet's home Region or any remote location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To retrieve details for a specific game session, provide the game session ID. This
        /// approach looks for the game session ID in all fleets that reside in the Amazon Web
        /// Services Region defined in the request.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Use the pagination parameters to retrieve results as a set of sequential pages. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a <code>GameSessionDetail</code> object is returned for each game session
        /// that matches the request.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-client-api.html#gamelift-sdk-client-api-find">Find
        /// a game session</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateGameSession</a> | <a>DescribeGameSessions</a> | <a>DescribeGameSessionDetails</a>
        /// | <a>SearchGameSessions</a> | <a>UpdateGameSession</a> | <a>GetGameSessionLogUrl</a>
        /// | <a>StartGameSessionPlacement</a> | <a>DescribeGameSessionPlacement</a> | <a>StopGameSessionPlacement</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionDetails">REST API Reference for DescribeGameSessionDetails Operation</seealso>
        DescribeGameSessionDetailsResponse DescribeGameSessionDetails(DescribeGameSessionDetailsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGameSessionDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessionDetails operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGameSessionDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionDetails">REST API Reference for DescribeGameSessionDetails Operation</seealso>
        IAsyncResult BeginDescribeGameSessionDetails(DescribeGameSessionDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGameSessionDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGameSessionDetails.</param>
        /// 
        /// <returns>Returns a  DescribeGameSessionDetailsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionDetails">REST API Reference for DescribeGameSessionDetails Operation</seealso>
        DescribeGameSessionDetailsResponse EndDescribeGameSessionDetails(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeGameSessionPlacement


        /// <summary>
        /// Retrieves information, including current status, about a game session placement request.
        /// 
        /// 
        ///  
        /// <para>
        /// To get game session placement details, specify the placement ID.
        /// </para>
        ///  
        /// <para>
        /// This operation is not designed to be continually called to track game session status.
        /// This practice can cause you to exceed your API limit, which results in errors. Instead,
        /// you must configure configure an Amazon Simple Notification Service (SNS) topic to
        /// receive notifications from FlexMatch or queues. Continuously polling with <code>DescribeGameSessionPlacement</code>
        /// should only be used for games in development with low game session usage. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a <a>GameSessionPlacement</a> object is returned.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateGameSession</a> | <a>DescribeGameSessions</a> | <a>DescribeGameSessionDetails</a>
        /// | <a>SearchGameSessions</a> | <a>UpdateGameSession</a> | <a>GetGameSessionLogUrl</a>
        /// | <a>StartGameSessionPlacement</a> | <a>DescribeGameSessionPlacement</a> | <a>StopGameSessionPlacement</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeGameSessionPlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessionPlacement operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGameSessionPlacement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionPlacement">REST API Reference for DescribeGameSessionPlacement Operation</seealso>
        IAsyncResult BeginDescribeGameSessionPlacement(DescribeGameSessionPlacementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGameSessionPlacement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGameSessionPlacement.</param>
        /// 
        /// <returns>Returns a  DescribeGameSessionPlacementResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionPlacement">REST API Reference for DescribeGameSessionPlacement Operation</seealso>
        DescribeGameSessionPlacementResponse EndDescribeGameSessionPlacement(IAsyncResult asyncResult);

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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateGameSessionQueue.html">CreateGameSessionQueue</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeGameSessionQueues.html">DescribeGameSessionQueues</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_UpdateGameSessionQueue.html">UpdateGameSessionQueue</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DeleteGameSessionQueue.html">DeleteGameSessionQueue</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeGameSessionQueues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessionQueues operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGameSessionQueues
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionQueues">REST API Reference for DescribeGameSessionQueues Operation</seealso>
        IAsyncResult BeginDescribeGameSessionQueues(DescribeGameSessionQueuesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGameSessionQueues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGameSessionQueues.</param>
        /// 
        /// <returns>Returns a  DescribeGameSessionQueuesResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionQueues">REST API Reference for DescribeGameSessionQueues Operation</seealso>
        DescribeGameSessionQueuesResponse EndDescribeGameSessionQueues(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeGameSessions


        /// <summary>
        /// Retrieves a set of one or more game sessions in a specific fleet location. You can
        /// optionally filter the results by current game session status. Alternatively, use <a>SearchGameSessions</a>
        /// to request a set of active game sessions that are filtered by certain criteria. To
        /// retrieve the protection policy for game sessions, use <a>DescribeGameSessionDetails</a>.
        /// 
        ///  
        /// <para>
        /// This operation is not designed to be continually called to track game session status.
        /// This practice can cause you to exceed your API limit, which results in errors. Instead,
        /// you must configure configure an Amazon Simple Notification Service (SNS) topic to
        /// receive notifications from FlexMatch or queues. Continuously polling with <code>DescribeGameSessions</code>
        /// should only be used for games in development with low game session usage. 
        /// </para>
        ///  
        /// <para>
        /// This operation can be used in the following ways: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To retrieve all game sessions that are currently running on all locations in a fleet,
        /// provide a fleet or alias ID, with an optional status filter. This approach returns
        /// all game sessions in the fleet's home Region and all remote locations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To retrieve all game sessions that are currently running on a specific fleet location,
        /// provide a fleet or alias ID and a location name, with optional status filter. The
        /// location can be the fleet's home Region or any remote location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To retrieve a specific game session, provide the game session ID. This approach looks
        /// for the game session ID in all fleets that reside in the Amazon Web Services Region
        /// defined in the request.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Use the pagination parameters to retrieve results as a set of sequential pages. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a <code>GameSession</code> object is returned for each game session
        /// that matches the request.
        /// </para>
        ///  
        /// <para>
        /// This operation is not designed to be continually called to track matchmaking ticket
        /// status. This practice can cause you to exceed your API limit, which results in errors.
        /// Instead, as a best practice, set up an Amazon Simple Notification Service to receive
        /// notifications, and provide the topic ARN in the matchmaking configuration. Continuously
        /// poling ticket status with <a>DescribeGameSessions</a> should only be used for games
        /// in development with low matchmaking usage.
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon Web Services Local.</i> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-client-api.html#gamelift-sdk-client-api-find">Find
        /// a game session</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateGameSession</a> | <a>DescribeGameSessions</a> | <a>DescribeGameSessionDetails</a>
        /// | <a>SearchGameSessions</a> | <a>UpdateGameSession</a> | <a>GetGameSessionLogUrl</a>
        /// | <a>StartGameSessionPlacement</a> | <a>DescribeGameSessionPlacement</a> | <a>StopGameSessionPlacement</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessions">REST API Reference for DescribeGameSessions Operation</seealso>
        DescribeGameSessionsResponse DescribeGameSessions(DescribeGameSessionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGameSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessions operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGameSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessions">REST API Reference for DescribeGameSessions Operation</seealso>
        IAsyncResult BeginDescribeGameSessions(DescribeGameSessionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGameSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGameSessions.</param>
        /// 
        /// <returns>Returns a  DescribeGameSessionsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessions">REST API Reference for DescribeGameSessions Operation</seealso>
        DescribeGameSessionsResponse EndDescribeGameSessions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInstances


        /// <summary>
        /// Retrieves information about a fleet's instances, including instance IDs, connection
        /// data, and status. 
        /// 
        ///  
        /// <para>
        /// This operation can be used in the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To get information on all instances that are deployed to a fleet's home Region, provide
        /// the fleet ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To get information on all instances that are deployed to a fleet's remote location,
        /// provide the fleet ID and location name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To get information on a specific instance in a fleet, provide the fleet ID and instance
        /// ID.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Use the pagination parameters to retrieve results as a set of sequential pages. 
        /// </para>
        ///  
        /// <para>
        /// If successful, an <code>Instance</code> object is returned for each requested instance.
        /// Instances are not returned in any particular order. 
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>DescribeInstances</a> | <a>GetInstanceAccess</a> | <a>DescribeEC2InstanceLimits</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        IAsyncResult BeginDescribeInstances(DescribeInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstances.</param>
        /// 
        /// <returns>Returns a  DescribeInstancesResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        DescribeInstancesResponse EndDescribeInstances(IAsyncResult asyncResult);

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
        /// Instead, as a best practice, set up an Amazon Simple Notification Service to receive
        /// notifications, and provide the topic ARN in the matchmaking configuration. Continuously
        /// polling ticket status with <a>DescribeMatchmaking</a> should only be used for games
        /// in development with low matchmaking usage.
        /// </para>
        ///   
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-client.html">
        /// Add FlexMatch to a game client</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-notification.html">
        /// Set Up FlexMatch event notification</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>StartMatchmaking</a> | <a>DescribeMatchmaking</a> | <a>StopMatchmaking</a> | <a>AcceptMatch</a>
        /// | <a>StartMatchBackfill</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeMatchmaking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMatchmaking operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMatchmaking
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmaking">REST API Reference for DescribeMatchmaking Operation</seealso>
        IAsyncResult BeginDescribeMatchmaking(DescribeMatchmakingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMatchmaking operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMatchmaking.</param>
        /// 
        /// <returns>Returns a  DescribeMatchmakingResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmaking">REST API Reference for DescribeMatchmaking Operation</seealso>
        DescribeMatchmakingResponse EndDescribeMatchmaking(IAsyncResult asyncResult);

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
        /// Setting up FlexMatch matchmakers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> | <a>DescribeMatchmakingConfigurations</a>
        /// | <a>UpdateMatchmakingConfiguration</a> | <a>DeleteMatchmakingConfiguration</a> |
        /// <a>CreateMatchmakingRuleSet</a> | <a>DescribeMatchmakingRuleSets</a> | <a>ValidateMatchmakingRuleSet</a>
        /// | <a>DeleteMatchmakingRuleSet</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeMatchmakingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMatchmakingConfigurations operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMatchmakingConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmakingConfigurations">REST API Reference for DescribeMatchmakingConfigurations Operation</seealso>
        IAsyncResult BeginDescribeMatchmakingConfigurations(DescribeMatchmakingConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMatchmakingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMatchmakingConfigurations.</param>
        /// 
        /// <returns>Returns a  DescribeMatchmakingConfigurationsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmakingConfigurations">REST API Reference for DescribeMatchmakingConfigurations Operation</seealso>
        DescribeMatchmakingConfigurationsResponse EndDescribeMatchmakingConfigurations(IAsyncResult asyncResult);

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
        /// a rule set</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> | <a>DescribeMatchmakingConfigurations</a>
        /// | <a>UpdateMatchmakingConfiguration</a> | <a>DeleteMatchmakingConfiguration</a> |
        /// <a>CreateMatchmakingRuleSet</a> | <a>DescribeMatchmakingRuleSets</a> | <a>ValidateMatchmakingRuleSet</a>
        /// | <a>DeleteMatchmakingRuleSet</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeMatchmakingRuleSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMatchmakingRuleSets operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMatchmakingRuleSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmakingRuleSets">REST API Reference for DescribeMatchmakingRuleSets Operation</seealso>
        IAsyncResult BeginDescribeMatchmakingRuleSets(DescribeMatchmakingRuleSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMatchmakingRuleSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMatchmakingRuleSets.</param>
        /// 
        /// <returns>Returns a  DescribeMatchmakingRuleSetsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmakingRuleSets">REST API Reference for DescribeMatchmakingRuleSets Operation</seealso>
        DescribeMatchmakingRuleSetsResponse EndDescribeMatchmakingRuleSets(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePlayerSessions


        /// <summary>
        /// Retrieves properties for one or more player sessions. 
        /// 
        ///  
        /// <para>
        /// This action can be used in the following ways: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To retrieve a specific player session, provide the player session ID only.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To retrieve all player sessions in a game session, provide the game session ID only.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To retrieve all player sessions for a specific player, provide a player ID only.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To request player sessions, specify either a player session ID, game session ID, or
        /// player ID. You can filter this request by player session status. Use the pagination
        /// parameters to retrieve results as a set of sequential pages. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a <code>PlayerSession</code> object is returned for each session that
        /// matches the request.
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon Web Services Local.</i> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreatePlayerSession</a> | <a>CreatePlayerSessions</a> | <a>DescribePlayerSessions</a>
        /// | <a>StartGameSessionPlacement</a> | <a>DescribeGameSessionPlacement</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribePlayerSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlayerSessions operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePlayerSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribePlayerSessions">REST API Reference for DescribePlayerSessions Operation</seealso>
        IAsyncResult BeginDescribePlayerSessions(DescribePlayerSessionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePlayerSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePlayerSessions.</param>
        /// 
        /// <returns>Returns a  DescribePlayerSessionsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribePlayerSessions">REST API Reference for DescribePlayerSessions Operation</seealso>
        DescribePlayerSessionsResponse EndDescribePlayerSessions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRuntimeConfiguration


        /// <summary>
        /// Retrieves a fleet's runtime configuration settings. The runtime configuration tells
        /// GameLift which server processes to run (and how) on each instance in the fleet.
        /// 
        ///  
        /// <para>
        /// To get the runtime configuration that is currently in forces for a fleet, provide
        /// the fleet ID. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a <a>RuntimeConfiguration</a> object is returned for the requested
        /// fleet. If the requested fleet has been deleted, the result set is empty.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-multiprocess.html">Running
        /// multiple processes on a fleet</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>ListFleets</a> | <a>DescribeEC2InstanceLimits</a> | <a>DescribeFleetAttributes</a>
        /// | <a>DescribeFleetCapacity</a> | <a>DescribeFleetEvents</a> | <a>DescribeFleetLocationAttributes</a>
        /// | <a>DescribeFleetPortSettings</a> | <a>DescribeFleetUtilization</a> | <a>DescribeRuntimeConfiguration</a>
        /// | <a>DescribeScalingPolicies</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeRuntimeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuntimeConfiguration operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRuntimeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeRuntimeConfiguration">REST API Reference for DescribeRuntimeConfiguration Operation</seealso>
        IAsyncResult BeginDescribeRuntimeConfiguration(DescribeRuntimeConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRuntimeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRuntimeConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeRuntimeConfigurationResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeRuntimeConfiguration">REST API Reference for DescribeRuntimeConfiguration Operation</seealso>
        DescribeRuntimeConfigurationResponse EndDescribeRuntimeConfiguration(IAsyncResult asyncResult);

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
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>DescribeFleetCapacity</a> | <a>UpdateFleetCapacity</a> | <a>DescribeEC2InstanceLimits</a>
        /// | <a>PutScalingPolicy</a> | <a>DescribeScalingPolicies</a> | <a>DeleteScalingPolicy</a>
        /// | <a>StopFleetActions</a> | <a>StartFleetActions</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeScalingPolicies">REST API Reference for DescribeScalingPolicies Operation</seealso>
        DescribeScalingPoliciesResponse DescribeScalingPolicies(DescribeScalingPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPolicies operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScalingPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeScalingPolicies">REST API Reference for DescribeScalingPolicies Operation</seealso>
        IAsyncResult BeginDescribeScalingPolicies(DescribeScalingPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScalingPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingPolicies.</param>
        /// 
        /// <returns>Returns a  DescribeScalingPoliciesResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeScalingPolicies">REST API Reference for DescribeScalingPolicies Operation</seealso>
        DescribeScalingPoliciesResponse EndDescribeScalingPolicies(IAsyncResult asyncResult);

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
        /// Web Services Realtime Servers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateScript</a> | <a>ListScripts</a> | <a>DescribeScript</a> | <a>UpdateScript</a>
        /// | <a>DeleteScript</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeScript operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScript operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScript
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeScript">REST API Reference for DescribeScript Operation</seealso>
        IAsyncResult BeginDescribeScript(DescribeScriptRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScript operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScript.</param>
        /// 
        /// <returns>Returns a  DescribeScriptResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeScript">REST API Reference for DescribeScript Operation</seealso>
        DescribeScriptResponse EndDescribeScript(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcPeeringAuthorizations


        /// <summary>
        /// Retrieves valid VPC peering authorizations that are pending for the Amazon Web Services
        /// account. This operation returns all VPC peering authorizations and requests for peering.
        /// This includes those initiated and received by this account. 
        /// 
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> | <a>DescribeVpcPeeringAuthorizations</a> |
        /// <a>DeleteVpcPeeringAuthorization</a> | <a>CreateVpcPeeringConnection</a> | <a>DescribeVpcPeeringConnections</a>
        /// | <a>DeleteVpcPeeringConnection</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeVpcPeeringAuthorizations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringAuthorizations operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcPeeringAuthorizations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeVpcPeeringAuthorizations">REST API Reference for DescribeVpcPeeringAuthorizations Operation</seealso>
        IAsyncResult BeginDescribeVpcPeeringAuthorizations(DescribeVpcPeeringAuthorizationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcPeeringAuthorizations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcPeeringAuthorizations.</param>
        /// 
        /// <returns>Returns a  DescribeVpcPeeringAuthorizationsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeVpcPeeringAuthorizations">REST API Reference for DescribeVpcPeeringAuthorizations Operation</seealso>
        DescribeVpcPeeringAuthorizationsResponse EndDescribeVpcPeeringAuthorizations(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcPeeringConnections


        /// <summary>
        /// Retrieves information on VPC peering connections. Use this operation to get peering
        /// information for all fleets or for one specific fleet ID. 
        /// 
        ///  
        /// <para>
        /// To retrieve connection information, call this operation from the Amazon Web Services
        /// account that is used to manage the Amazon Web Services fleets. Specify a fleet ID
        /// or leave the parameter empty to retrieve all connection records. If successful, the
        /// retrieved information includes both active and pending connections. Active connections
        /// identify the IpV4 CIDR block that the VPC uses to connect. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateVpcPeeringAuthorization</a> | <a>DescribeVpcPeeringAuthorizations</a> |
        /// <a>DeleteVpcPeeringAuthorization</a> | <a>CreateVpcPeeringConnection</a> | <a>DescribeVpcPeeringConnections</a>
        /// | <a>DeleteVpcPeeringConnection</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeVpcPeeringConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringConnections operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcPeeringConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        IAsyncResult BeginDescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcPeeringConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcPeeringConnections.</param>
        /// 
        /// <returns>Returns a  DescribeVpcPeeringConnectionsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        DescribeVpcPeeringConnectionsResponse EndDescribeVpcPeeringConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGameSessionLogUrl


        /// <summary>
        /// Retrieves the location of stored game session logs for a specified game session. When
        /// a game session is terminated, GameLift automatically stores the logs in Amazon S3
        /// and retains them for 14 days. Use this URL to download the logs.
        /// 
        ///  <note> 
        /// <para>
        /// See the <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_gamelift">Amazon
        /// Web Services Service Limits</a> page for maximum log file sizes. Log files that exceed
        /// this limit are not saved.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateGameSession</a> | <a>DescribeGameSessions</a> | <a>DescribeGameSessionDetails</a>
        /// | <a>SearchGameSessions</a> | <a>UpdateGameSession</a> | <a>GetGameSessionLogUrl</a>
        /// | <a>StartGameSessionPlacement</a> | <a>DescribeGameSessionPlacement</a> | <a>StopGameSessionPlacement</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// a game session is terminated, GameLift automatically stores the logs in Amazon S3
        /// and retains them for 14 days. Use this URL to download the logs.
        /// 
        ///  <note> 
        /// <para>
        /// See the <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_gamelift">Amazon
        /// Web Services Service Limits</a> page for maximum log file sizes. Log files that exceed
        /// this limit are not saved.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateGameSession</a> | <a>DescribeGameSessions</a> | <a>DescribeGameSessionDetails</a>
        /// | <a>SearchGameSessions</a> | <a>UpdateGameSession</a> | <a>GetGameSessionLogUrl</a>
        /// | <a>StartGameSessionPlacement</a> | <a>DescribeGameSessionPlacement</a> | <a>StopGameSessionPlacement</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the GetGameSessionLogUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGameSessionLogUrl operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGameSessionLogUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetGameSessionLogUrl">REST API Reference for GetGameSessionLogUrl Operation</seealso>
        IAsyncResult BeginGetGameSessionLogUrl(GetGameSessionLogUrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGameSessionLogUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGameSessionLogUrl.</param>
        /// 
        /// <returns>Returns a  GetGameSessionLogUrlResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetGameSessionLogUrl">REST API Reference for GetGameSessionLogUrl Operation</seealso>
        GetGameSessionLogUrlResponse EndGetGameSessionLogUrl(IAsyncResult asyncResult);

        #endregion
        
        #region  GetInstanceAccess


        /// <summary>
        /// Requests remote access to a fleet instance. Remote access is useful for debugging,
        /// gathering benchmarking data, or observing activity in real time. 
        /// 
        ///  
        /// <para>
        /// To remotely access an instance, you need credentials that match the operating system
        /// of the instance. For a Windows instance, GameLift returns a user name and password
        /// as strings for use with a Windows Remote Desktop client. For a Linux instance, GameLift
        /// returns a user name and RSA private key, also as strings, for use with an SSH client.
        /// The private key must be saved in the proper format to a <code>.pem</code> file before
        /// using. If you're making this request using the CLI, saving the secret can be handled
        /// as part of the <code>GetInstanceAccess</code> request, as shown in one of the examples
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>DescribeInstances</a> | <a>GetInstanceAccess</a> | <a>DescribeEC2InstanceLimits</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the GetInstanceAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceAccess operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstanceAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetInstanceAccess">REST API Reference for GetInstanceAccess Operation</seealso>
        IAsyncResult BeginGetInstanceAccess(GetInstanceAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstanceAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceAccess.</param>
        /// 
        /// <returns>Returns a  GetInstanceAccessResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetInstanceAccess">REST API Reference for GetInstanceAccess Operation</seealso>
        GetInstanceAccessResponse EndGetInstanceAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAliases


        /// <summary>
        /// Retrieves all aliases for this Amazon Web Services account. You can filter the result
        /// set by alias name and/or routing strategy type. Use the pagination parameters to retrieve
        /// results in sequential pages.
        /// 
        ///  <note> 
        /// <para>
        /// Returned aliases are not listed in any particular order.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateAlias</a> | <a>ListAliases</a> | <a>DescribeAlias</a> | <a>UpdateAlias</a>
        /// | <a>DeleteAlias</a> | <a>ResolveAlias</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        IAsyncResult BeginListAliases(ListAliasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAliases.</param>
        /// 
        /// <returns>Returns a  ListAliasesResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        ListAliasesResponse EndListAliases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBuilds


        /// <summary>
        /// Retrieves build resources for all builds associated with the Amazon Web Services account
        /// in use. You can limit results to builds that are in a specific status by using the
        /// <code>Status</code> parameter. Use the pagination parameters to retrieve results in
        /// a set of sequential pages. 
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateBuild</a> | <a>ListBuilds</a> | <a>DescribeBuild</a> | <a>UpdateBuild</a>
        /// | <a>DeleteBuild</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the ListBuilds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuilds operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBuilds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListBuilds">REST API Reference for ListBuilds Operation</seealso>
        IAsyncResult BeginListBuilds(ListBuildsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBuilds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBuilds.</param>
        /// 
        /// <returns>Returns a  ListBuildsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListBuilds">REST API Reference for ListBuilds Operation</seealso>
        ListBuildsResponse EndListBuilds(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFleets


        /// <summary>
        /// Retrieves a collection of fleet resources in an Amazon Web Services Region. You can
        /// call this operation to get fleets in a previously selected default Region (see <a
        /// href="https://docs.aws.amazon.com/credref/latest/refdocs/setting-global-region.html">https://docs.aws.amazon.com/credref/latest/refdocs/setting-global-region.html</a>or
        /// specify a Region in your request. You can filter the result set to find only those
        /// fleets that are deployed with a specific build or script. For fleets that have multiple
        /// locations, this operation retrieves fleets based on their home Region only.
        /// 
        ///  
        /// <para>
        /// This operation can be used in the following ways: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To get a list of all fleets in a Region, don't provide a build or script identifier.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To get a list of all fleets where a specific custom game build is deployed, provide
        /// the build ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To get a list of all Realtime Servers fleets with a specific configuration script,
        /// provide the script ID. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Use the pagination parameters to retrieve results as a set of sequential pages. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a list of fleet IDs that match the request parameters is returned.
        /// A NextToken value is also returned if there are more result pages to retrieve.
        /// </para>
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
        /// up GameLift fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateFleet</a> | <a>UpdateFleetCapacity</a> | <a>PutScalingPolicy</a> | <a>DescribeEC2InstanceLimits</a>
        /// | <a>DescribeFleetAttributes</a> | <a>DescribeFleetLocationAttributes</a> | <a>UpdateFleetAttributes</a>
        /// | <a>StopFleetActions</a> | <a>DeleteFleet</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the ListFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleets operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFleets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListFleets">REST API Reference for ListFleets Operation</seealso>
        IAsyncResult BeginListFleets(ListFleetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFleets.</param>
        /// 
        /// <returns>Returns a  ListFleetsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListFleets">REST API Reference for ListFleets Operation</seealso>
        ListFleetsResponse EndListFleets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGameServerGroups


        /// <summary>
        /// <b>This operation is used with the GameLift FleetIQ solution and game server groups.</b>
        /// 
        /// 
        ///  
        /// <para>
        /// Retrieves information on all game servers groups that exist in the current Amazon
        /// Web Services account for the selected Region. Use the pagination parameters to retrieve
        /// results in a set of sequential segments. 
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateGameServerGroup</a> | <a>ListGameServerGroups</a> | <a>DescribeGameServerGroup</a>
        /// | <a>UpdateGameServerGroup</a> | <a>DeleteGameServerGroup</a> | <a>ResumeGameServerGroup</a>
        /// | <a>SuspendGameServerGroup</a> | <a>DescribeGameServerInstances</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/reference-awssdk-fleetiq.html">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the ListGameServerGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGameServerGroups operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGameServerGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListGameServerGroups">REST API Reference for ListGameServerGroups Operation</seealso>
        IAsyncResult BeginListGameServerGroups(ListGameServerGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGameServerGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGameServerGroups.</param>
        /// 
        /// <returns>Returns a  ListGameServerGroupsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListGameServerGroups">REST API Reference for ListGameServerGroups Operation</seealso>
        ListGameServerGroupsResponse EndListGameServerGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGameServers


        /// <summary>
        /// <b>This operation is used with the GameLift FleetIQ solution and game server groups.</b>
        /// 
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>RegisterGameServer</a> | <a>ListGameServers</a> | <a>ClaimGameServer</a> | <a>DescribeGameServer</a>
        /// | <a>UpdateGameServer</a> | <a>DeregisterGameServer</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/reference-awssdk-fleetiq.html">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the ListGameServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGameServers operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGameServers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListGameServers">REST API Reference for ListGameServers Operation</seealso>
        IAsyncResult BeginListGameServers(ListGameServersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGameServers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGameServers.</param>
        /// 
        /// <returns>Returns a  ListGameServersResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListGameServers">REST API Reference for ListGameServers Operation</seealso>
        ListGameServersResponse EndListGameServers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListScripts


        /// <summary>
        /// Retrieves script records for all Realtime scripts that are associated with the Amazon
        /// Web Services account in use. 
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
        /// Web Services Realtime Servers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateScript</a> | <a>ListScripts</a> | <a>DescribeScript</a> | <a>UpdateScript</a>
        /// | <a>DeleteScript</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the ListScripts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListScripts operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListScripts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListScripts">REST API Reference for ListScripts Operation</seealso>
        IAsyncResult BeginListScripts(ListScriptsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListScripts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListScripts.</param>
        /// 
        /// <returns>Returns a  ListScriptsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListScripts">REST API Reference for ListScripts Operation</seealso>
        ListScriptsResponse EndListScripts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves all tags that are assigned to a GameLift resource. Resource tags are used
        /// to organize Amazon Web Services resources for a range of purposes. This operation
        /// handles the permissions necessary to manage tags for the following GameLift resource
        /// types:
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
        /// Amazon Web Services Resources</a> in the <i>Amazon Web Services General Reference</i>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <a href="http://aws.amazon.com/answers/account-management/aws-tagging-strategies/">
        /// Amazon Web Services Tagging Strategies</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>TagResource</a> | <a>UntagResource</a> | <a>ListTagsForResource</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PutScalingPolicy


        /// <summary>
        /// Creates or updates a scaling policy for a fleet. Scaling policies are used to automatically
        /// scale a fleet's hosting capacity to meet player demand. An active scaling policy instructs
        /// Amazon Web Services to track a fleet metric and automatically change the fleet's capacity
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
        /// you set your ideal buffer size and leave it to Amazon Web Services to take whatever
        /// action is needed to maintain that target. 
        /// </para>
        ///  
        /// <para>
        /// For example, you might choose to maintain a 10% buffer for a fleet that has the capacity
        /// to host 100 simultaneous game sessions. This policy tells Amazon Web Services to take
        /// action whenever the fleet's available capacity falls below or rises above 10 game
        /// sessions. Amazon Web Services will start new instances or stop unused instances in
        /// order to return to the 10% buffer. 
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
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>DescribeFleetCapacity</a> | <a>UpdateFleetCapacity</a> | <a>DescribeEC2InstanceLimits</a>
        /// | <a>PutScalingPolicy</a> | <a>DescribeScalingPolicies</a> | <a>DeleteScalingPolicy</a>
        /// | <a>StopFleetActions</a> | <a>StartFleetActions</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the PutScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutScalingPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        IAsyncResult BeginPutScalingPolicy(PutScalingPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutScalingPolicy.</param>
        /// 
        /// <returns>Returns a  PutScalingPolicyResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        PutScalingPolicyResponse EndPutScalingPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterGameServer


        /// <summary>
        /// <b>This operation is used with the GameLift FleetIQ solution and game server groups.</b>
        /// 
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>RegisterGameServer</a> | <a>ListGameServers</a> | <a>ClaimGameServer</a> | <a>DescribeGameServer</a>
        /// | <a>UpdateGameServer</a> | <a>DeregisterGameServer</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/reference-awssdk-fleetiq.html">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the RegisterGameServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterGameServer operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterGameServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/RegisterGameServer">REST API Reference for RegisterGameServer Operation</seealso>
        IAsyncResult BeginRegisterGameServer(RegisterGameServerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterGameServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterGameServer.</param>
        /// 
        /// <returns>Returns a  RegisterGameServerResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/RegisterGameServer">REST API Reference for RegisterGameServer Operation</seealso>
        RegisterGameServerResponse EndRegisterGameServer(IAsyncResult asyncResult);

        #endregion
        
        #region  RequestUploadCredentials


        /// <summary>
        /// Retrieves a fresh set of credentials for use when uploading a new set of game build
        /// files to Amazon Web Services's Amazon S3. This is done as part of the build creation
        /// process; see <a>CreateBuild</a>.
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateBuild</a> | <a>ListBuilds</a> | <a>DescribeBuild</a> | <a>UpdateBuild</a>
        /// | <a>DeleteBuild</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
        /// </summary>
        /// <param name="buildId">A unique identifier for the build to get credentials for. You can use either the build ID or ARN value. </param>
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
        /// files to Amazon Web Services's Amazon S3. This is done as part of the build creation
        /// process; see <a>CreateBuild</a>.
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateBuild</a> | <a>ListBuilds</a> | <a>DescribeBuild</a> | <a>UpdateBuild</a>
        /// | <a>DeleteBuild</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the RequestUploadCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestUploadCredentials operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRequestUploadCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/RequestUploadCredentials">REST API Reference for RequestUploadCredentials Operation</seealso>
        IAsyncResult BeginRequestUploadCredentials(RequestUploadCredentialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RequestUploadCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestUploadCredentials.</param>
        /// 
        /// <returns>Returns a  RequestUploadCredentialsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/RequestUploadCredentials">REST API Reference for RequestUploadCredentials Operation</seealso>
        RequestUploadCredentialsResponse EndRequestUploadCredentials(IAsyncResult asyncResult);

        #endregion
        
        #region  ResolveAlias


        /// <summary>
        /// Retrieves the fleet ID that an alias is currently pointing to.
        /// 
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateAlias</a> | <a>ListAliases</a> | <a>DescribeAlias</a> | <a>UpdateAlias</a>
        /// | <a>DeleteAlias</a> | <a>ResolveAlias</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateAlias</a> | <a>ListAliases</a> | <a>DescribeAlias</a> | <a>UpdateAlias</a>
        /// | <a>DeleteAlias</a> | <a>ResolveAlias</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the ResolveAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResolveAlias operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResolveAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ResolveAlias">REST API Reference for ResolveAlias Operation</seealso>
        IAsyncResult BeginResolveAlias(ResolveAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResolveAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResolveAlias.</param>
        /// 
        /// <returns>Returns a  ResolveAliasResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ResolveAlias">REST API Reference for ResolveAlias Operation</seealso>
        ResolveAliasResponse EndResolveAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  ResumeGameServerGroup


        /// <summary>
        /// <b>This operation is used with the GameLift FleetIQ solution and game server groups.</b>
        /// 
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateGameServerGroup</a> | <a>ListGameServerGroups</a> | <a>DescribeGameServerGroup</a>
        /// | <a>UpdateGameServerGroup</a> | <a>DeleteGameServerGroup</a> | <a>ResumeGameServerGroup</a>
        /// | <a>SuspendGameServerGroup</a> | <a>DescribeGameServerInstances</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/reference-awssdk-fleetiq.html">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the ResumeGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResumeGameServerGroup operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResumeGameServerGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ResumeGameServerGroup">REST API Reference for ResumeGameServerGroup Operation</seealso>
        IAsyncResult BeginResumeGameServerGroup(ResumeGameServerGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResumeGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResumeGameServerGroup.</param>
        /// 
        /// <returns>Returns a  ResumeGameServerGroupResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ResumeGameServerGroup">REST API Reference for ResumeGameServerGroup Operation</seealso>
        ResumeGameServerGroupResponse EndResumeGameServerGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchGameSessions


        /// <summary>
        /// Retrieves all active game sessions that match a set of search criteria and sorts them
        /// into a specified order. 
        /// 
        ///  
        /// <para>
        /// This operation is not designed to be continually called to track game session status.
        /// This practice can cause you to exceed your API limit, which results in errors. Instead,
        /// you must configure configure an Amazon Simple Notification Service (SNS) topic to
        /// receive notifications from FlexMatch or queues. Continuously polling game session
        /// status with <code>DescribeGameSessions</code> should only be used for games in development
        /// with low game session usage. 
        /// </para>
        ///  
        /// <para>
        /// When searching for game sessions, you specify exactly where you want to search and
        /// provide a search filter expression, a sort expression, or both. A search request can
        /// search only one fleet, but it can search all of a fleet's locations. 
        /// </para>
        ///  
        /// <para>
        /// This operation can be used in the following ways: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To search all game sessions that are currently running on all locations in a fleet,
        /// provide a fleet or alias ID. This approach returns game sessions in the fleet's home
        /// Region and all remote locations that fit the search criteria.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To search all game sessions that are currently running on a specific fleet location,
        /// provide a fleet or alias ID and a location name. For location, you can specify a fleet's
        /// home Region or any remote location.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Use the pagination parameters to retrieve results as a set of sequential pages. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a <code>GameSession</code> object is returned for each game session
        /// that matches the request. Search finds game sessions that are in <code>ACTIVE</code>
        /// status only. To retrieve information on game sessions in other statuses, use <a>DescribeGameSessions</a>.
        /// </para>
        ///  
        /// <para>
        /// You can search or sort by the following game session attributes:
        /// </para>
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateGameSession</a> | <a>DescribeGameSessions</a> | <a>DescribeGameSessionDetails</a>
        /// | <a>SearchGameSessions</a> | <a>UpdateGameSession</a> | <a>GetGameSessionLogUrl</a>
        /// | <a>StartGameSessionPlacement</a> | <a>DescribeGameSessionPlacement</a> | <a>StopGameSessionPlacement</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/SearchGameSessions">REST API Reference for SearchGameSessions Operation</seealso>
        SearchGameSessionsResponse SearchGameSessions(SearchGameSessionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchGameSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchGameSessions operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchGameSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/SearchGameSessions">REST API Reference for SearchGameSessions Operation</seealso>
        IAsyncResult BeginSearchGameSessions(SearchGameSessionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchGameSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchGameSessions.</param>
        /// 
        /// <returns>Returns a  SearchGameSessionsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/SearchGameSessions">REST API Reference for SearchGameSessions Operation</seealso>
        SearchGameSessionsResponse EndSearchGameSessions(IAsyncResult asyncResult);

        #endregion
        
        #region  StartFleetActions


        /// <summary>
        /// Resumes certain types of activity on fleet instances that were suspended with <a>StopFleetActions</a>.
        /// For multi-location fleets, fleet actions are managed separately for each location.
        /// Currently, this operation is used to restart a fleet's auto-scaling activity.
        /// 
        ///  
        /// <para>
        /// This operation can be used in the following ways: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To restart actions on instances in the fleet's home Region, provide a fleet ID and
        /// the type of actions to resume. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To restart actions on instances in one of the fleet's remote locations, provide a
        /// fleet ID, a location name, and the type of actions to resume. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If successful, GameLift once again initiates scaling events as triggered by the fleet's
        /// scaling policies. If actions on the fleet location were never stopped, this operation
        /// will have no effect. You can view a fleet's stopped actions using <a>DescribeFleetAttributes</a>
        /// or <a>DescribeFleetLocationAttributes</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateFleet</a> | <a>UpdateFleetCapacity</a> | <a>PutScalingPolicy</a> | <a>DescribeEC2InstanceLimits</a>
        /// | <a>DescribeFleetAttributes</a> | <a>DescribeFleetLocationAttributes</a> | <a>UpdateFleetAttributes</a>
        /// | <a>StopFleetActions</a> | <a>DeleteFleet</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartFleetActions">REST API Reference for StartFleetActions Operation</seealso>
        StartFleetActionsResponse StartFleetActions(StartFleetActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartFleetActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFleetActions operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartFleetActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartFleetActions">REST API Reference for StartFleetActions Operation</seealso>
        IAsyncResult BeginStartFleetActions(StartFleetActionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartFleetActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartFleetActions.</param>
        /// 
        /// <returns>Returns a  StartFleetActionsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartFleetActions">REST API Reference for StartFleetActions Operation</seealso>
        StartFleetActionsResponse EndStartFleetActions(IAsyncResult asyncResult);

        #endregion
        
        #region  StartGameSessionPlacement


        /// <summary>
        /// Places a request for a new game session in a queue (see <a>CreateGameSessionQueue</a>).
        /// When processing a placement request, Amazon Web Services searches for available resources
        /// on the queue's destinations, scanning each until it finds resources or the placement
        /// request times out.
        /// 
        ///  
        /// <para>
        /// A game session placement request can also request player sessions. When a new game
        /// session is successfully created, Amazon Web Services creates a player session for
        /// each player included in the request.
        /// </para>
        ///  
        /// <para>
        /// When placing a game session, by default Amazon Web Services tries each fleet in the
        /// order they are listed in the queue configuration. Ideally, a queue's destinations
        /// are listed in preference order.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, when requesting a game session with players, you can also provide latency
        /// data for each player in relevant Regions. Latency data indicates the performance lag
        /// a player experiences when connected to a fleet in the Region. Amazon Web Services
        /// uses latency data to reorder the list of destinations to place the game session in
        /// a Region with minimal lag. If latency data is provided for multiple players, Amazon
        /// Web Services calculates each Region's average lag for all players and reorders to
        /// get the best game play across all players. 
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
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateGameSession</a> | <a>DescribeGameSessions</a> | <a>DescribeGameSessionDetails</a>
        /// | <a>SearchGameSessions</a> | <a>UpdateGameSession</a> | <a>GetGameSessionLogUrl</a>
        /// | <a>StartGameSessionPlacement</a> | <a>DescribeGameSessionPlacement</a> | <a>StopGameSessionPlacement</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the StartGameSessionPlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartGameSessionPlacement operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartGameSessionPlacement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartGameSessionPlacement">REST API Reference for StartGameSessionPlacement Operation</seealso>
        IAsyncResult BeginStartGameSessionPlacement(StartGameSessionPlacementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartGameSessionPlacement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartGameSessionPlacement.</param>
        /// 
        /// <returns>Returns a  StartGameSessionPlacementResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartGameSessionPlacement">REST API Reference for StartGameSessionPlacement Operation</seealso>
        StartGameSessionPlacementResponse EndStartGameSessionPlacement(IAsyncResult asyncResult);

        #endregion
        
        #region  StartMatchBackfill


        /// <summary>
        /// Finds new players to fill open slots in currently running game sessions. The backfill
        /// match process is essentially identical to the process of forming new matches. Backfill
        /// requests use the same matchmaker that was used to make the original match, and they
        /// provide matchmaking data for all players currently in the game session. FlexMatch
        /// uses this information to select new players so that backfilled match continues to
        /// meet the original match requirements. 
        /// 
        ///  
        /// <para>
        /// When using FlexMatch with GameLift managed hosting, you can request a backfill match
        /// from a client service by calling this operation with a <a>GameSession</a> identifier.
        /// You also have the option of making backfill requests directly from your game server.
        /// In response to a request, FlexMatch creates player sessions for the new players, updates
        /// the <code>GameSession</code> resource, and sends updated matchmaking data to the game
        /// server. You can request a backfill match at any point after a game session is started.
        /// Each game session can have only one active backfill request at a time; a subsequent
        /// request automatically replaces the earlier request.
        /// </para>
        ///  
        /// <para>
        /// When using FlexMatch as a standalone component, request a backfill match by calling
        /// this operation without a game session identifier. As with newly formed matches, matchmaking
        /// results are returned in a matchmaking event so that your game can update the game
        /// session that is being backfilled.
        /// </para>
        ///  
        /// <para>
        /// To request a backfill match, specify a unique ticket ID, the original matchmaking
        /// configuration, and matchmaking data for all current players in the game session being
        /// backfilled. Optionally, specify the <code>GameSession</code> ARN. If successful, a
        /// match backfill ticket is created and returned with status set to QUEUED. Track the
        /// status of backfill tickets using the same method for tracking tickets for new matches.
        /// </para>
        ///  
        /// <para>
        /// Only game sessions created by FlexMatch are supported for match backfill.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-backfill.html">
        /// Backfill existing games with FlexMatch</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-events.html">
        /// Matchmaking events</a> (reference)
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/gamelift-match.html">
        /// How GameLift FlexMatch works</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>StartMatchmaking</a> | <a>DescribeMatchmaking</a> | <a>StopMatchmaking</a> | <a>AcceptMatch</a>
        /// | <a>StartMatchBackfill</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the StartMatchBackfill operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMatchBackfill operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMatchBackfill
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartMatchBackfill">REST API Reference for StartMatchBackfill Operation</seealso>
        IAsyncResult BeginStartMatchBackfill(StartMatchBackfillRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartMatchBackfill operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMatchBackfill.</param>
        /// 
        /// <returns>Returns a  StartMatchBackfillResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartMatchBackfill">REST API Reference for StartMatchBackfill Operation</seealso>
        StartMatchBackfillResponse EndStartMatchBackfill(IAsyncResult asyncResult);

        #endregion
        
        #region  StartMatchmaking


        /// <summary>
        /// Uses FlexMatch to create a game match for a group of players based on custom matchmaking
        /// rules. With games that use GameLift managed hosting, this operation also triggers
        /// GameLift to find hosting resources and start a new game session for the new match.
        /// Each matchmaking request includes information on one or more players and specifies
        /// the FlexMatch matchmaker to use. When a request is for multiple players, FlexMatch
        /// attempts to build a match that includes all players in the request, placing them in
        /// the same team and finding additional players as needed to fill the match. 
        /// 
        ///  
        /// <para>
        /// To start matchmaking, provide a unique ticket ID, specify a matchmaking configuration,
        /// and include the players to be matched. You must also include any player attributes
        /// that are required by the matchmaking configuration's rule set. If successful, a matchmaking
        /// ticket is returned with status set to <code>QUEUED</code>. 
        /// </para>
        ///  
        /// <para>
        /// Track matchmaking events to respond as needed and acquire game session connection
        /// information for successfully completed matches. Ticket status updates are tracked
        /// using event notification through Amazon Simple Notification Service, which is defined
        /// in the matchmaking configuration.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-client.html">
        /// Add FlexMatch to a game client</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-notification.html">
        /// Set Up FlexMatch event notification</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/gamelift-match.html">
        /// How GameLift FlexMatch works</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>StartMatchmaking</a> | <a>DescribeMatchmaking</a> | <a>StopMatchmaking</a> | <a>AcceptMatch</a>
        /// | <a>StartMatchBackfill</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the StartMatchmaking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMatchmaking operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMatchmaking
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartMatchmaking">REST API Reference for StartMatchmaking Operation</seealso>
        IAsyncResult BeginStartMatchmaking(StartMatchmakingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartMatchmaking operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMatchmaking.</param>
        /// 
        /// <returns>Returns a  StartMatchmakingResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartMatchmaking">REST API Reference for StartMatchmaking Operation</seealso>
        StartMatchmakingResponse EndStartMatchmaking(IAsyncResult asyncResult);

        #endregion
        
        #region  StopFleetActions


        /// <summary>
        /// Suspends certain types of activity in a fleet location. Currently, this operation
        /// is used to stop auto-scaling activity. For multi-location fleets, fleet actions are
        /// managed separately for each location. 
        /// 
        ///  
        /// <para>
        /// Stopping fleet actions has several potential purposes. It allows you to temporarily
        /// stop auto-scaling activity but retain your scaling policies for use in the future.
        /// For multi-location fleets, you can set up fleet-wide auto-scaling, and then opt out
        /// of it for certain locations. 
        /// </para>
        ///  
        /// <para>
        /// This operation can be used in the following ways: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To stop actions on instances in the fleet's home Region, provide a fleet ID and the
        /// type of actions to suspend. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To stop actions on instances in one of the fleet's remote locations, provide a fleet
        /// ID, a location name, and the type of actions to suspend. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If successful, GameLift no longer initiates scaling events except in response to manual
        /// changes using <a>UpdateFleetCapacity</a>. You can view a fleet's stopped actions using
        /// <a>DescribeFleetAttributes</a> or <a>DescribeFleetLocationAttributes</a>. Suspended
        /// activity can be restarted using <a>StartFleetActions</a>.
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateFleet</a> | <a>UpdateFleetCapacity</a> | <a>PutScalingPolicy</a> | <a>DescribeEC2InstanceLimits</a>
        /// | <a>DescribeFleetAttributes</a> | <a>DescribeFleetLocationAttributes</a> | <a>UpdateFleetAttributes</a>
        /// | <a>StopFleetActions</a> | <a>DeleteFleet</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopFleetActions">REST API Reference for StopFleetActions Operation</seealso>
        StopFleetActionsResponse StopFleetActions(StopFleetActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopFleetActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopFleetActions operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopFleetActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopFleetActions">REST API Reference for StopFleetActions Operation</seealso>
        IAsyncResult BeginStopFleetActions(StopFleetActionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopFleetActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopFleetActions.</param>
        /// 
        /// <returns>Returns a  StopFleetActionsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopFleetActions">REST API Reference for StopFleetActions Operation</seealso>
        StopFleetActionsResponse EndStopFleetActions(IAsyncResult asyncResult);

        #endregion
        
        #region  StopGameSessionPlacement


        /// <summary>
        /// Cancels a game session placement that is in <code>PENDING</code> status. To stop a
        /// placement, provide the placement ID values. If successful, the placement is moved
        /// to <code>CANCELLED</code> status.
        /// 
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateGameSession</a> | <a>DescribeGameSessions</a> | <a>DescribeGameSessionDetails</a>
        /// | <a>SearchGameSessions</a> | <a>UpdateGameSession</a> | <a>GetGameSessionLogUrl</a>
        /// | <a>StartGameSessionPlacement</a> | <a>DescribeGameSessionPlacement</a> | <a>StopGameSessionPlacement</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the StopGameSessionPlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopGameSessionPlacement operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopGameSessionPlacement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopGameSessionPlacement">REST API Reference for StopGameSessionPlacement Operation</seealso>
        IAsyncResult BeginStopGameSessionPlacement(StopGameSessionPlacementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopGameSessionPlacement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopGameSessionPlacement.</param>
        /// 
        /// <returns>Returns a  StopGameSessionPlacementResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopGameSessionPlacement">REST API Reference for StopGameSessionPlacement Operation</seealso>
        StopGameSessionPlacementResponse EndStopGameSessionPlacement(IAsyncResult asyncResult);

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
        /// Add FlexMatch to a game client</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>StartMatchmaking</a> | <a>DescribeMatchmaking</a> | <a>StopMatchmaking</a> | <a>AcceptMatch</a>
        /// | <a>StartMatchBackfill</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the StopMatchmaking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopMatchmaking operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopMatchmaking
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopMatchmaking">REST API Reference for StopMatchmaking Operation</seealso>
        IAsyncResult BeginStopMatchmaking(StopMatchmakingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopMatchmaking operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopMatchmaking.</param>
        /// 
        /// <returns>Returns a  StopMatchmakingResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopMatchmaking">REST API Reference for StopMatchmaking Operation</seealso>
        StopMatchmakingResponse EndStopMatchmaking(IAsyncResult asyncResult);

        #endregion
        
        #region  SuspendGameServerGroup


        /// <summary>
        /// <b>This operation is used with the GameLift FleetIQ solution and game server groups.</b>
        /// 
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateGameServerGroup</a> | <a>ListGameServerGroups</a> | <a>DescribeGameServerGroup</a>
        /// | <a>UpdateGameServerGroup</a> | <a>DeleteGameServerGroup</a> | <a>ResumeGameServerGroup</a>
        /// | <a>SuspendGameServerGroup</a> | <a>DescribeGameServerInstances</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/reference-awssdk-fleetiq.html">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the SuspendGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SuspendGameServerGroup operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSuspendGameServerGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/SuspendGameServerGroup">REST API Reference for SuspendGameServerGroup Operation</seealso>
        IAsyncResult BeginSuspendGameServerGroup(SuspendGameServerGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SuspendGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSuspendGameServerGroup.</param>
        /// 
        /// <returns>Returns a  SuspendGameServerGroupResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/SuspendGameServerGroup">REST API Reference for SuspendGameServerGroup Operation</seealso>
        SuspendGameServerGroupResponse EndSuspendGameServerGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns a tag to a GameLift resource. Amazon Web Services resource tags provide an
        /// additional management tool set. You can use tags to organize resources, create IAM
        /// permissions policies to manage access to groups of resources, customize Amazon Web
        /// Services cost breakdowns, etc. This operation handles the permissions necessary to
        /// manage tags for the following GameLift resource types:
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
        /// Amazon Web Services Resources</a> in the <i>Amazon Web Services General Reference</i>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <a href="http://aws.amazon.com/answers/account-management/aws-tagging-strategies/">
        /// Amazon Web Services Tagging Strategies</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>TagResource</a> | <a>UntagResource</a> | <a>ListTagsForResource</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag that is assigned to a GameLift resource. Resource tags are used to organize
        /// Amazon Web Services resources for a range of purposes. This operation handles the
        /// permissions necessary to manage tags for the following GameLift resource types:
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
        /// Amazon Web Services Resources</a> in the <i>Amazon Web Services General Reference</i>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <a href="http://aws.amazon.com/answers/account-management/aws-tagging-strategies/">
        /// Amazon Web Services Tagging Strategies</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>TagResource</a> | <a>UntagResource</a> | <a>ListTagsForResource</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAlias


        /// <summary>
        /// Updates properties for an alias. To update properties, specify the alias ID to be
        /// updated and provide the information to be changed. To reassign an alias to another
        /// fleet, provide an updated routing strategy. If successful, the updated alias record
        /// is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateAlias</a> | <a>ListAliases</a> | <a>DescribeAlias</a> | <a>UpdateAlias</a>
        /// | <a>DeleteAlias</a> | <a>ResolveAlias</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the UpdateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        IAsyncResult BeginUpdateAlias(UpdateAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAlias.</param>
        /// 
        /// <returns>Returns a  UpdateAliasResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        UpdateAliasResponse EndUpdateAlias(IAsyncResult asyncResult);

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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateBuild</a> | <a>ListBuilds</a> | <a>DescribeBuild</a> | <a>UpdateBuild</a>
        /// | <a>DeleteBuild</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the UpdateBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBuild operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBuild
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateBuild">REST API Reference for UpdateBuild Operation</seealso>
        IAsyncResult BeginUpdateBuild(UpdateBuildRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBuild operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBuild.</param>
        /// 
        /// <returns>Returns a  UpdateBuildResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateBuild">REST API Reference for UpdateBuild Operation</seealso>
        UpdateBuildResponse EndUpdateBuild(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFleetAttributes


        /// <summary>
        /// Updates a fleet's mutable attributes, including game session protection and resource
        /// creation limits.
        /// 
        ///  
        /// <para>
        /// To update fleet attributes, specify the fleet ID and the property values that you
        /// want to change. 
        /// </para>
        ///  
        /// <para>
        /// If successful, an updated <code>FleetAttributes</code> object is returned.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateFleetLocations</a> | <a>UpdateFleetAttributes</a> | <a>UpdateFleetCapacity</a>
        /// | <a>UpdateFleetPortSettings</a> | <a>UpdateRuntimeConfiguration</a> | <a>StopFleetActions</a>
        /// | <a>StartFleetActions</a> | <a>PutScalingPolicy</a> | <a>DeleteFleet</a> | <a>DeleteFleetLocations</a>
        /// | <a>DeleteScalingPolicy</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the UpdateFleetAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetAttributes operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFleetAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetAttributes">REST API Reference for UpdateFleetAttributes Operation</seealso>
        IAsyncResult BeginUpdateFleetAttributes(UpdateFleetAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFleetAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFleetAttributes.</param>
        /// 
        /// <returns>Returns a  UpdateFleetAttributesResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetAttributes">REST API Reference for UpdateFleetAttributes Operation</seealso>
        UpdateFleetAttributesResponse EndUpdateFleetAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFleetCapacity


        /// <summary>
        /// Updates capacity settings for a fleet. For fleets with multiple locations, use this
        /// operation to manage capacity settings in each location individually. Fleet capacity
        /// determines the number of game sessions and players that can be hosted based on the
        /// fleet configuration. Use this operation to set the following fleet capacity properties:
        /// 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Minimum/maximum size: Set hard limits on fleet capacity. GameLift cannot set the fleet's
        /// capacity to a value outside of this range, whether the capacity is changed manually
        /// or through automatic scaling. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Desired capacity: Manually set the number of Amazon EC2 instances to be maintained
        /// in a fleet location. Before changing a fleet's desired capacity, you may want to call
        /// <a>DescribeEC2InstanceLimits</a> to get the maximum capacity of the fleet's Amazon
        /// EC2 instance type. Alternatively, consider using automatic scaling to adjust capacity
        /// based on player demand.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation can be used in the following ways: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To update capacity for a fleet's home Region, or if the fleet has no remote locations,
        /// omit the <code>Location</code> parameter. The fleet must be in <code>ACTIVE</code>
        /// status. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To update capacity for a fleet's remote location, include the <code>Location</code>
        /// parameter set to the location to be updated. The location must be in <code>ACTIVE</code>
        /// status.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If successful, capacity settings are updated immediately. In response a change in
        /// desired capacity, GameLift initiates steps to start new instances or terminate existing
        /// instances in the requested fleet location. This continues until the location's active
        /// instance count matches the new desired instance count. You can track a fleet's current
        /// capacity by calling <a>DescribeFleetCapacity</a> or <a>DescribeFleetLocationCapacity</a>.
        /// If the requested desired instance count is higher than the instance type's limit,
        /// the <code>LimitExceeded</code> exception occurs.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-manage-capacity.html">Scaling
        /// fleet capacity</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateFleetLocations</a> | <a>UpdateFleetAttributes</a> | <a>UpdateFleetCapacity</a>
        /// | <a>UpdateFleetPortSettings</a> | <a>UpdateRuntimeConfiguration</a> | <a>StopFleetActions</a>
        /// | <a>StartFleetActions</a> | <a>PutScalingPolicy</a> | <a>DeleteFleet</a> | <a>DeleteFleetLocations</a>
        /// | <a>DeleteScalingPolicy</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetCapacity">REST API Reference for UpdateFleetCapacity Operation</seealso>
        UpdateFleetCapacityResponse UpdateFleetCapacity(UpdateFleetCapacityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleetCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetCapacity operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFleetCapacity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetCapacity">REST API Reference for UpdateFleetCapacity Operation</seealso>
        IAsyncResult BeginUpdateFleetCapacity(UpdateFleetCapacityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFleetCapacity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFleetCapacity.</param>
        /// 
        /// <returns>Returns a  UpdateFleetCapacityResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetCapacity">REST API Reference for UpdateFleetCapacity Operation</seealso>
        UpdateFleetCapacityResponse EndUpdateFleetCapacity(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFleetPortSettings


        /// <summary>
        /// Updates permissions that allow inbound traffic to connect to game sessions that are
        /// being hosted on instances in the fleet. 
        /// 
        ///  
        /// <para>
        /// To update settings, specify the fleet ID to be updated and specify the changes to
        /// be made. List the permissions you want to add in <code>InboundPermissionAuthorizations</code>,
        /// and permissions you want to remove in <code>InboundPermissionRevocations</code>. Permissions
        /// to be removed must match existing fleet permissions. 
        /// </para>
        ///  
        /// <para>
        /// If successful, the fleet ID for the updated fleet is returned. For fleets with remote
        /// locations, port setting updates can take time to propagate across all locations. You
        /// can check the status of updates in each location by calling <code>DescribeFleetPortSettings</code>
        /// with a location name.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateFleetLocations</a> | <a>UpdateFleetAttributes</a> | <a>UpdateFleetCapacity</a>
        /// | <a>UpdateFleetPortSettings</a> | <a>UpdateRuntimeConfiguration</a> | <a>StopFleetActions</a>
        /// | <a>StartFleetActions</a> | <a>PutScalingPolicy</a> | <a>DeleteFleet</a> | <a>DeleteFleetLocations</a>
        /// | <a>DeleteScalingPolicy</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the UpdateFleetPortSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetPortSettings operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFleetPortSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetPortSettings">REST API Reference for UpdateFleetPortSettings Operation</seealso>
        IAsyncResult BeginUpdateFleetPortSettings(UpdateFleetPortSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFleetPortSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFleetPortSettings.</param>
        /// 
        /// <returns>Returns a  UpdateFleetPortSettingsResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetPortSettings">REST API Reference for UpdateFleetPortSettings Operation</seealso>
        UpdateFleetPortSettingsResponse EndUpdateFleetPortSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGameServer


        /// <summary>
        /// <b>This operation is used with the GameLift FleetIQ solution and game server groups.</b>
        /// 
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>RegisterGameServer</a> | <a>ListGameServers</a> | <a>ClaimGameServer</a> | <a>DescribeGameServer</a>
        /// | <a>UpdateGameServer</a> | <a>DeregisterGameServer</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/reference-awssdk-fleetiq.html">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the UpdateGameServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameServer operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGameServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameServer">REST API Reference for UpdateGameServer Operation</seealso>
        IAsyncResult BeginUpdateGameServer(UpdateGameServerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGameServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGameServer.</param>
        /// 
        /// <returns>Returns a  UpdateGameServerResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameServer">REST API Reference for UpdateGameServer Operation</seealso>
        UpdateGameServerResponse EndUpdateGameServer(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGameServerGroup


        /// <summary>
        /// <b>This operation is used with the GameLift FleetIQ solution and game server groups.</b>
        /// 
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateGameServerGroup</a> | <a>ListGameServerGroups</a> | <a>DescribeGameServerGroup</a>
        /// | <a>UpdateGameServerGroup</a> | <a>DeleteGameServerGroup</a> | <a>ResumeGameServerGroup</a>
        /// | <a>SuspendGameServerGroup</a> | <a>DescribeGameServerInstances</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/reference-awssdk-fleetiq.html">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the UpdateGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameServerGroup operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGameServerGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameServerGroup">REST API Reference for UpdateGameServerGroup Operation</seealso>
        IAsyncResult BeginUpdateGameServerGroup(UpdateGameServerGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGameServerGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGameServerGroup.</param>
        /// 
        /// <returns>Returns a  UpdateGameServerGroupResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameServerGroup">REST API Reference for UpdateGameServerGroup Operation</seealso>
        UpdateGameServerGroupResponse EndUpdateGameServerGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGameSession


        /// <summary>
        /// Updates the mutable properties of a game session. 
        /// 
        ///  
        /// <para>
        /// To update a game session, specify the game session ID and the values you want to change.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If successful, the updated <code>GameSession</code> object is returned. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateGameSession</a> | <a>DescribeGameSessions</a> | <a>DescribeGameSessionDetails</a>
        /// | <a>SearchGameSessions</a> | <a>UpdateGameSession</a> | <a>GetGameSessionLogUrl</a>
        /// | <a>StartGameSessionPlacement</a> | <a>DescribeGameSessionPlacement</a> | <a>StopGameSessionPlacement</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the UpdateGameSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameSession operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGameSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameSession">REST API Reference for UpdateGameSession Operation</seealso>
        IAsyncResult BeginUpdateGameSession(UpdateGameSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGameSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGameSession.</param>
        /// 
        /// <returns>Returns a  UpdateGameSessionResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameSession">REST API Reference for UpdateGameSession Operation</seealso>
        UpdateGameSessionResponse EndUpdateGameSession(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGameSessionQueue


        /// <summary>
        /// Updates the configuration of a game session queue, which determines how the queue
        /// processes new game session requests. To update settings, specify the queue name to
        /// be updated and provide the new settings. When updating destinations, provide a complete
        /// list of destinations. 
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
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateGameSessionQueue.html">CreateGameSessionQueue</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeGameSessionQueues.html">DescribeGameSessionQueues</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_UpdateGameSessionQueue.html">UpdateGameSessionQueue</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DeleteGameSessionQueue.html">DeleteGameSessionQueue</a>
        /// | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the UpdateGameSessionQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameSessionQueue operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGameSessionQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameSessionQueue">REST API Reference for UpdateGameSessionQueue Operation</seealso>
        IAsyncResult BeginUpdateGameSessionQueue(UpdateGameSessionQueueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGameSessionQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGameSessionQueue.</param>
        /// 
        /// <returns>Returns a  UpdateGameSessionQueueResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameSessionQueue">REST API Reference for UpdateGameSessionQueue Operation</seealso>
        UpdateGameSessionQueueResponse EndUpdateGameSessionQueue(IAsyncResult asyncResult);

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
        /// Design a FlexMatch matchmaker</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> | <a>DescribeMatchmakingConfigurations</a>
        /// | <a>UpdateMatchmakingConfiguration</a> | <a>DeleteMatchmakingConfiguration</a> |
        /// <a>CreateMatchmakingRuleSet</a> | <a>DescribeMatchmakingRuleSets</a> | <a>ValidateMatchmakingRuleSet</a>
        /// | <a>DeleteMatchmakingRuleSet</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the UpdateMatchmakingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMatchmakingConfiguration operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMatchmakingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateMatchmakingConfiguration">REST API Reference for UpdateMatchmakingConfiguration Operation</seealso>
        IAsyncResult BeginUpdateMatchmakingConfiguration(UpdateMatchmakingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMatchmakingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMatchmakingConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateMatchmakingConfigurationResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateMatchmakingConfiguration">REST API Reference for UpdateMatchmakingConfiguration Operation</seealso>
        UpdateMatchmakingConfigurationResponse EndUpdateMatchmakingConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRuntimeConfiguration


        /// <summary>
        /// Updates the current runtime configuration for the specified fleet, which tells GameLift
        /// how to launch server processes on all instances in the fleet. You can update a fleet's
        /// runtime configuration at any time after the fleet is created; it does not need to
        /// be in <code>ACTIVE</code> status.
        /// 
        ///  
        /// <para>
        /// To update runtime configuration, specify the fleet ID and provide a <code>RuntimeConfiguration</code>
        /// with an updated set of server process configurations.
        /// </para>
        ///  
        /// <para>
        /// If successful, the fleet's runtime configuration settings are updated. Each instance
        /// in the fleet regularly checks for and retrieves updated runtime configurations. Instances
        /// immediately begin complying with the new configuration by launching new server processes
        /// or not replacing existing processes when they shut down. Updating a fleet's runtime
        /// configuration never affects existing server processes.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up GameLift fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateFleetLocations</a> | <a>UpdateFleetAttributes</a> | <a>UpdateFleetCapacity</a>
        /// | <a>UpdateFleetPortSettings</a> | <a>UpdateRuntimeConfiguration</a> | <a>StopFleetActions</a>
        /// | <a>StartFleetActions</a> | <a>PutScalingPolicy</a> | <a>DeleteFleet</a> | <a>DeleteFleetLocations</a>
        /// | <a>DeleteScalingPolicy</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the UpdateRuntimeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuntimeConfiguration operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRuntimeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateRuntimeConfiguration">REST API Reference for UpdateRuntimeConfiguration Operation</seealso>
        IAsyncResult BeginUpdateRuntimeConfiguration(UpdateRuntimeConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRuntimeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRuntimeConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateRuntimeConfigurationResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateRuntimeConfiguration">REST API Reference for UpdateRuntimeConfiguration Operation</seealso>
        UpdateRuntimeConfigurationResponse EndUpdateRuntimeConfiguration(IAsyncResult asyncResult);

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
        /// a revised script is uploaded to the Amazon Web Services service. Once the script is
        /// updated and acquired by a fleet instance, the new version is used for all new game
        /// sessions. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
        /// Web Services Realtime Servers</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateScript</a> | <a>ListScripts</a> | <a>DescribeScript</a> | <a>UpdateScript</a>
        /// | <a>DeleteScript</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the UpdateScript operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateScript operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateScript
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateScript">REST API Reference for UpdateScript Operation</seealso>
        IAsyncResult BeginUpdateScript(UpdateScriptRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateScript operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateScript.</param>
        /// 
        /// <returns>Returns a  UpdateScriptResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateScript">REST API Reference for UpdateScript Operation</seealso>
        UpdateScriptResponse EndUpdateScript(IAsyncResult asyncResult);

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
        /// a rule set</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateMatchmakingConfiguration</a> | <a>DescribeMatchmakingConfigurations</a>
        /// | <a>UpdateMatchmakingConfiguration</a> | <a>DeleteMatchmakingConfiguration</a> |
        /// <a>CreateMatchmakingRuleSet</a> | <a>DescribeMatchmakingRuleSets</a> | <a>ValidateMatchmakingRuleSet</a>
        /// | <a>DeleteMatchmakingRuleSet</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
        /// APIs by task</a> 
        /// </para>
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
        /// Initiates the asynchronous execution of the ValidateMatchmakingRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateMatchmakingRuleSet operation on AmazonGameLiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidateMatchmakingRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ValidateMatchmakingRuleSet">REST API Reference for ValidateMatchmakingRuleSet Operation</seealso>
        IAsyncResult BeginValidateMatchmakingRuleSet(ValidateMatchmakingRuleSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ValidateMatchmakingRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateMatchmakingRuleSet.</param>
        /// 
        /// <returns>Returns a  ValidateMatchmakingRuleSetResult from GameLift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ValidateMatchmakingRuleSet">REST API Reference for ValidateMatchmakingRuleSet Operation</seealso>
        ValidateMatchmakingRuleSetResponse EndValidateMatchmakingRuleSet(IAsyncResult asyncResult);

        #endregion
        
    }
}