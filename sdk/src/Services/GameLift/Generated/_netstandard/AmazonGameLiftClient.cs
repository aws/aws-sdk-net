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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.GameLift.Model;
using Amazon.GameLift.Model.Internal.MarshallTransformations;
using Amazon.GameLift.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.GameLift
{
    /// <summary>
    /// Implementation for accessing GameLift
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
    public partial class AmazonGameLiftClient : AmazonServiceClient, IAmazonGameLift
    {
        private static IServiceMetadata serviceMetadata = new AmazonGameLiftMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonGameLiftClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonGameLiftClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGameLiftConfig()) { }

        /// <summary>
        /// Constructs AmazonGameLiftClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonGameLiftClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGameLiftConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonGameLiftClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonGameLiftClient Configuration Object</param>
        public AmazonGameLiftClient(AmazonGameLiftConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonGameLiftClient(AWSCredentials credentials)
            : this(credentials, new AmazonGameLiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGameLiftClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonGameLiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Credentials and an
        /// AmazonGameLiftClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonGameLiftClient Configuration Object</param>
        public AmazonGameLiftClient(AWSCredentials credentials, AmazonGameLiftConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGameLiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGameLiftConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGameLiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonGameLiftClient Configuration Object</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonGameLiftConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGameLiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGameLiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGameLiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonGameLiftClient Configuration Object</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonGameLiftConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IGameLiftPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IGameLiftPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new GameLiftPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AcceptMatch

        internal virtual AcceptMatchResponse AcceptMatch(AcceptMatchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptMatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptMatchResponseUnmarshaller.Instance;

            return Invoke<AcceptMatchResponse>(request, options);
        }



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
        public virtual Task<AcceptMatchResponse> AcceptMatchAsync(AcceptMatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptMatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptMatchResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptMatchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ClaimGameServer

        internal virtual ClaimGameServerResponse ClaimGameServer(ClaimGameServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ClaimGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ClaimGameServerResponseUnmarshaller.Instance;

            return Invoke<ClaimGameServerResponse>(request, options);
        }



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
        public virtual Task<ClaimGameServerResponse> ClaimGameServerAsync(ClaimGameServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ClaimGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ClaimGameServerResponseUnmarshaller.Instance;

            return InvokeAsync<ClaimGameServerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAlias

        internal virtual CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasResponse>(request, options);
        }



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
        public virtual Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBuild

        internal virtual CreateBuildResponse CreateBuild(CreateBuildRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBuildResponseUnmarshaller.Instance;

            return Invoke<CreateBuildResponse>(request, options);
        }



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
        public virtual Task<CreateBuildResponse> CreateBuildAsync(CreateBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBuildResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBuildResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFleet

        internal virtual CreateFleetResponse CreateFleet(CreateFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return Invoke<CreateFleetResponse>(request, options);
        }



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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public virtual Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFleetLocations

        internal virtual CreateFleetLocationsResponse CreateFleetLocations(CreateFleetLocationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetLocationsResponseUnmarshaller.Instance;

            return Invoke<CreateFleetLocationsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateFleetLocationsResponse> CreateFleetLocationsAsync(CreateFleetLocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetLocationsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFleetLocationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGameServerGroup

        internal virtual CreateGameServerGroupResponse CreateGameServerGroup(CreateGameServerGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameServerGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGameServerGroupResponse>(request, options);
        }



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
        public virtual Task<CreateGameServerGroupResponse> CreateGameServerGroupAsync(CreateGameServerGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameServerGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGameServerGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGameSession

        internal virtual CreateGameSessionResponse CreateGameSession(CreateGameSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGameSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameSessionResponseUnmarshaller.Instance;

            return Invoke<CreateGameSessionResponse>(request, options);
        }



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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameSession">REST API Reference for CreateGameSession Operation</seealso>
        public virtual Task<CreateGameSessionResponse> CreateGameSessionAsync(CreateGameSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGameSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameSessionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGameSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGameSessionQueue

        internal virtual CreateGameSessionQueueResponse CreateGameSessionQueue(CreateGameSessionQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameSessionQueueResponseUnmarshaller.Instance;

            return Invoke<CreateGameSessionQueueResponse>(request, options);
        }



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
        public virtual Task<CreateGameSessionQueueResponse> CreateGameSessionQueueAsync(CreateGameSessionQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameSessionQueueResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGameSessionQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMatchmakingConfiguration

        internal virtual CreateMatchmakingConfigurationResponse CreateMatchmakingConfiguration(CreateMatchmakingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchmakingConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateMatchmakingConfigurationResponse>(request, options);
        }



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
        public virtual Task<CreateMatchmakingConfigurationResponse> CreateMatchmakingConfigurationAsync(CreateMatchmakingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchmakingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMatchmakingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMatchmakingRuleSet

        internal virtual CreateMatchmakingRuleSetResponse CreateMatchmakingRuleSet(CreateMatchmakingRuleSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchmakingRuleSetResponseUnmarshaller.Instance;

            return Invoke<CreateMatchmakingRuleSetResponse>(request, options);
        }



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
        public virtual Task<CreateMatchmakingRuleSetResponse> CreateMatchmakingRuleSetAsync(CreateMatchmakingRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchmakingRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMatchmakingRuleSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePlayerSession

        internal virtual CreatePlayerSessionResponse CreatePlayerSession(CreatePlayerSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlayerSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlayerSessionResponseUnmarshaller.Instance;

            return Invoke<CreatePlayerSessionResponse>(request, options);
        }


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
        public virtual Task<CreatePlayerSessionResponse> CreatePlayerSessionAsync(string gameSessionId, string playerId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreatePlayerSessionRequest();
            request.GameSessionId = gameSessionId;
            request.PlayerId = playerId;
            return CreatePlayerSessionAsync(request, cancellationToken);
        }



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
        public virtual Task<CreatePlayerSessionResponse> CreatePlayerSessionAsync(CreatePlayerSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlayerSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlayerSessionResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePlayerSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePlayerSessions

        internal virtual CreatePlayerSessionsResponse CreatePlayerSessions(CreatePlayerSessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlayerSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlayerSessionsResponseUnmarshaller.Instance;

            return Invoke<CreatePlayerSessionsResponse>(request, options);
        }


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
        public virtual Task<CreatePlayerSessionsResponse> CreatePlayerSessionsAsync(string gameSessionId, List<string> playerIds, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreatePlayerSessionsRequest();
            request.GameSessionId = gameSessionId;
            request.PlayerIds = playerIds;
            return CreatePlayerSessionsAsync(request, cancellationToken);
        }



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
        public virtual Task<CreatePlayerSessionsResponse> CreatePlayerSessionsAsync(CreatePlayerSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlayerSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlayerSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePlayerSessionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateScript

        internal virtual CreateScriptResponse CreateScript(CreateScriptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScriptResponseUnmarshaller.Instance;

            return Invoke<CreateScriptResponse>(request, options);
        }



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
        public virtual Task<CreateScriptResponse> CreateScriptAsync(CreateScriptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScriptResponseUnmarshaller.Instance;

            return InvokeAsync<CreateScriptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcPeeringAuthorization

        internal virtual CreateVpcPeeringAuthorizationResponse CreateVpcPeeringAuthorization(CreateVpcPeeringAuthorizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcPeeringAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcPeeringAuthorizationResponseUnmarshaller.Instance;

            return Invoke<CreateVpcPeeringAuthorizationResponse>(request, options);
        }



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
        public virtual Task<CreateVpcPeeringAuthorizationResponse> CreateVpcPeeringAuthorizationAsync(CreateVpcPeeringAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcPeeringAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcPeeringAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcPeeringAuthorizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcPeeringConnection

        internal virtual CreateVpcPeeringConnectionResponse CreateVpcPeeringConnection(CreateVpcPeeringConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateVpcPeeringConnectionResponse>(request, options);
        }



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
        public virtual Task<CreateVpcPeeringConnectionResponse> CreateVpcPeeringConnectionAsync(CreateVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcPeeringConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAlias

        internal virtual DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAliasResponse>(request, options);
        }


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
        public virtual Task<DeleteAliasResponse> DeleteAliasAsync(string aliasId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteAliasRequest();
            request.AliasId = aliasId;
            return DeleteAliasAsync(request, cancellationToken);
        }



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
        public virtual Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBuild

        internal virtual DeleteBuildResponse DeleteBuild(DeleteBuildRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBuildResponseUnmarshaller.Instance;

            return Invoke<DeleteBuildResponse>(request, options);
        }


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
        public virtual Task<DeleteBuildResponse> DeleteBuildAsync(string buildId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteBuildRequest();
            request.BuildId = buildId;
            return DeleteBuildAsync(request, cancellationToken);
        }



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
        public virtual Task<DeleteBuildResponse> DeleteBuildAsync(DeleteBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBuildResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBuildResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFleet

        internal virtual DeleteFleetResponse DeleteFleet(DeleteFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetResponse>(request, options);
        }


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
        public virtual Task<DeleteFleetResponse> DeleteFleetAsync(string fleetId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteFleetRequest();
            request.FleetId = fleetId;
            return DeleteFleetAsync(request, cancellationToken);
        }



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
        public virtual Task<DeleteFleetResponse> DeleteFleetAsync(DeleteFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFleetLocations

        internal virtual DeleteFleetLocationsResponse DeleteFleetLocations(DeleteFleetLocationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetLocationsResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetLocationsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteFleetLocationsResponse> DeleteFleetLocationsAsync(DeleteFleetLocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetLocationsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFleetLocationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGameServerGroup

        internal virtual DeleteGameServerGroupResponse DeleteGameServerGroup(DeleteGameServerGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGameServerGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGameServerGroupResponse>(request, options);
        }



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
        public virtual Task<DeleteGameServerGroupResponse> DeleteGameServerGroupAsync(DeleteGameServerGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGameServerGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGameServerGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGameSessionQueue

        internal virtual DeleteGameSessionQueueResponse DeleteGameSessionQueue(DeleteGameSessionQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGameSessionQueueResponseUnmarshaller.Instance;

            return Invoke<DeleteGameSessionQueueResponse>(request, options);
        }



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
        public virtual Task<DeleteGameSessionQueueResponse> DeleteGameSessionQueueAsync(DeleteGameSessionQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGameSessionQueueResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGameSessionQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMatchmakingConfiguration

        internal virtual DeleteMatchmakingConfigurationResponse DeleteMatchmakingConfiguration(DeleteMatchmakingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMatchmakingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteMatchmakingConfigurationResponse>(request, options);
        }



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
        public virtual Task<DeleteMatchmakingConfigurationResponse> DeleteMatchmakingConfigurationAsync(DeleteMatchmakingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMatchmakingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMatchmakingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMatchmakingRuleSet

        internal virtual DeleteMatchmakingRuleSetResponse DeleteMatchmakingRuleSet(DeleteMatchmakingRuleSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMatchmakingRuleSetResponseUnmarshaller.Instance;

            return Invoke<DeleteMatchmakingRuleSetResponse>(request, options);
        }



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
        public virtual Task<DeleteMatchmakingRuleSetResponse> DeleteMatchmakingRuleSetAsync(DeleteMatchmakingRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMatchmakingRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMatchmakingRuleSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteScalingPolicy

        internal virtual DeleteScalingPolicyResponse DeleteScalingPolicy(DeleteScalingPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteScalingPolicyResponse>(request, options);
        }



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
        public virtual Task<DeleteScalingPolicyResponse> DeleteScalingPolicyAsync(DeleteScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScalingPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteScript

        internal virtual DeleteScriptResponse DeleteScript(DeleteScriptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScriptResponseUnmarshaller.Instance;

            return Invoke<DeleteScriptResponse>(request, options);
        }



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
        public virtual Task<DeleteScriptResponse> DeleteScriptAsync(DeleteScriptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScriptResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScriptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcPeeringAuthorization

        internal virtual DeleteVpcPeeringAuthorizationResponse DeleteVpcPeeringAuthorization(DeleteVpcPeeringAuthorizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcPeeringAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcPeeringAuthorizationResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcPeeringAuthorizationResponse>(request, options);
        }



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
        public virtual Task<DeleteVpcPeeringAuthorizationResponse> DeleteVpcPeeringAuthorizationAsync(DeleteVpcPeeringAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcPeeringAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcPeeringAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcPeeringAuthorizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcPeeringConnection

        internal virtual DeleteVpcPeeringConnectionResponse DeleteVpcPeeringConnection(DeleteVpcPeeringConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcPeeringConnectionResponse>(request, options);
        }



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
        public virtual Task<DeleteVpcPeeringConnectionResponse> DeleteVpcPeeringConnectionAsync(DeleteVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcPeeringConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterGameServer

        internal virtual DeregisterGameServerResponse DeregisterGameServer(DeregisterGameServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterGameServerResponseUnmarshaller.Instance;

            return Invoke<DeregisterGameServerResponse>(request, options);
        }



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
        public virtual Task<DeregisterGameServerResponse> DeregisterGameServerAsync(DeregisterGameServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterGameServerResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterGameServerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAlias

        internal virtual DescribeAliasResponse DescribeAlias(DescribeAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAliasResponseUnmarshaller.Instance;

            return Invoke<DescribeAliasResponse>(request, options);
        }


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
        public virtual Task<DescribeAliasResponse> DescribeAliasAsync(string aliasId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeAliasRequest();
            request.AliasId = aliasId;
            return DescribeAliasAsync(request, cancellationToken);
        }



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
        public virtual Task<DescribeAliasResponse> DescribeAliasAsync(DescribeAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeBuild

        internal virtual DescribeBuildResponse DescribeBuild(DescribeBuildRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBuildResponseUnmarshaller.Instance;

            return Invoke<DescribeBuildResponse>(request, options);
        }


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
        public virtual Task<DescribeBuildResponse> DescribeBuildAsync(string buildId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeBuildRequest();
            request.BuildId = buildId;
            return DescribeBuildAsync(request, cancellationToken);
        }



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
        public virtual Task<DescribeBuildResponse> DescribeBuildAsync(DescribeBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBuildResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBuildResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEC2InstanceLimits

        internal virtual DescribeEC2InstanceLimitsResponse DescribeEC2InstanceLimits(DescribeEC2InstanceLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEC2InstanceLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEC2InstanceLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeEC2InstanceLimitsResponse>(request, options);
        }


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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeEC2InstanceLimits">REST API Reference for DescribeEC2InstanceLimits Operation</seealso>
        public virtual Task<DescribeEC2InstanceLimitsResponse> DescribeEC2InstanceLimitsAsync(EC2InstanceType ec2InstanceType, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeEC2InstanceLimitsRequest();
            request.EC2InstanceType = ec2InstanceType;
            return DescribeEC2InstanceLimitsAsync(request, cancellationToken);
        }



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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeEC2InstanceLimits">REST API Reference for DescribeEC2InstanceLimits Operation</seealso>
        public virtual Task<DescribeEC2InstanceLimitsResponse> DescribeEC2InstanceLimitsAsync(DescribeEC2InstanceLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEC2InstanceLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEC2InstanceLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEC2InstanceLimitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetAttributes

        internal virtual DescribeFleetAttributesResponse DescribeFleetAttributes(DescribeFleetAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetAttributesResponse>(request, options);
        }



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
        public virtual Task<DescribeFleetAttributesResponse> DescribeFleetAttributesAsync(DescribeFleetAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetCapacity

        internal virtual DescribeFleetCapacityResponse DescribeFleetCapacity(DescribeFleetCapacityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetCapacityResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetCapacityResponse>(request, options);
        }



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
        public virtual Task<DescribeFleetCapacityResponse> DescribeFleetCapacityAsync(DescribeFleetCapacityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetCapacityResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetCapacityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetEvents

        internal virtual DescribeFleetEventsResponse DescribeFleetEvents(DescribeFleetEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetEventsResponse>(request, options);
        }



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
        public virtual Task<DescribeFleetEventsResponse> DescribeFleetEventsAsync(DescribeFleetEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetLocationAttributes

        internal virtual DescribeFleetLocationAttributesResponse DescribeFleetLocationAttributes(DescribeFleetLocationAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetLocationAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetLocationAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetLocationAttributesResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeFleetLocationAttributesResponse> DescribeFleetLocationAttributesAsync(DescribeFleetLocationAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetLocationAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetLocationAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetLocationAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetLocationCapacity

        internal virtual DescribeFleetLocationCapacityResponse DescribeFleetLocationCapacity(DescribeFleetLocationCapacityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetLocationCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetLocationCapacityResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetLocationCapacityResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeFleetLocationCapacityResponse> DescribeFleetLocationCapacityAsync(DescribeFleetLocationCapacityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetLocationCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetLocationCapacityResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetLocationCapacityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetLocationUtilization

        internal virtual DescribeFleetLocationUtilizationResponse DescribeFleetLocationUtilization(DescribeFleetLocationUtilizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetLocationUtilizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetLocationUtilizationResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetLocationUtilizationResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeFleetLocationUtilizationResponse> DescribeFleetLocationUtilizationAsync(DescribeFleetLocationUtilizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetLocationUtilizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetLocationUtilizationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetLocationUtilizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetPortSettings

        internal virtual DescribeFleetPortSettingsResponse DescribeFleetPortSettings(DescribeFleetPortSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetPortSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetPortSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetPortSettingsResponse>(request, options);
        }


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
        public virtual Task<DescribeFleetPortSettingsResponse> DescribeFleetPortSettingsAsync(string fleetId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeFleetPortSettingsRequest();
            request.FleetId = fleetId;
            return DescribeFleetPortSettingsAsync(request, cancellationToken);
        }



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
        public virtual Task<DescribeFleetPortSettingsResponse> DescribeFleetPortSettingsAsync(DescribeFleetPortSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetPortSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetPortSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetPortSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetUtilization

        internal virtual DescribeFleetUtilizationResponse DescribeFleetUtilization(DescribeFleetUtilizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetUtilizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetUtilizationResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetUtilizationResponse>(request, options);
        }



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
        public virtual Task<DescribeFleetUtilizationResponse> DescribeFleetUtilizationAsync(DescribeFleetUtilizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetUtilizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetUtilizationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetUtilizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeGameServer

        internal virtual DescribeGameServerResponse DescribeGameServer(DescribeGameServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameServerResponseUnmarshaller.Instance;

            return Invoke<DescribeGameServerResponse>(request, options);
        }



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
        public virtual Task<DescribeGameServerResponse> DescribeGameServerAsync(DescribeGameServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameServerResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameServerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeGameServerGroup

        internal virtual DescribeGameServerGroupResponse DescribeGameServerGroup(DescribeGameServerGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameServerGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeGameServerGroupResponse>(request, options);
        }



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
        public virtual Task<DescribeGameServerGroupResponse> DescribeGameServerGroupAsync(DescribeGameServerGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameServerGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameServerGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeGameServerInstances

        internal virtual DescribeGameServerInstancesResponse DescribeGameServerInstances(DescribeGameServerInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameServerInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameServerInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeGameServerInstancesResponse>(request, options);
        }



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
        public virtual Task<DescribeGameServerInstancesResponse> DescribeGameServerInstancesAsync(DescribeGameServerInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameServerInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameServerInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameServerInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeGameSessionDetails

        internal virtual DescribeGameSessionDetailsResponse DescribeGameSessionDetails(DescribeGameSessionDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionDetailsResponseUnmarshaller.Instance;

            return Invoke<DescribeGameSessionDetailsResponse>(request, options);
        }



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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionDetails">REST API Reference for DescribeGameSessionDetails Operation</seealso>
        public virtual Task<DescribeGameSessionDetailsResponse> DescribeGameSessionDetailsAsync(DescribeGameSessionDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameSessionDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeGameSessionPlacement

        internal virtual DescribeGameSessionPlacementResponse DescribeGameSessionPlacement(DescribeGameSessionPlacementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionPlacementResponseUnmarshaller.Instance;

            return Invoke<DescribeGameSessionPlacementResponse>(request, options);
        }



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
        public virtual Task<DescribeGameSessionPlacementResponse> DescribeGameSessionPlacementAsync(DescribeGameSessionPlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionPlacementResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameSessionPlacementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeGameSessionQueues

        internal virtual DescribeGameSessionQueuesResponse DescribeGameSessionQueues(DescribeGameSessionQueuesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionQueuesResponseUnmarshaller.Instance;

            return Invoke<DescribeGameSessionQueuesResponse>(request, options);
        }



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
        public virtual Task<DescribeGameSessionQueuesResponse> DescribeGameSessionQueuesAsync(DescribeGameSessionQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionQueuesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameSessionQueuesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeGameSessions

        internal virtual DescribeGameSessionsResponse DescribeGameSessions(DescribeGameSessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionsResponseUnmarshaller.Instance;

            return Invoke<DescribeGameSessionsResponse>(request, options);
        }



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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessions">REST API Reference for DescribeGameSessions Operation</seealso>
        public virtual Task<DescribeGameSessionsResponse> DescribeGameSessionsAsync(DescribeGameSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameSessionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstances

        internal virtual DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancesResponse>(request, options);
        }



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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        public virtual Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMatchmaking

        internal virtual DescribeMatchmakingResponse DescribeMatchmaking(DescribeMatchmakingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMatchmakingResponseUnmarshaller.Instance;

            return Invoke<DescribeMatchmakingResponse>(request, options);
        }



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
        public virtual Task<DescribeMatchmakingResponse> DescribeMatchmakingAsync(DescribeMatchmakingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMatchmakingResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMatchmakingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMatchmakingConfigurations

        internal virtual DescribeMatchmakingConfigurationsResponse DescribeMatchmakingConfigurations(DescribeMatchmakingConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMatchmakingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMatchmakingConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeMatchmakingConfigurationsResponse>(request, options);
        }



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
        public virtual Task<DescribeMatchmakingConfigurationsResponse> DescribeMatchmakingConfigurationsAsync(DescribeMatchmakingConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMatchmakingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMatchmakingConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMatchmakingConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMatchmakingRuleSets

        internal virtual DescribeMatchmakingRuleSetsResponse DescribeMatchmakingRuleSets(DescribeMatchmakingRuleSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMatchmakingRuleSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMatchmakingRuleSetsResponseUnmarshaller.Instance;

            return Invoke<DescribeMatchmakingRuleSetsResponse>(request, options);
        }



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
        public virtual Task<DescribeMatchmakingRuleSetsResponse> DescribeMatchmakingRuleSetsAsync(DescribeMatchmakingRuleSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMatchmakingRuleSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMatchmakingRuleSetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMatchmakingRuleSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePlayerSessions

        internal virtual DescribePlayerSessionsResponse DescribePlayerSessions(DescribePlayerSessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePlayerSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePlayerSessionsResponseUnmarshaller.Instance;

            return Invoke<DescribePlayerSessionsResponse>(request, options);
        }



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
        public virtual Task<DescribePlayerSessionsResponse> DescribePlayerSessionsAsync(DescribePlayerSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePlayerSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePlayerSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePlayerSessionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRuntimeConfiguration

        internal virtual DescribeRuntimeConfigurationResponse DescribeRuntimeConfiguration(DescribeRuntimeConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRuntimeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuntimeConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeRuntimeConfigurationResponse>(request, options);
        }



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
        public virtual Task<DescribeRuntimeConfigurationResponse> DescribeRuntimeConfigurationAsync(DescribeRuntimeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRuntimeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuntimeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRuntimeConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalingPolicies

        internal virtual DescribeScalingPoliciesResponse DescribeScalingPolicies(DescribeScalingPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingPoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingPoliciesResponse>(request, options);
        }



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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeScalingPolicies">REST API Reference for DescribeScalingPolicies Operation</seealso>
        public virtual Task<DescribeScalingPoliciesResponse> DescribeScalingPoliciesAsync(DescribeScalingPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalingPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScript

        internal virtual DescribeScriptResponse DescribeScript(DescribeScriptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScriptResponseUnmarshaller.Instance;

            return Invoke<DescribeScriptResponse>(request, options);
        }



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
        public virtual Task<DescribeScriptResponse> DescribeScriptAsync(DescribeScriptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScriptResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScriptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcPeeringAuthorizations

        internal virtual DescribeVpcPeeringAuthorizationsResponse DescribeVpcPeeringAuthorizations(DescribeVpcPeeringAuthorizationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcPeeringAuthorizationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcPeeringAuthorizationsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcPeeringAuthorizationsResponse>(request, options);
        }



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
        public virtual Task<DescribeVpcPeeringAuthorizationsResponse> DescribeVpcPeeringAuthorizationsAsync(DescribeVpcPeeringAuthorizationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcPeeringAuthorizationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcPeeringAuthorizationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcPeeringAuthorizationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcPeeringConnections

        internal virtual DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcPeeringConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcPeeringConnectionsResponse>(request, options);
        }



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
        public virtual Task<DescribeVpcPeeringConnectionsResponse> DescribeVpcPeeringConnectionsAsync(DescribeVpcPeeringConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcPeeringConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcPeeringConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGameSessionLogUrl

        internal virtual GetGameSessionLogUrlResponse GetGameSessionLogUrl(GetGameSessionLogUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGameSessionLogUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGameSessionLogUrlResponseUnmarshaller.Instance;

            return Invoke<GetGameSessionLogUrlResponse>(request, options);
        }


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
        public virtual Task<GetGameSessionLogUrlResponse> GetGameSessionLogUrlAsync(string gameSessionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetGameSessionLogUrlRequest();
            request.GameSessionId = gameSessionId;
            return GetGameSessionLogUrlAsync(request, cancellationToken);
        }



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
        public virtual Task<GetGameSessionLogUrlResponse> GetGameSessionLogUrlAsync(GetGameSessionLogUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGameSessionLogUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGameSessionLogUrlResponseUnmarshaller.Instance;

            return InvokeAsync<GetGameSessionLogUrlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInstanceAccess

        internal virtual GetInstanceAccessResponse GetInstanceAccess(GetInstanceAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceAccessResponseUnmarshaller.Instance;

            return Invoke<GetInstanceAccessResponse>(request, options);
        }



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
        public virtual Task<GetInstanceAccessResponse> GetInstanceAccessAsync(GetInstanceAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceAccessResponseUnmarshaller.Instance;

            return InvokeAsync<GetInstanceAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAliases

        internal virtual ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAliasesResponse>(request, options);
        }



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
        public virtual Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAliasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBuilds

        internal virtual ListBuildsResponse ListBuilds(ListBuildsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBuildsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBuildsResponseUnmarshaller.Instance;

            return Invoke<ListBuildsResponse>(request, options);
        }



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
        public virtual Task<ListBuildsResponse> ListBuildsAsync(ListBuildsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBuildsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBuildsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBuildsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFleets

        internal virtual ListFleetsResponse ListFleets(ListFleetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return Invoke<ListFleetsResponse>(request, options);
        }



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
        public virtual Task<ListFleetsResponse> ListFleetsAsync(ListFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFleetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGameServerGroups

        internal virtual ListGameServerGroupsResponse ListGameServerGroups(ListGameServerGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGameServerGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGameServerGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGameServerGroupsResponse>(request, options);
        }



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
        public virtual Task<ListGameServerGroupsResponse> ListGameServerGroupsAsync(ListGameServerGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGameServerGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGameServerGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGameServerGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGameServers

        internal virtual ListGameServersResponse ListGameServers(ListGameServersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGameServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGameServersResponseUnmarshaller.Instance;

            return Invoke<ListGameServersResponse>(request, options);
        }



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
        public virtual Task<ListGameServersResponse> ListGameServersAsync(ListGameServersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGameServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGameServersResponseUnmarshaller.Instance;

            return InvokeAsync<ListGameServersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListScripts

        internal virtual ListScriptsResponse ListScripts(ListScriptsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScriptsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScriptsResponseUnmarshaller.Instance;

            return Invoke<ListScriptsResponse>(request, options);
        }



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
        public virtual Task<ListScriptsResponse> ListScriptsAsync(ListScriptsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScriptsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScriptsResponseUnmarshaller.Instance;

            return InvokeAsync<ListScriptsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutScalingPolicy

        internal virtual PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<PutScalingPolicyResponse>(request, options);
        }



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
        public virtual Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutScalingPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterGameServer

        internal virtual RegisterGameServerResponse RegisterGameServer(RegisterGameServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterGameServerResponseUnmarshaller.Instance;

            return Invoke<RegisterGameServerResponse>(request, options);
        }



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
        public virtual Task<RegisterGameServerResponse> RegisterGameServerAsync(RegisterGameServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterGameServerResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterGameServerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RequestUploadCredentials

        internal virtual RequestUploadCredentialsResponse RequestUploadCredentials(RequestUploadCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestUploadCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestUploadCredentialsResponseUnmarshaller.Instance;

            return Invoke<RequestUploadCredentialsResponse>(request, options);
        }


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
        public virtual Task<RequestUploadCredentialsResponse> RequestUploadCredentialsAsync(string buildId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RequestUploadCredentialsRequest();
            request.BuildId = buildId;
            return RequestUploadCredentialsAsync(request, cancellationToken);
        }



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
        public virtual Task<RequestUploadCredentialsResponse> RequestUploadCredentialsAsync(RequestUploadCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestUploadCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestUploadCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<RequestUploadCredentialsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResolveAlias

        internal virtual ResolveAliasResponse ResolveAlias(ResolveAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResolveAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveAliasResponseUnmarshaller.Instance;

            return Invoke<ResolveAliasResponse>(request, options);
        }


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
        public virtual Task<ResolveAliasResponse> ResolveAliasAsync(string aliasId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ResolveAliasRequest();
            request.AliasId = aliasId;
            return ResolveAliasAsync(request, cancellationToken);
        }



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
        public virtual Task<ResolveAliasResponse> ResolveAliasAsync(ResolveAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResolveAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveAliasResponseUnmarshaller.Instance;

            return InvokeAsync<ResolveAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResumeGameServerGroup

        internal virtual ResumeGameServerGroupResponse ResumeGameServerGroup(ResumeGameServerGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeGameServerGroupResponseUnmarshaller.Instance;

            return Invoke<ResumeGameServerGroupResponse>(request, options);
        }



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
        public virtual Task<ResumeGameServerGroupResponse> ResumeGameServerGroupAsync(ResumeGameServerGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeGameServerGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ResumeGameServerGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchGameSessions

        internal virtual SearchGameSessionsResponse SearchGameSessions(SearchGameSessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchGameSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchGameSessionsResponseUnmarshaller.Instance;

            return Invoke<SearchGameSessionsResponse>(request, options);
        }



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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/SearchGameSessions">REST API Reference for SearchGameSessions Operation</seealso>
        public virtual Task<SearchGameSessionsResponse> SearchGameSessionsAsync(SearchGameSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchGameSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchGameSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchGameSessionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartFleetActions

        internal virtual StartFleetActionsResponse StartFleetActions(StartFleetActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFleetActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFleetActionsResponseUnmarshaller.Instance;

            return Invoke<StartFleetActionsResponse>(request, options);
        }



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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartFleetActions">REST API Reference for StartFleetActions Operation</seealso>
        public virtual Task<StartFleetActionsResponse> StartFleetActionsAsync(StartFleetActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFleetActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFleetActionsResponseUnmarshaller.Instance;

            return InvokeAsync<StartFleetActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartGameSessionPlacement

        internal virtual StartGameSessionPlacementResponse StartGameSessionPlacement(StartGameSessionPlacementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGameSessionPlacementResponseUnmarshaller.Instance;

            return Invoke<StartGameSessionPlacementResponse>(request, options);
        }



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
        public virtual Task<StartGameSessionPlacementResponse> StartGameSessionPlacementAsync(StartGameSessionPlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGameSessionPlacementResponseUnmarshaller.Instance;

            return InvokeAsync<StartGameSessionPlacementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartMatchBackfill

        internal virtual StartMatchBackfillResponse StartMatchBackfill(StartMatchBackfillRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMatchBackfillRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMatchBackfillResponseUnmarshaller.Instance;

            return Invoke<StartMatchBackfillResponse>(request, options);
        }



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
        public virtual Task<StartMatchBackfillResponse> StartMatchBackfillAsync(StartMatchBackfillRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMatchBackfillRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMatchBackfillResponseUnmarshaller.Instance;

            return InvokeAsync<StartMatchBackfillResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartMatchmaking

        internal virtual StartMatchmakingResponse StartMatchmaking(StartMatchmakingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMatchmakingResponseUnmarshaller.Instance;

            return Invoke<StartMatchmakingResponse>(request, options);
        }



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
        public virtual Task<StartMatchmakingResponse> StartMatchmakingAsync(StartMatchmakingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMatchmakingResponseUnmarshaller.Instance;

            return InvokeAsync<StartMatchmakingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopFleetActions

        internal virtual StopFleetActionsResponse StopFleetActions(StopFleetActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopFleetActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFleetActionsResponseUnmarshaller.Instance;

            return Invoke<StopFleetActionsResponse>(request, options);
        }



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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopFleetActions">REST API Reference for StopFleetActions Operation</seealso>
        public virtual Task<StopFleetActionsResponse> StopFleetActionsAsync(StopFleetActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopFleetActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFleetActionsResponseUnmarshaller.Instance;

            return InvokeAsync<StopFleetActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopGameSessionPlacement

        internal virtual StopGameSessionPlacementResponse StopGameSessionPlacement(StopGameSessionPlacementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopGameSessionPlacementResponseUnmarshaller.Instance;

            return Invoke<StopGameSessionPlacementResponse>(request, options);
        }



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
        public virtual Task<StopGameSessionPlacementResponse> StopGameSessionPlacementAsync(StopGameSessionPlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopGameSessionPlacementResponseUnmarshaller.Instance;

            return InvokeAsync<StopGameSessionPlacementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopMatchmaking

        internal virtual StopMatchmakingResponse StopMatchmaking(StopMatchmakingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopMatchmakingResponseUnmarshaller.Instance;

            return Invoke<StopMatchmakingResponse>(request, options);
        }



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
        public virtual Task<StopMatchmakingResponse> StopMatchmakingAsync(StopMatchmakingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopMatchmakingResponseUnmarshaller.Instance;

            return InvokeAsync<StopMatchmakingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SuspendGameServerGroup

        internal virtual SuspendGameServerGroupResponse SuspendGameServerGroup(SuspendGameServerGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SuspendGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SuspendGameServerGroupResponseUnmarshaller.Instance;

            return Invoke<SuspendGameServerGroupResponse>(request, options);
        }



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
        public virtual Task<SuspendGameServerGroupResponse> SuspendGameServerGroupAsync(SuspendGameServerGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SuspendGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SuspendGameServerGroupResponseUnmarshaller.Instance;

            return InvokeAsync<SuspendGameServerGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAlias

        internal virtual UpdateAliasResponse UpdateAlias(UpdateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateAliasResponse>(request, options);
        }



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
        public virtual Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBuild

        internal virtual UpdateBuildResponse UpdateBuild(UpdateBuildRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBuildResponseUnmarshaller.Instance;

            return Invoke<UpdateBuildResponse>(request, options);
        }



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
        public virtual Task<UpdateBuildResponse> UpdateBuildAsync(UpdateBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBuildResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBuildResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFleetAttributes

        internal virtual UpdateFleetAttributesResponse UpdateFleetAttributes(UpdateFleetAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetAttributesResponse>(request, options);
        }



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
        public virtual Task<UpdateFleetAttributesResponse> UpdateFleetAttributesAsync(UpdateFleetAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFleetAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFleetCapacity

        internal virtual UpdateFleetCapacityResponse UpdateFleetCapacity(UpdateFleetCapacityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetCapacityResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetCapacityResponse>(request, options);
        }



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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetCapacity">REST API Reference for UpdateFleetCapacity Operation</seealso>
        public virtual Task<UpdateFleetCapacityResponse> UpdateFleetCapacityAsync(UpdateFleetCapacityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetCapacityResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFleetCapacityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFleetPortSettings

        internal virtual UpdateFleetPortSettingsResponse UpdateFleetPortSettings(UpdateFleetPortSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetPortSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetPortSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetPortSettingsResponse>(request, options);
        }



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
        public virtual Task<UpdateFleetPortSettingsResponse> UpdateFleetPortSettingsAsync(UpdateFleetPortSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetPortSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetPortSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFleetPortSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGameServer

        internal virtual UpdateGameServerResponse UpdateGameServer(UpdateGameServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameServerResponseUnmarshaller.Instance;

            return Invoke<UpdateGameServerResponse>(request, options);
        }



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
        public virtual Task<UpdateGameServerResponse> UpdateGameServerAsync(UpdateGameServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameServerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGameServerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGameServerGroup

        internal virtual UpdateGameServerGroupResponse UpdateGameServerGroup(UpdateGameServerGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameServerGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGameServerGroupResponse>(request, options);
        }



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
        public virtual Task<UpdateGameServerGroupResponse> UpdateGameServerGroupAsync(UpdateGameServerGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameServerGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGameServerGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGameSession

        internal virtual UpdateGameSessionResponse UpdateGameSession(UpdateGameSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameSessionResponseUnmarshaller.Instance;

            return Invoke<UpdateGameSessionResponse>(request, options);
        }



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
        public virtual Task<UpdateGameSessionResponse> UpdateGameSessionAsync(UpdateGameSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameSessionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGameSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGameSessionQueue

        internal virtual UpdateGameSessionQueueResponse UpdateGameSessionQueue(UpdateGameSessionQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameSessionQueueResponseUnmarshaller.Instance;

            return Invoke<UpdateGameSessionQueueResponse>(request, options);
        }



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
        public virtual Task<UpdateGameSessionQueueResponse> UpdateGameSessionQueueAsync(UpdateGameSessionQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameSessionQueueResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGameSessionQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMatchmakingConfiguration

        internal virtual UpdateMatchmakingConfigurationResponse UpdateMatchmakingConfiguration(UpdateMatchmakingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMatchmakingConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateMatchmakingConfigurationResponse>(request, options);
        }



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
        public virtual Task<UpdateMatchmakingConfigurationResponse> UpdateMatchmakingConfigurationAsync(UpdateMatchmakingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMatchmakingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMatchmakingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRuntimeConfiguration

        internal virtual UpdateRuntimeConfigurationResponse UpdateRuntimeConfiguration(UpdateRuntimeConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuntimeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuntimeConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateRuntimeConfigurationResponse>(request, options);
        }



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
        public virtual Task<UpdateRuntimeConfigurationResponse> UpdateRuntimeConfigurationAsync(UpdateRuntimeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuntimeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuntimeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRuntimeConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateScript

        internal virtual UpdateScriptResponse UpdateScript(UpdateScriptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScriptResponseUnmarshaller.Instance;

            return Invoke<UpdateScriptResponse>(request, options);
        }



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
        public virtual Task<UpdateScriptResponse> UpdateScriptAsync(UpdateScriptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScriptResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateScriptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ValidateMatchmakingRuleSet

        internal virtual ValidateMatchmakingRuleSetResponse ValidateMatchmakingRuleSet(ValidateMatchmakingRuleSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateMatchmakingRuleSetResponseUnmarshaller.Instance;

            return Invoke<ValidateMatchmakingRuleSetResponse>(request, options);
        }



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
        public virtual Task<ValidateMatchmakingRuleSetResponse> ValidateMatchmakingRuleSetAsync(ValidateMatchmakingRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateMatchmakingRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<ValidateMatchmakingRuleSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}