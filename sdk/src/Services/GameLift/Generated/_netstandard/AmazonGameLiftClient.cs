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
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.GameLift
{
    /// <summary>
    /// <para>Implementation for accessing GameLift</para>
    ///
    /// Amazon GameLift Servers provides solutions for hosting session-based multiplayer game
    /// servers in the cloud, including tools for deploying, operating, and scaling game servers.
    /// Built on Amazon Web Services global computing infrastructure, GameLift helps you deliver
    /// high-performance, high-reliability, low-cost game servers while dynamically scaling
    /// your resource usage to meet player demand. 
    /// 
    ///  
    /// <para>
    ///  <b>About Amazon GameLift Servers solutions</b> 
    /// </para>
    ///  
    /// <para>
    /// Get more information on these Amazon GameLift Servers solutions in the <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/">Amazon
    /// GameLift Servers Developer Guide</a>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon GameLift Servers managed hosting -- Amazon GameLift Servers offers a fully
    /// managed service to set up and maintain computing machines for hosting, manage game
    /// session and player session life cycle, and handle security, storage, and performance
    /// tracking. You can use automatic scaling tools to balance player demand and hosting
    /// costs, configure your game session management to minimize player latency, and add
    /// FlexMatch for matchmaking.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Managed hosting with Amazon GameLift Servers Realtime -- With Amazon GameLift Servers
    /// Amazon GameLift Servers Realtime, you can quickly configure and set up ready-to-go
    /// game servers for your game. Amazon GameLift Servers Realtime provides a game server
    /// framework with core Amazon GameLift Servers infrastructure already built in. Then
    /// use the full range of Amazon GameLift Servers managed hosting features, including
    /// FlexMatch, for your game.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon GameLift Servers FleetIQ -- Use Amazon GameLift Servers FleetIQ as a standalone
    /// service while hosting your games using EC2 instances and Auto Scaling groups. Amazon
    /// GameLift Servers FleetIQ provides optimizations for game hosting, including boosting
    /// the viability of low-cost Spot Instances gaming. For a complete solution, pair the
    /// Amazon GameLift Servers FleetIQ and FlexMatch standalone services.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon GameLift Servers FlexMatch -- Add matchmaking to your game hosting solution.
    /// FlexMatch is a customizable matchmaking service for multiplayer games. Use FlexMatch
    /// as integrated with Amazon GameLift Servers managed hosting or incorporate FlexMatch
    /// as a standalone service into your own hosting solution.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>About this API Reference</b> 
    /// </para>
    ///  
    /// <para>
    /// This reference guide describes the low-level service API for Amazon GameLift Servers.
    /// With each topic in this guide, you can find links to language-specific SDK guides
    /// and the Amazon Web Services CLI reference. Useful links:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html">Amazon
    /// GameLift Servers API operations listed by tasks</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-components.html">
    /// Amazon GameLift Servers tools and resources</a> 
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
            : base(new AmazonGameLiftConfig()) { }

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
            : base(new AmazonGameLiftConfig{RegionEndpoint = region}) { }

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
            : base(config) { }


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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonGameLiftEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonGameLiftAuthSchemeHandler());
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// match are placed into status <c>REQUIRES_ACCEPTANCE</c>. This is a trigger for your
        /// game to get acceptance from all players in each ticket. Calls to this action are only
        /// valid for tickets that are in this status; calls for tickets not in this status result
        /// in an error.
        /// </para>
        ///  
        /// <para>
        /// To register acceptance, specify the ticket ID, one or more players, and an acceptance
        /// response. When all players have accepted, Amazon GameLift Servers advances the matchmaking
        /// tickets to status <c>PLACING</c>, and attempts to create a new game session for the
        /// match. 
        /// </para>
        ///  
        /// <para>
        /// If any player rejects the match, or if acceptances are not received before a specified
        /// timeout, the proposed match is dropped. Each matchmaking ticket in the failed match
        /// is handled as follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the ticket has one or more players who rejected the match or failed to respond,
        /// the ticket status is set <c>CANCELLED</c> and processing is terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If all players in the ticket accepted the match, the ticket status is returned to
        /// <c>SEARCHING</c> to find a new match. 
        /// </para>
        ///  </li> </ul> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/AcceptMatch">REST API Reference for AcceptMatch Operation</seealso>
        public virtual Task<AcceptMatchResponse> AcceptMatchAsync(AcceptMatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptMatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptMatchResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptMatchResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ClaimGameServer

        internal virtual ClaimGameServerResponse ClaimGameServer(ClaimGameServerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ClaimGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ClaimGameServerResponseUnmarshaller.Instance;

            return Invoke<ClaimGameServerResponse>(request, options);
        }



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift Servers FleetIQ solution and game
        /// server groups.</b> 
        /// 
        ///  
        /// <para>
        /// Locates an available game server and temporarily reserves it to host gameplay and
        /// players. This operation is called from a game client or client service (such as a
        /// matchmaker) to request hosting resources for a new game session. In response, Amazon
        /// GameLift Servers FleetIQ locates an available game server, places it in <c>CLAIMED</c>
        /// status for 60 seconds, and returns connection information that players can use to
        /// connect to the game server. 
        /// </para>
        ///  
        /// <para>
        /// To claim a game server, identify a game server group. You can also specify a game
        /// server ID, although this approach bypasses Amazon GameLift Servers FleetIQ placement
        /// optimization. Optionally, include game data to pass to the game server at the start
        /// of a game session, such as a game map or player information. Add filter options to
        /// further restrict how a game server is chosen, such as only allowing game servers on
        /// <c>ACTIVE</c> instances to be claimed.
        /// </para>
        ///  
        /// <para>
        /// When a game server is successfully claimed, connection information is returned. A
        /// claimed game server's utilization status remains <c>AVAILABLE</c> while the claim
        /// status is set to <c>CLAIMED</c> for up to 60 seconds. This time period gives the game
        /// server time to update its status to <c>UTILIZED</c> after players join. If the game
        /// server's status is not updated within 60 seconds, the game server reverts to unclaimed
        /// status and is available to be claimed by another request. The claim time period is
        /// a fixed value and is not configurable.
        /// </para>
        ///  
        /// <para>
        /// If you try to claim a specific game server, this request will fail in the following
        /// cases:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the game server utilization status is <c>UTILIZED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the game server claim status is <c>CLAIMED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the game server is running on an instance in <c>DRAINING</c> status and the provided
        /// filter option does not allow placing on <c>DRAINING</c> instances.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">Amazon
        /// GameLift Servers FleetIQ Guide</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.OutOfCapacityException">
        /// The specified game server group has no available game servers to fulfill a <c>ClaimGameServer</c>
        /// request. Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ClaimGameServer">REST API Reference for ClaimGameServer Operation</seealso>
        public virtual Task<ClaimGameServerResponse> ClaimGameServerAsync(ClaimGameServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ClaimGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ClaimGameServerResponseUnmarshaller.Instance;

            return InvokeAsync<ClaimGameServerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAlias

        internal virtual CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Amazon GameLift Servers supports two types of routing strategies for aliases: simple
        /// and terminal. A simple alias points to an active fleet. A terminal alias is used to
        /// display messaging or link to a URL instead of routing players to an active fleet.
        /// For example, you might use a terminal alias when a game version is no longer supported
        /// and you want to direct players to an upgrade site. 
        /// </para>
        ///  
        /// <para>
        /// To create a fleet alias, specify an alias name, routing strategy, and optional description.
        /// Each simple alias can point to only one fleet, but a fleet can have multiple aliases.
        /// If successful, a new alias record is returned, including an alias ID and an ARN. You
        /// can reassign an alias to another fleet by calling <c>UpdateAlias</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateBuild

        internal virtual CreateBuildResponse CreateBuild(CreateBuildRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBuildResponseUnmarshaller.Instance;

            return Invoke<CreateBuildResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Amazon GameLift Servers build resource for your game server binary files.
        /// Combine game server binaries into a zip file for use with Amazon GameLift Servers.
        /// 
        /// 
        ///  <important> 
        /// <para>
        /// When setting up a new game build for Amazon GameLift Servers, we recommend using the
        /// CLI command <b> <a href="https://docs.aws.amazon.com/cli/latest/reference/gamelift/upload-build.html">upload-build</a>
        /// </b>. This helper command combines two tasks: (1) it uploads your build files from
        /// a file directory to an Amazon GameLift Servers Amazon S3 location, and (2) it creates
        /// a new build resource.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can use the <c>CreateBuild</c> operation in the following scenarios:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Create a new game build with build files that are in an Amazon S3 location under an
        /// Amazon Web Services account that you control. To use this option, you give Amazon
        /// GameLift Servers access to the Amazon S3 bucket. With permissions in place, specify
        /// a build name, operating system, and the Amazon S3 storage location of your game build.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Upload your build files to a Amazon GameLift Servers Amazon S3 location. To use this
        /// option, specify a build name and operating system. This operation creates a new build
        /// resource and also returns an Amazon S3 location with temporary access credentials.
        /// Use the credentials to manually upload your build files to the specified Amazon S3
        /// location. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UploadingObjects.html">Uploading
        /// Objects</a> in the <i>Amazon S3 Developer Guide</i>. After you upload build files
        /// to the Amazon GameLift Servers Amazon S3 location, you can't update them. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If successful, this operation creates a new build resource with a unique build ID
        /// and places it in <c>INITIALIZED</c> status. A build must be in <c>READY</c> status
        /// before you can create fleets with it.
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBuildResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBuildResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateContainerFleet

        internal virtual CreateContainerFleetResponse CreateContainerFleet(CreateContainerFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContainerFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContainerFleetResponseUnmarshaller.Instance;

            return Invoke<CreateContainerFleetResponse>(request, options);
        }



        /// <summary>
        /// Creates a managed fleet of Amazon Elastic Compute Cloud (Amazon EC2) instances to
        /// host your containerized game servers. Use this operation to define how to deploy a
        /// container architecture onto each fleet instance and configure fleet settings. You
        /// can create a container fleet in any Amazon Web Services Regions that Amazon GameLift
        /// Servers supports for multi-location fleets. A container fleet can be deployed to a
        /// single location or multiple locations. Container fleets are deployed with Amazon Linux
        /// 2023 as the instance operating system.
        /// 
        ///  
        /// <para>
        /// Define the fleet's container architecture using container group definitions. Each
        /// fleet can have one of the following container group types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The game server container group runs your game server build and dependent software.
        /// Amazon GameLift Servers deploys one or more replicas of this container group to each
        /// fleet instance. The number of replicas depends on the computing capabilities of the
        /// fleet instance in use. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An optional per-instance container group might be used to run other software that
        /// only needs to run once per instance, such as background services, logging, or test
        /// processes. One per-instance container group is deployed to each fleet instance. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Each container group can include the definition for one or more containers. A container
        /// definition specifies a container image that is stored in an Amazon Elastic Container
        /// Registry (Amazon ECR) public or private repository.
        /// </para>
        ///  
        /// <para>
        ///  <b>Request options</b> 
        /// </para>
        ///  
        /// <para>
        /// Use this operation to make the following types of requests. Most fleet settings have
        /// default values, so you can create a working fleet with a minimal configuration and
        /// default values, which you can customize later.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Create a fleet with no container groups. You can configure a container fleet and then
        /// add container group definitions later. In this scenario, no fleet instances are deployed,
        /// and the fleet can't host game sessions until you add a game server container group
        /// definition. Provide the following required parameter values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FleetRoleArn</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Create a fleet with a game server container group. Provide the following required
        /// parameter values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FleetRoleArn</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GameServerContainerGroupDefinitionName</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Create a fleet with a game server container group and a per-instance container group.
        /// Provide the following required parameter values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FleetRoleArn</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GameServerContainerGroupDefinitionName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PerInstanceContainerGroupDefinitionName</c> 
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        ///  <b>Results</b> 
        /// </para>
        ///  
        /// <para>
        /// If successful, this operation creates a new container fleet resource, places it in
        /// <c>PENDING</c> status, and initiates the <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-all.html#fleets-creation-workflow">fleet
        /// creation workflow</a>. For fleets with container groups, this workflow starts a fleet
        /// deployment and transitions the status to <c>ACTIVE</c>. Fleets without a container
        /// group are placed in <c>CREATED</c> status.
        /// </para>
        ///  
        /// <para>
        /// You can update most of the properties of a fleet, including container group definitions,
        /// and deploy the update across all fleet instances. Use a fleet update to deploy a new
        /// game server version update across the container fleet. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContainerFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateContainerFleet service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateContainerFleet">REST API Reference for CreateContainerFleet Operation</seealso>
        public virtual Task<CreateContainerFleetResponse> CreateContainerFleetAsync(CreateContainerFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContainerFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContainerFleetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateContainerFleetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateContainerGroupDefinition

        internal virtual CreateContainerGroupDefinitionResponse CreateContainerGroupDefinition(CreateContainerGroupDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContainerGroupDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContainerGroupDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateContainerGroupDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Creates a <c>ContainerGroupDefinition</c> that describes a set of containers for hosting
        /// your game server with Amazon GameLift Servers managed containers hosting. An Amazon
        /// GameLift Servers container group is similar to a container task or pod. Use container
        /// group definitions when you create a container fleet with <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateContainerFleet.html">CreateContainerFleet</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// A container group definition determines how Amazon GameLift Servers deploys your containers
        /// to each instance in a container fleet. You can maintain multiple versions of a container
        /// group definition.
        /// </para>
        ///  
        /// <para>
        /// There are two types of container groups:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A <b>game server container group</b> has the containers that run your game server
        /// application and supporting software. A game server container group can have these
        /// container types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Game server container. This container runs your game server. You can define one game
        /// server container in a game server container group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Support container. This container runs software in parallel with your game server.
        /// You can define up to 8 support containers in a game server group.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When building a game server container group definition, you can choose to bundle your
        /// game server executable and all dependent software into a single game server container.
        /// Alternatively, you can separate the software into one game server container and one
        /// or more support containers.
        /// </para>
        ///  
        /// <para>
        /// On a container fleet instance, a game server container group can be deployed multiple
        /// times (depending on the compute resources of the instance). This means that all containers
        /// in the container group are replicated together.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <b>per-instance container group</b> has containers for processes that aren't replicated
        /// on a container fleet instance. This might include background services, logging, test
        /// processes, or processes that need to persist independently of the game server container
        /// group. When building a per-instance container group, you can define up to 10 support
        /// containers.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// This operation requires Identity and Access Management (IAM) permissions to access
        /// container images in Amazon ECR repositories. See <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-iam-policy-examples.html">
        /// IAM permissions for Amazon GameLift Servers</a> for help setting the appropriate permissions.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Request options</b> 
        /// </para>
        ///  
        /// <para>
        /// Use this operation to make the following types of requests. You can specify values
        /// for the minimum required parameters and customize optional values later.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Create a game server container group definition. Provide the following required parameter
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Name</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ContainerGroupType</c> (<c>GAME_SERVER</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OperatingSystem</c> (omit to use default value)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TotalMemoryLimitMebibytes</c> (omit to use default value)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TotalVcpuLimit </c>(omit to use default value)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// At least one <c>GameServerContainerDefinition</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ContainerName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ImageUrl</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PortConfiguration</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ServerSdkVersion</c> (omit to use default value)
        /// </para>
        ///  </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        /// Create a per-instance container group definition. Provide the following required parameter
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Name</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ContainerGroupType</c> (<c>PER_INSTANCE</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OperatingSystem</c> (omit to use default value)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TotalMemoryLimitMebibytes</c> (omit to use default value)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TotalVcpuLimit </c>(omit to use default value)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// At least one <c>SupportContainerDefinition</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ContainerName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ImageUrl</c> 
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul> 
        /// <para>
        ///  <b>Results</b> 
        /// </para>
        ///  
        /// <para>
        /// If successful, this request creates a <c>ContainerGroupDefinition</c> resource and
        /// assigns a unique ARN value. You can update most properties of a container group definition
        /// by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_UpdateContainerGroupDefinition.html">UpdateContainerGroupDefinition</a>,
        /// and optionally save the update as a new version.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContainerGroupDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateContainerGroupDefinition service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateContainerGroupDefinition">REST API Reference for CreateContainerGroupDefinition Operation</seealso>
        public virtual Task<CreateContainerGroupDefinitionResponse> CreateContainerGroupDefinitionAsync(CreateContainerGroupDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateContainerGroupDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContainerGroupDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateContainerGroupDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFleet

        internal virtual CreateFleetResponse CreateFleet(CreateFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return Invoke<CreateFleetResponse>(request, options);
        }



        /// <summary>
        /// Creates a fleet of compute resources to host your game servers. Use this operation
        /// to set up the following types of fleets based on compute type: 
        /// 
        ///  
        /// <para>
        ///  <b>Managed EC2 fleet</b> 
        /// </para>
        ///  
        /// <para>
        /// An EC2 fleet is a set of Amazon Elastic Compute Cloud (Amazon EC2) instances. Your
        /// game server build is deployed to each fleet instance. Amazon GameLift Servers manages
        /// the fleet's instances and controls the lifecycle of game server processes, which host
        /// game sessions for players. EC2 fleets can have instances in multiple locations. Each
        /// instance in the fleet is designated a <c>Compute</c>.
        /// </para>
        ///  
        /// <para>
        /// To create an EC2 fleet, provide these required parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Either <c>BuildId</c> or <c>ScriptId</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ComputeType</c> set to <c>EC2</c> (the default value)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EC2InboundPermissions</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EC2InstanceType</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FleetType</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Name</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RuntimeConfiguration</c> with at least one <c>ServerProcesses</c> configuration
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If successful, this operation creates a new fleet resource and places it in <c>NEW</c>
        /// status while Amazon GameLift Servers initiates the <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-all.html#fleets-creation-workflow">fleet
        /// creation workflow</a>. To debug your fleet, fetch logs, view performance metrics or
        /// other actions on the fleet, create a development fleet with port 22/3389 open. As
        /// a best practice, we recommend opening ports for remote access only when you need them
        /// and closing them when you're finished. 
        /// </para>
        ///  
        /// <para>
        /// When the fleet status is ACTIVE, you can adjust capacity settings and turn autoscaling
        /// on/off for each location.
        /// </para>
        ///  
        /// <para>
        ///  <b>Anywhere fleet</b> 
        /// </para>
        ///  
        /// <para>
        /// An Anywhere fleet represents compute resources that are not owned or managed by Amazon
        /// GameLift Servers. You might create an Anywhere fleet with your local machine for testing,
        /// or use one to host game servers with on-premises hardware or other game hosting solutions.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To create an Anywhere fleet, provide these required parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ComputeType</c> set to <c>ANYWHERE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Locations</c> specifying a custom location
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Name</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If successful, this operation creates a new fleet resource and places it in <c>ACTIVE</c>
        /// status. You can register computes with a fleet in <c>ACTIVE</c> status. 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotReadyException">
        /// The operation failed because Amazon GameLift Servers has not yet finished validating
        /// this compute. We recommend attempting 8 to 10 retries over 3 to 5 minutes with <a
        /// href="http://aws.amazon.com/blogs/https:/aws.amazon.com/blogs/architecture/exponential-backoff-and-jitter/">exponential
        /// backoffs and jitter</a>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFleetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFleetLocations

        internal virtual CreateFleetLocationsResponse CreateFleetLocations(CreateFleetLocationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFleetLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetLocationsResponseUnmarshaller.Instance;

            return Invoke<CreateFleetLocationsResponse>(request, options);
        }



        /// <summary>
        /// Adds remote locations to an EC2 and begins populating the new locations with instances.
        /// The new instances conform to the fleet's instance type, auto-scaling, and other configuration
        /// settings.
        /// 
        ///  <note> 
        /// <para>
        /// You can't add remote locations to a fleet that resides in an Amazon Web Services Region
        /// that doesn't support multiple locations. Fleets created prior to March 2021 can't
        /// support multiple locations.
        /// </para>
        ///  </note> 
        /// <para>
        /// To add fleet locations, specify the fleet to be updated and provide a list of one
        /// or more locations. 
        /// </para>
        ///  
        /// <para>
        /// If successful, this operation returns the list of added locations with their status
        /// set to <c>NEW</c>. Amazon GameLift Servers initiates the process of starting an instance
        /// in each added location. You can track the status of each new location by monitoring
        /// location creation events using <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetEvents.html">DescribeFleetEvents</a>.
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-editing.html#fleets-update-locations">Update
        /// fleet locations</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-regions.html">
        /// Amazon GameLift Servers service locations</a> for managed hosting.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleetLocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFleetLocations service method, as returned by GameLift.</returns>
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotReadyException">
        /// The operation failed because Amazon GameLift Servers has not yet finished validating
        /// this compute. We recommend attempting 8 to 10 retries over 3 to 5 minutes with <a
        /// href="http://aws.amazon.com/blogs/https:/aws.amazon.com/blogs/architecture/exponential-backoff-and-jitter/">exponential
        /// backoffs and jitter</a>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFleetLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetLocationsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFleetLocationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateGameServerGroup

        internal virtual CreateGameServerGroupResponse CreateGameServerGroup(CreateGameServerGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameServerGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGameServerGroupResponse>(request, options);
        }



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift Servers FleetIQ solution and game
        /// server groups.</b> 
        /// 
        ///  
        /// <para>
        /// Creates a Amazon GameLift Servers FleetIQ game server group for managing game hosting
        /// on a collection of Amazon Elastic Compute Cloud instances for game hosting. This operation
        /// creates the game server group, creates an Auto Scaling group in your Amazon Web Services
        /// account, and establishes a link between the two groups. You can view the status of
        /// your game server groups in the Amazon GameLift Servers console. Game server group
        /// metrics and events are emitted to Amazon CloudWatch.
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
        /// Amazon GameLift Servers FleetIQ to create and interact with the Auto Scaling group.
        /// For more information, see <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-iam-permissions-roles.html">Create
        /// IAM roles for cross-service interaction</a> in the <i>Amazon GameLift Servers FleetIQ
        /// Developer Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To create a new game server group, specify a unique group name, IAM role and Amazon
        /// Elastic Compute Cloud launch template, and provide a list of instance types that can
        /// be used in the group. You must also set initial maximum and minimum limits on the
        /// group's instance count. You can optionally set an Auto Scaling policy with target
        /// tracking based on a Amazon GameLift Servers FleetIQ metric.
        /// </para>
        ///  
        /// <para>
        /// Once the game server group and corresponding Auto Scaling group are created, you have
        /// full access to change the Auto Scaling group's configuration as needed. Several properties
        /// that are set when creating a game server group, including maximum/minimum size and
        /// auto-scaling policy settings, must be updated directly in the Auto Scaling group.
        /// Keep in mind that some Auto Scaling group properties are periodically updated by Amazon
        /// GameLift Servers FleetIQ as part of its balancing activities to optimize for availability
        /// and cost.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">Amazon
        /// GameLift Servers FleetIQ Guide</a> 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameServerGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGameServerGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateGameSession

        internal virtual CreateGameSessionResponse CreateGameSession(CreateGameSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGameSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameSessionResponseUnmarshaller.Instance;

            return Invoke<CreateGameSessionResponse>(request, options);
        }



        /// <summary>
        /// Creates a multiplayer game session for players in a specific fleet location. This
        /// operation prompts an available server process to start a game session and retrieves
        /// connection information for the new game session. As an alternative, consider using
        /// the Amazon GameLift Servers game session placement feature with <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_StartGameSessionPlacement.html">StartGameSessionPlacement</a>,
        /// which uses the FleetIQ algorithm and queues to optimize the placement process.
        /// 
        ///  
        /// <para>
        /// When creating a game session, you specify exactly where you want to place it and provide
        /// a set of game session configuration settings. The target fleet must be in <c>ACTIVE</c>
        /// status. 
        /// </para>
        ///  
        /// <para>
        /// You can use this operation in the following ways: 
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
        ///  </li> <li> 
        /// <para>
        /// To create a game session on an instance in an Anywhere fleet, specify the fleet's
        /// custom location.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If successful, Amazon GameLift Servers initiates a workflow to start a new game session
        /// and returns a <c>GameSession</c> object containing the game session configuration
        /// and status. When the game session status is <c>ACTIVE</c>, it is updated with connection
        /// information and you can create player sessions for the game session. By default, newly
        /// created game sessions are open to new players. You can restrict new player access
        /// by using <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_UpdateGameSession.html">UpdateGameSession</a>
        /// to change the game session's player session creation policy.
        /// </para>
        ///  
        /// <para>
        /// Amazon GameLift Servers retains logs for active for 14 days. To access the logs, call
        /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GetGameSessionLogUrl.html">GetGameSessionLogUrl</a>
        /// to download the log files.
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Servers Local.</i> 
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The specified fleet has no available instances to fulfill a <c>CreateGameSession</c>
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <c>RoutingStrategy</c> associated with it. The message returned in this
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGameSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameSessionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGameSessionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateGameSessionQueue

        internal virtual CreateGameSessionQueueResponse CreateGameSessionQueue(CreateGameSessionQueueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameSessionQueueResponseUnmarshaller.Instance;

            return Invoke<CreateGameSessionQueueResponse>(request, options);
        }



        /// <summary>
        /// Creates a placement queue that processes requests for new game sessions. A queue uses
        /// FleetIQ algorithms to locate the best available placement locations for a new game
        /// session, and then prompts the game server process to start a new game session.
        /// 
        ///  
        /// <para>
        /// A game session queue is configured with a set of destinations (Amazon GameLift Servers
        /// fleets or aliases) that determine where the queue can place new game sessions. These
        /// destinations can span multiple Amazon Web Services Regions, can use different instance
        /// types, and can include both Spot and On-Demand fleets. If the queue includes multi-location
        /// fleets, the queue can place game sessions in any of a fleet's remote locations.
        /// </para>
        ///  
        /// <para>
        /// You can configure a queue to determine how it selects the best available placement
        /// for a new game session. Queues can prioritize placement decisions based on a combination
        /// of location, hosting cost, and player latency. You can set up the queue to use the
        /// default prioritization or provide alternate instructions using <c>PriorityConfiguration</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Request options</b> 
        /// </para>
        ///  
        /// <para>
        /// Use this operation to make these common types of requests. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Create a queue with the minimum required parameters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Name</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Destinations</c> (This parameter isn't required, but a queue can't make placements
        /// without at least one destination.)
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Create a queue with placement notification. Queues that have high placement activity
        /// must use a notification system, such as with Amazon Simple Notification Service (Amazon
        /// SNS) or Amazon CloudWatch.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Required parameters <c>Name</c> and <c>Destinations</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NotificationTarget</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Create a queue with custom prioritization settings. These custom settings replace
        /// the default prioritization configuration for a queue.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Required parameters <c>Name</c> and <c>Destinations</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PriorityConfiguration</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Create a queue with special rules for processing player latency data.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Required parameters <c>Name</c> and <c>Destinations</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PlayerLatencyPolicies</c> 
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        ///  <b>Results</b> 
        /// </para>
        ///  
        /// <para>
        /// If successful, this operation returns a new <c>GameSessionQueue</c> object with an
        /// assigned queue ARN. Use the queue's name or ARN when submitting new game session requests
        /// with <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_StartGameSessionPlacement.html">StartGameSessionPlacement</a>
        /// or <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_StartMatchmaking.html">StartMatchmaking</a>.
        /// 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameSessionQueueResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGameSessionQueueResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateLocation

        internal virtual CreateLocationResponse CreateLocation(CreateLocationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationResponseUnmarshaller.Instance;

            return Invoke<CreateLocationResponse>(request, options);
        }



        /// <summary>
        /// Creates a custom location for use in an Anywhere fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocation service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateLocation">REST API Reference for CreateLocation Operation</seealso>
        public virtual Task<CreateLocationResponse> CreateLocationAsync(CreateLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateMatchmakingConfiguration

        internal virtual CreateMatchmakingConfigurationResponse CreateMatchmakingConfiguration(CreateMatchmakingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchmakingConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateMatchmakingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Defines a new matchmaking configuration for use with FlexMatch. Whether your are using
        /// FlexMatch with Amazon GameLift Servers hosting or as a standalone matchmaking service,
        /// the matchmaking configuration sets out rules for matching players and forming teams.
        /// If you're also using Amazon GameLift Servers hosting, it defines how to start game
        /// sessions for each match. Your matchmaking system can use multiple configurations to
        /// handle different game scenarios. All matchmaking requests identify the matchmaking
        /// configuration to use and provide player attributes consistent with that configuration.
        /// 
        /// 
        ///  
        /// <para>
        /// To create a matchmaking configuration, you must provide the following: configuration
        /// name and FlexMatch mode (with or without Amazon GameLift Servers hosting); a rule
        /// set that specifies how to evaluate players and find acceptable matches; whether player
        /// acceptance is required; and the maximum time allowed for a matchmaking attempt. When
        /// using FlexMatch with Amazon GameLift Servers hosting, you also need to identify the
        /// game session queue to use when starting a game session for the match.
        /// </para>
        ///  
        /// <para>
        /// In addition, you must set up an Amazon Simple Notification Service topic to receive
        /// matchmaking notifications. Provide the topic ARN in the matchmaking configuration.
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchmakingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMatchmakingConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateMatchmakingRuleSet

        internal virtual CreateMatchmakingRuleSetResponse CreateMatchmakingRuleSet(CreateMatchmakingRuleSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchmakingRuleSetResponseUnmarshaller.Instance;

            return Invoke<CreateMatchmakingRuleSetResponse>(request, options);
        }



        /// <summary>
        /// Creates a new rule set for FlexMatch matchmaking. A rule set describes the type of
        /// match to create, such as the number and size of teams. It also sets the parameters
        /// for acceptable player matches, such as minimum skill level or character type.
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
        /// set syntax using <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ValidateMatchmakingRuleSet.html">ValidateMatchmakingRuleSet</a>
        /// before creating a new rule set.
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
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchmakingRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMatchmakingRuleSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePlayerSession

        internal virtual CreatePlayerSessionResponse CreatePlayerSession(CreatePlayerSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePlayerSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlayerSessionResponseUnmarshaller.Instance;

            return Invoke<CreatePlayerSessionResponse>(request, options);
        }


        /// <summary>
        /// Reserves an open player slot in a game session for a player. New player sessions can
        /// be created in any game session with an open slot that is in <c>ACTIVE</c> status and
        /// has a player creation policy of <c>ACCEPT_ALL</c>. You can add a group of players
        /// to a game session with <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreatePlayerSessions.html">CreatePlayerSessions</a>
        /// . 
        /// 
        ///  
        /// <para>
        /// To create a player session, specify a game session ID, player ID, and optionally a
        /// set of player data. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a slot is reserved in the game session for the player and a new <c>PlayerSessions</c>
        /// object is returned with a player session ID. The player references the player session
        /// ID when sending a connection request to the game session, and the game server can
        /// use it to validate the player reservation with the Amazon GameLift Servers service.
        /// Player sessions cannot be updated. 
        /// </para>
        ///  
        /// <para>
        /// The maximum number of players per game session is 200. It is not adjustable. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <c>RoutingStrategy</c> associated with it. The message returned in this
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
        /// be created in any game session with an open slot that is in <c>ACTIVE</c> status and
        /// has a player creation policy of <c>ACCEPT_ALL</c>. You can add a group of players
        /// to a game session with <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreatePlayerSessions.html">CreatePlayerSessions</a>
        /// . 
        /// 
        ///  
        /// <para>
        /// To create a player session, specify a game session ID, player ID, and optionally a
        /// set of player data. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a slot is reserved in the game session for the player and a new <c>PlayerSessions</c>
        /// object is returned with a player session ID. The player references the player session
        /// ID when sending a connection request to the game session, and the game server can
        /// use it to validate the player reservation with the Amazon GameLift Servers service.
        /// Player sessions cannot be updated. 
        /// </para>
        ///  
        /// <para>
        /// The maximum number of players per game session is 200. It is not adjustable. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <c>RoutingStrategy</c> associated with it. The message returned in this
        /// exception is the message defined in the routing strategy itself. Such requests should
        /// only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSession">REST API Reference for CreatePlayerSession Operation</seealso>
        public virtual Task<CreatePlayerSessionResponse> CreatePlayerSessionAsync(CreatePlayerSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePlayerSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlayerSessionResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePlayerSessionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePlayerSessions

        internal virtual CreatePlayerSessionsResponse CreatePlayerSessions(CreatePlayerSessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePlayerSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlayerSessionsResponseUnmarshaller.Instance;

            return Invoke<CreatePlayerSessionsResponse>(request, options);
        }


        /// <summary>
        /// Reserves open slots in a game session for a group of players. New player sessions
        /// can be created in any game session with an open slot that is in <c>ACTIVE</c> status
        /// and has a player creation policy of <c>ACCEPT_ALL</c>. To add a single player to a
        /// game session, use <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreatePlayerSession.html">CreatePlayerSession</a>
        /// 
        /// 
        ///  
        /// <para>
        /// To create player sessions, specify a game session ID and a list of player IDs. Optionally,
        /// provide a set of player data for each player ID. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a slot is reserved in the game session for each player, and new <c>PlayerSession</c>
        /// objects are returned with player session IDs. Each player references their player
        /// session ID when sending a connection request to the game session, and the game server
        /// can use it to validate the player reservation with the Amazon GameLift Servers service.
        /// Player sessions cannot be updated.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of players per game session is 200. It is not adjustable. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <c>RoutingStrategy</c> associated with it. The message returned in this
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
        /// can be created in any game session with an open slot that is in <c>ACTIVE</c> status
        /// and has a player creation policy of <c>ACCEPT_ALL</c>. To add a single player to a
        /// game session, use <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreatePlayerSession.html">CreatePlayerSession</a>
        /// 
        /// 
        ///  
        /// <para>
        /// To create player sessions, specify a game session ID and a list of player IDs. Optionally,
        /// provide a set of player data for each player ID. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a slot is reserved in the game session for each player, and new <c>PlayerSession</c>
        /// objects are returned with player session IDs. Each player references their player
        /// session ID when sending a connection request to the game session, and the game server
        /// can use it to validate the player reservation with the Amazon GameLift Servers service.
        /// Player sessions cannot be updated.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of players per game session is 200. It is not adjustable. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <c>RoutingStrategy</c> associated with it. The message returned in this
        /// exception is the message defined in the routing strategy itself. Such requests should
        /// only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSessions">REST API Reference for CreatePlayerSessions Operation</seealso>
        public virtual Task<CreatePlayerSessionsResponse> CreatePlayerSessionsAsync(CreatePlayerSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePlayerSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlayerSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePlayerSessionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateScript

        internal virtual CreateScriptResponse CreateScript(CreateScriptRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScriptResponseUnmarshaller.Instance;

            return Invoke<CreateScriptResponse>(request, options);
        }



        /// <summary>
        /// Creates a new script record for your Amazon GameLift Servers Realtime script. Realtime
        /// scripts are JavaScript that provide configuration settings and optional custom game
        /// logic for your game. The script is deployed when you create a Amazon GameLift Servers
        /// Realtime fleet to host your game sessions. Script logic is executed during an active
        /// game session. 
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
        /// have an Identity Access Management (IAM) role that allows the Amazon GameLift Servers
        /// service to access your S3 bucket. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the call is successful, a new script record is created with a unique script ID.
        /// If the script file is provided as a local file, the file is uploaded to an Amazon
        /// GameLift Servers-owned S3 bucket and the script record's storage location reflects
        /// this location. If the script file is provided as an S3 bucket, Amazon GameLift Servers
        /// accesses the file at this storage location as needed for deployment.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
        /// GameLift Servers Amazon GameLift Servers Realtime</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/setting-up-role.html">Set
        /// Up a Role for Amazon GameLift Servers Access</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScriptResponseUnmarshaller.Instance;

            return InvokeAsync<CreateScriptResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateVpcPeeringAuthorization

        internal virtual CreateVpcPeeringAuthorizationResponse CreateVpcPeeringAuthorization(CreateVpcPeeringAuthorizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcPeeringAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcPeeringAuthorizationResponseUnmarshaller.Instance;

            return Invoke<CreateVpcPeeringAuthorizationResponse>(request, options);
        }



        /// <summary>
        /// Requests authorization to create or delete a peer connection between the VPC for your
        /// Amazon GameLift Servers fleet and a virtual private cloud (VPC) in your Amazon Web
        /// Services account. VPC peering enables the game servers on your fleet to communicate
        /// directly with other Amazon Web Services resources. After you've received authorization,
        /// use <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateVpcPeeringConnection.html">CreateVpcPeeringConnection</a>
        /// to establish the peering connection. For more information, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
        /// Peering with Amazon GameLift Servers Fleets</a>.
        /// 
        ///  
        /// <para>
        /// You can peer with VPCs that are owned by any Amazon Web Services account you have
        /// access to, including the account that you use to manage your Amazon GameLift Servers
        /// fleets. You cannot peer with VPCs that are in different Regions.
        /// </para>
        ///  
        /// <para>
        /// To request authorization to create a connection, call this operation from the Amazon
        /// Web Services account with the VPC that you want to peer to your Amazon GameLift Servers
        /// fleet. For example, to enable your game servers to retrieve data from a DynamoDB table,
        /// use the account that manages that DynamoDB resource. Identify the following values:
        /// (1) The ID of the VPC that you want to peer with, and (2) the ID of the Amazon Web
        /// Services account that you use to manage Amazon GameLift Servers. If successful, VPC
        /// peering is authorized for the specified VPC. 
        /// </para>
        ///  
        /// <para>
        /// To request authorization to delete a connection, call this operation from the Amazon
        /// Web Services account with the VPC that is peered with your Amazon GameLift Servers
        /// fleet. Identify the following values: (1) VPC ID that you want to delete the peering
        /// connection for, and (2) ID of the Amazon Web Services account that you use to manage
        /// Amazon GameLift Servers. 
        /// </para>
        ///  
        /// <para>
        /// The authorization remains valid for 24 hours unless it is canceled. You must create
        /// or delete the peering connection while the authorization is valid. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateVpcPeeringAuthorization">REST API Reference for CreateVpcPeeringAuthorization Operation</seealso>
        public virtual Task<CreateVpcPeeringAuthorizationResponse> CreateVpcPeeringAuthorizationAsync(CreateVpcPeeringAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcPeeringAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcPeeringAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcPeeringAuthorizationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateVpcPeeringConnection

        internal virtual CreateVpcPeeringConnectionResponse CreateVpcPeeringConnection(CreateVpcPeeringConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateVpcPeeringConnectionResponse>(request, options);
        }



        /// <summary>
        /// Establishes a VPC peering connection between a virtual private cloud (VPC) in an Amazon
        /// Web Services account with the VPC for your Amazon GameLift Servers fleet. VPC peering
        /// enables the game servers on your fleet to communicate directly with other Amazon Web
        /// Services resources. You can peer with VPCs in any Amazon Web Services account that
        /// you have access to, including the account that you use to manage your Amazon GameLift
        /// Servers fleets. You cannot peer with VPCs that are in different Regions. For more
        /// information, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
        /// Peering with Amazon GameLift Servers Fleets</a>.
        /// 
        ///  
        /// <para>
        /// Before calling this operation to establish the peering connection, you first need
        /// to use <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateVpcPeeringAuthorization.html">CreateVpcPeeringAuthorization</a>
        /// and identify the VPC you want to peer with. Once the authorization for the specified
        /// VPC is issued, you have 24 hours to establish the connection. These two operations
        /// handle all tasks necessary to peer the two VPCs, including acceptance, updating routing
        /// tables, etc. 
        /// </para>
        ///  
        /// <para>
        /// To establish the connection, call this operation from the Amazon Web Services account
        /// that is used to manage the Amazon GameLift Servers fleets. Identify the following
        /// values: (1) The ID of the fleet you want to be enable a VPC peering connection for;
        /// (2) The Amazon Web Services account with the VPC that you want to peer with; and (3)
        /// The ID of the VPC you want to peer with. This operation is asynchronous. If successful,
        /// a connection request is created. You can use continuous polling to track the request's
        /// status using <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeVpcPeeringConnections.html">DescribeVpcPeeringConnections</a>
        /// , or by monitoring fleet events for success or failure using <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetEvents.html">DescribeFleetEvents</a>
        /// . 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateVpcPeeringConnection">REST API Reference for CreateVpcPeeringConnection Operation</seealso>
        public virtual Task<CreateVpcPeeringConnectionResponse> CreateVpcPeeringConnectionAsync(CreateVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcPeeringConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAlias

        internal virtual DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteBuild

        internal virtual DeleteBuildResponse DeleteBuild(DeleteBuildRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBuildResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBuildResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteContainerFleet

        internal virtual DeleteContainerFleetResponse DeleteContainerFleet(DeleteContainerFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContainerFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContainerFleetResponseUnmarshaller.Instance;

            return Invoke<DeleteContainerFleetResponse>(request, options);
        }



        /// <summary>
        /// Deletes all resources and information related to a container fleet and shuts down
        /// currently running fleet instances, including those in remote locations. The container
        /// fleet must be in <c>ACTIVE</c> status to be deleted.
        /// 
        ///  
        /// <para>
        /// To delete a fleet, specify the fleet ID to be terminated. During the deletion process,
        /// the fleet status is changed to <c>DELETING</c>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up Amazon GameLift Servers Fleets</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainerFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteContainerFleet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteContainerFleet">REST API Reference for DeleteContainerFleet Operation</seealso>
        public virtual Task<DeleteContainerFleetResponse> DeleteContainerFleetAsync(DeleteContainerFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContainerFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContainerFleetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteContainerFleetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteContainerGroupDefinition

        internal virtual DeleteContainerGroupDefinitionResponse DeleteContainerGroupDefinition(DeleteContainerGroupDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContainerGroupDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContainerGroupDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteContainerGroupDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a container group definition. 
        /// 
        ///  
        /// <para>
        ///  <b>Request options:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Delete an entire container group definition, including all versions. Specify the container
        /// group definition name, or use an ARN value without the version number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete a particular version. Specify the container group definition name and a version
        /// number, or use an ARN value that includes the version number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Keep the newest versions and delete all older versions. Specify the container group
        /// definition name and the number of versions to retain. For example, set <c>VersionCountToRetain</c>
        /// to 5 to delete all but the five most recent versions.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Result</b> 
        /// </para>
        ///  
        /// <para>
        /// If successful, Amazon GameLift Servers removes the container group definition versions
        /// that you request deletion for. This request will fail for any requested versions if
        /// the following is true: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the version is being used in an active fleet
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the version is being deployed to a fleet in a deployment that's currently in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the version is designated as a rollback definition in a fleet deployment that's
        /// currently in progress.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/containers-create-groups.html">Manage
        /// a container group definition</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainerGroupDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteContainerGroupDefinition service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteContainerGroupDefinition">REST API Reference for DeleteContainerGroupDefinition Operation</seealso>
        public virtual Task<DeleteContainerGroupDefinitionResponse> DeleteContainerGroupDefinitionAsync(DeleteContainerGroupDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteContainerGroupDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContainerGroupDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteContainerGroupDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFleet

        internal virtual DeleteFleetResponse DeleteFleet(DeleteFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetResponse>(request, options);
        }


        /// <summary>
        /// Deletes all resources and information related to a fleet and shuts down any currently
        /// running fleet instances, including those in remote locations.
        /// 
        ///  <note> 
        /// <para>
        /// If the fleet being deleted has a VPC peering connection, you first need to get a valid
        /// authorization (good for 24 hours) by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateVpcPeeringAuthorization.html">CreateVpcPeeringAuthorization</a>.
        /// You don't need to explicitly delete the VPC peering connection.
        /// </para>
        ///  </note> 
        /// <para>
        /// To delete a fleet, specify the fleet ID to be terminated. During the deletion process,
        /// the fleet status is changed to <c>DELETING</c>. When completed, the status switches
        /// to <c>TERMINATED</c> and the fleet event <c>FLEET_DELETED</c> is emitted.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up Amazon GameLift Servers Fleets</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
        /// Deletes all resources and information related to a fleet and shuts down any currently
        /// running fleet instances, including those in remote locations.
        /// 
        ///  <note> 
        /// <para>
        /// If the fleet being deleted has a VPC peering connection, you first need to get a valid
        /// authorization (good for 24 hours) by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateVpcPeeringAuthorization.html">CreateVpcPeeringAuthorization</a>.
        /// You don't need to explicitly delete the VPC peering connection.
        /// </para>
        ///  </note> 
        /// <para>
        /// To delete a fleet, specify the fleet ID to be terminated. During the deletion process,
        /// the fleet status is changed to <c>DELETING</c>. When completed, the status switches
        /// to <c>TERMINATED</c> and the fleet event <c>FLEET_DELETED</c> is emitted.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up Amazon GameLift Servers Fleets</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFleetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFleetLocations

        internal virtual DeleteFleetLocationsResponse DeleteFleetLocations(DeleteFleetLocationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// If successful, GameLift sets the location status to <c>DELETING</c>, and begins to
        /// shut down existing server processes and terminate instances in each location being
        /// deleted. When completed, the location status changes to <c>TERMINATED</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up Amazon GameLift Servers fleets</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFleetLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetLocationsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFleetLocationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteGameServerGroup

        internal virtual DeleteGameServerGroupResponse DeleteGameServerGroup(DeleteGameServerGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGameServerGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGameServerGroupResponse>(request, options);
        }



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift Servers FleetIQ solution and game
        /// server groups.</b> 
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
        /// they are in <c>ACTIVE</c> or <c>ERROR</c> status.
        /// </para>
        ///  
        /// <para>
        /// If the delete request is successful, a series of operations are kicked off. The game
        /// server group status is changed to <c>DELETE_SCHEDULED</c>, which prevents new game
        /// servers from being registered and stops automatic scaling activity. Once all game
        /// servers in the game server group are deregistered, Amazon GameLift Servers FleetIQ
        /// can begin deleting resources. If any of the delete operations fail, the game server
        /// group is placed in <c>ERROR</c> status.
        /// </para>
        ///  
        /// <para>
        /// Amazon GameLift Servers FleetIQ emits delete events to Amazon CloudWatch.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">Amazon
        /// GameLift Servers FleetIQ Guide</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteGameServerGroup">REST API Reference for DeleteGameServerGroup Operation</seealso>
        public virtual Task<DeleteGameServerGroupResponse> DeleteGameServerGroupAsync(DeleteGameServerGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGameServerGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGameServerGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteGameSessionQueue

        internal virtual DeleteGameSessionQueueResponse DeleteGameSessionQueue(DeleteGameSessionQueueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGameSessionQueueResponseUnmarshaller.Instance;

            return Invoke<DeleteGameSessionQueueResponse>(request, options);
        }



        /// <summary>
        /// Deletes a game session queue. Once a queue is successfully deleted, unfulfilled <a
        /// href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_StartGameSessionPlacement.html">StartGameSessionPlacement</a>
        /// requests that reference the queue will fail. To delete a queue, specify the queue
        /// name.
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGameSessionQueueResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGameSessionQueueResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteLocation

        internal virtual DeleteLocationResponse DeleteLocation(DeleteLocationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLocationResponseUnmarshaller.Instance;

            return Invoke<DeleteLocationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a custom location.
        /// 
        ///  
        /// <para>
        /// Before deleting a custom location, review any fleets currently using the custom location
        /// and deregister the location if it is in use. For more information, see <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DeregisterCompute.html">DeregisterCompute</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLocation service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteLocation">REST API Reference for DeleteLocation Operation</seealso>
        public virtual Task<DeleteLocationResponse> DeleteLocationAsync(DeleteLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLocationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLocationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteMatchmakingConfiguration

        internal virtual DeleteMatchmakingConfigurationResponse DeleteMatchmakingConfiguration(DeleteMatchmakingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMatchmakingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteMatchmakingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Permanently removes a FlexMatch matchmaking configuration. To delete, specify the
        /// configuration name. A matchmaking configuration cannot be deleted if it is being used
        /// in any active matchmaking tickets.
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMatchmakingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMatchmakingConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteMatchmakingRuleSet

        internal virtual DeleteMatchmakingRuleSetResponse DeleteMatchmakingRuleSet(DeleteMatchmakingRuleSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMatchmakingRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMatchmakingRuleSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteScalingPolicy

        internal virtual DeleteScalingPolicyResponse DeleteScalingPolicy(DeleteScalingPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteScalingPolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes a fleet scaling policy. Once deleted, the policy is no longer in force and
        /// Amazon GameLift Servers removes all record of it. To delete a scaling policy, specify
        /// both the scaling policy name and the fleet ID it is associated with.
        /// 
        ///  
        /// <para>
        /// To temporarily suspend scaling policies, use <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_StopFleetActions.html">StopFleetActions</a>.
        /// This operation suspends all policies for the fleet.
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteScalingPolicy">REST API Reference for DeleteScalingPolicy Operation</seealso>
        public virtual Task<DeleteScalingPolicyResponse> DeleteScalingPolicyAsync(DeleteScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScalingPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteScript

        internal virtual DeleteScriptResponse DeleteScript(DeleteScriptRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// GameLift Servers Amazon GameLift Servers Realtime</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScriptResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScriptResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteVpcPeeringAuthorization

        internal virtual DeleteVpcPeeringAuthorizationResponse DeleteVpcPeeringAuthorization(DeleteVpcPeeringAuthorizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcPeeringAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcPeeringAuthorizationResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcPeeringAuthorizationResponse>(request, options);
        }



        /// <summary>
        /// Cancels a pending VPC peering authorization for the specified VPC. If you need to
        /// delete an existing VPC peering connection, use <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DeleteVpcPeeringConnection.html">DeleteVpcPeeringConnection</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteVpcPeeringAuthorization">REST API Reference for DeleteVpcPeeringAuthorization Operation</seealso>
        public virtual Task<DeleteVpcPeeringAuthorizationResponse> DeleteVpcPeeringAuthorizationAsync(DeleteVpcPeeringAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcPeeringAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcPeeringAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcPeeringAuthorizationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteVpcPeeringConnection

        internal virtual DeleteVpcPeeringConnectionResponse DeleteVpcPeeringConnection(DeleteVpcPeeringConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcPeeringConnectionResponse>(request, options);
        }



        /// <summary>
        /// Removes a VPC peering connection. To delete the connection, you must have a valid
        /// authorization for the VPC peering connection that you want to delete.. 
        /// 
        ///  
        /// <para>
        /// Once a valid authorization exists, call this operation from the Amazon Web Services
        /// account that is used to manage the Amazon GameLift Servers fleets. Identify the connection
        /// to delete by the connection ID and fleet ID. If successful, the connection is removed.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteVpcPeeringConnection">REST API Reference for DeleteVpcPeeringConnection Operation</seealso>
        public virtual Task<DeleteVpcPeeringConnectionResponse> DeleteVpcPeeringConnectionAsync(DeleteVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcPeeringConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeregisterCompute

        internal virtual DeregisterComputeResponse DeregisterCompute(DeregisterComputeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterComputeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterComputeResponseUnmarshaller.Instance;

            return Invoke<DeregisterComputeResponse>(request, options);
        }



        /// <summary>
        /// Removes a compute resource from an Anywhere fleet. Deregistered computes can no longer
        /// host game sessions through Amazon GameLift Servers. Use this operation with an Anywhere
        /// fleet that doesn't use the Amazon GameLift Servers Agent For Anywhere fleets with
        /// the Agent, the Agent handles all compute registry tasks for you. 
        /// 
        ///  
        /// <para>
        /// To deregister a compute, call this operation from the compute that's being deregistered
        /// and specify the compute name and the fleet ID. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterCompute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterCompute service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeregisterCompute">REST API Reference for DeregisterCompute Operation</seealso>
        public virtual Task<DeregisterComputeResponse> DeregisterComputeAsync(DeregisterComputeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterComputeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterComputeResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterComputeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeregisterGameServer

        internal virtual DeregisterGameServerResponse DeregisterGameServer(DeregisterGameServerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterGameServerResponseUnmarshaller.Instance;

            return Invoke<DeregisterGameServerResponse>(request, options);
        }



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift Servers FleetIQ solution and game
        /// server groups.</b> 
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">Amazon
        /// GameLift Servers FleetIQ Guide</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeregisterGameServer">REST API Reference for DeregisterGameServer Operation</seealso>
        public virtual Task<DeregisterGameServerResponse> DeregisterGameServerAsync(DeregisterGameServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterGameServerResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterGameServerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAlias

        internal virtual DescribeAliasResponse DescribeAlias(DescribeAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAliasResponseUnmarshaller.Instance;

            return Invoke<DescribeAliasResponse>(request, options);
        }


        /// <summary>
        /// Retrieves properties for an alias. This operation returns all alias metadata and settings.
        /// To get an alias's target fleet ID only, use <c>ResolveAlias</c>. 
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
        /// To get an alias's target fleet ID only, use <c>ResolveAlias</c>. 
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeAlias">REST API Reference for DescribeAlias Operation</seealso>
        public virtual Task<DescribeAliasResponse> DescribeAliasAsync(DescribeAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeBuild

        internal virtual DescribeBuildResponse DescribeBuild(DescribeBuildRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeBuild">REST API Reference for DescribeBuild Operation</seealso>
        public virtual Task<DescribeBuildResponse> DescribeBuildAsync(DescribeBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBuildResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBuildResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeCompute

        internal virtual DescribeComputeResponse DescribeCompute(DescribeComputeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeComputeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComputeResponseUnmarshaller.Instance;

            return Invoke<DescribeComputeResponse>(request, options);
        }



        /// <summary>
        /// Retrieves properties for a specific compute resource in an Amazon GameLift Servers
        /// fleet. You can list all computes in a fleet by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ListCompute.html">ListCompute</a>.
        /// 
        /// 
        ///  
        /// <para>
        ///  <b>Request options</b> 
        /// </para>
        ///  
        /// <para>
        /// Provide the fleet ID and compute name. The compute name varies depending on the type
        /// of fleet.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a compute in a managed EC2 fleet, provide an instance ID. Each instance in the
        /// fleet is a compute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a compute in a managed container fleet, provide a compute name. In a container
        /// fleet, each game server container group on a fleet instance is assigned a compute
        /// name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a compute in an Anywhere fleet, provide a registered compute name. Anywhere fleet
        /// computes are created when you register a hosting resource with the fleet.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Results</b> 
        /// </para>
        ///  
        /// <para>
        /// If successful, this operation returns details for the requested compute resource.
        /// Depending on the fleet's compute type, the result includes the following information:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a managed EC2 fleet, this operation returns information about the EC2 instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an Anywhere fleet, this operation returns information about the registered compute.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCompute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCompute service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeCompute">REST API Reference for DescribeCompute Operation</seealso>
        public virtual Task<DescribeComputeResponse> DescribeComputeAsync(DescribeComputeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeComputeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComputeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeComputeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeContainerFleet

        internal virtual DescribeContainerFleetResponse DescribeContainerFleet(DescribeContainerFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeContainerFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContainerFleetResponseUnmarshaller.Instance;

            return Invoke<DescribeContainerFleetResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the properties for a container fleet. When requesting attributes for multiple
        /// fleets, use the pagination parameters to retrieve results as a set of sequential pages.
        /// 
        /// 
        ///  
        /// <para>
        ///  <b>Request options</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Get container fleet properties for a single fleet. Provide either the fleet ID or
        /// ARN value. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Results</b> 
        /// </para>
        ///  
        /// <para>
        /// If successful, a <c>ContainerFleet</c> object is returned. This object includes the
        /// fleet properties, including information about the most recent deployment.
        /// </para>
        ///  <note> 
        /// <para>
        /// Some API operations limit the number of fleet IDs that allowed in one request. If
        /// a request exceeds this limit, the request fails and the error message contains the
        /// maximum allowed number.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContainerFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeContainerFleet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeContainerFleet">REST API Reference for DescribeContainerFleet Operation</seealso>
        public virtual Task<DescribeContainerFleetResponse> DescribeContainerFleetAsync(DescribeContainerFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeContainerFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContainerFleetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeContainerFleetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeContainerGroupDefinition

        internal virtual DescribeContainerGroupDefinitionResponse DescribeContainerGroupDefinition(DescribeContainerGroupDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeContainerGroupDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContainerGroupDefinitionResponseUnmarshaller.Instance;

            return Invoke<DescribeContainerGroupDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the properties of a container group definition, including all container
        /// definitions in the group. 
        /// 
        ///  
        /// <para>
        ///  <b>Request options:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Retrieve the latest version of a container group definition. Specify the container
        /// group definition name only, or use an ARN value without a version number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Retrieve a particular version. Specify the container group definition name and a version
        /// number, or use an ARN value that includes the version number.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Results:</b> 
        /// </para>
        ///  
        /// <para>
        /// If successful, this operation returns the complete properties of a container group
        /// definition version.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/containers-create-groups.html">Manage
        /// a container group definition</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContainerGroupDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeContainerGroupDefinition service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeContainerGroupDefinition">REST API Reference for DescribeContainerGroupDefinition Operation</seealso>
        public virtual Task<DescribeContainerGroupDefinitionResponse> DescribeContainerGroupDefinitionAsync(DescribeContainerGroupDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeContainerGroupDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContainerGroupDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeContainerGroupDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeEC2InstanceLimits

        internal virtual DescribeEC2InstanceLimitsResponse DescribeEC2InstanceLimits(DescribeEC2InstanceLimitsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// your ability to scale your Amazon GameLift Servers fleets. You can request a limit
        /// increase for your account by using the <b>Service limits</b> page in the Amazon GameLift
        /// Servers console.
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
        /// Request specifies the Region <c>ap-northeast-1</c> with no location. The result is
        /// limits and usage data on all instance types that are deployed in <c>us-east-2</c>,
        /// by all of the fleets that reside in <c>ap-northeast-1</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Request specifies the Region <c>us-east-1</c> with location <c>ca-central-1</c>. The
        /// result is limits and usage data on all instance types that are deployed in <c>ca-central-1</c>,
        /// by all of the fleets that reside in <c>us-east-2</c>. These limits do not affect fleets
        /// in any other Regions that deploy instances to <c>ca-central-1</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Request specifies the Region <c>eu-west-1</c> with location <c>ca-central-1</c>. The
        /// result is limits and usage data on all instance types that are deployed in <c>ca-central-1</c>,
        /// by all of the fleets that reside in <c>eu-west-1</c>.
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
        /// If successful, an <c>EC2InstanceLimits</c> object is returned with limits and usage
        /// data for each requested instance type.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up Amazon GameLift Servers fleets</a> 
        /// </para>
        /// </summary>
        /// <param name="ec2InstanceType">Name of an Amazon EC2 instance type that is supported in Amazon GameLift Servers. A fleet instance type determines the computing resources of each instance in the fleet, including CPU, memory, storage, and networking capacity. Do not specify a value for this parameter to retrieve limits for all instance types.</param>
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
        /// your ability to scale your Amazon GameLift Servers fleets. You can request a limit
        /// increase for your account by using the <b>Service limits</b> page in the Amazon GameLift
        /// Servers console.
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
        /// Request specifies the Region <c>ap-northeast-1</c> with no location. The result is
        /// limits and usage data on all instance types that are deployed in <c>us-east-2</c>,
        /// by all of the fleets that reside in <c>ap-northeast-1</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Request specifies the Region <c>us-east-1</c> with location <c>ca-central-1</c>. The
        /// result is limits and usage data on all instance types that are deployed in <c>ca-central-1</c>,
        /// by all of the fleets that reside in <c>us-east-2</c>. These limits do not affect fleets
        /// in any other Regions that deploy instances to <c>ca-central-1</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Request specifies the Region <c>eu-west-1</c> with location <c>ca-central-1</c>. The
        /// result is limits and usage data on all instance types that are deployed in <c>ca-central-1</c>,
        /// by all of the fleets that reside in <c>eu-west-1</c>.
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
        /// If successful, an <c>EC2InstanceLimits</c> object is returned with limits and usage
        /// data for each requested instance type.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up Amazon GameLift Servers fleets</a> 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEC2InstanceLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEC2InstanceLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEC2InstanceLimitsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFleetAttributes

        internal virtual DescribeFleetAttributesResponse DescribeFleetAttributes(DescribeFleetAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetAttributesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves core fleet-wide properties for fleets in an Amazon Web Services Region.
        /// Properties include the computing hardware and deployment configuration for instances
        /// in the fleet.
        /// 
        ///  
        /// <para>
        /// You can use this operation in the following ways: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To get attributes for specific fleets, provide a list of fleet IDs or fleet ARNs.
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
        /// If successful, a <c>FleetAttributes</c> object is returned for each fleet requested,
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
        /// up Amazon GameLift Servers fleets</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetAttributes">REST API Reference for DescribeFleetAttributes Operation</seealso>
        public virtual Task<DescribeFleetAttributesResponse> DescribeFleetAttributesAsync(DescribeFleetAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFleetCapacity

        internal virtual DescribeFleetCapacityResponse DescribeFleetCapacity(DescribeFleetCapacityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetCapacityResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetCapacityResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the resource capacity settings for one or more fleets. For a container fleet,
        /// this operation also returns counts for game server container groups.
        /// 
        ///  
        /// <para>
        /// With multi-location fleets, this operation retrieves data for the fleet's home Region
        /// only. To retrieve capacity for remote locations, see <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetLocationCapacity.html">https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetLocationCapacity.html</a>.
        /// </para>
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
        /// If successful, a <c>FleetCapacity</c> object is returned for each requested fleet
        /// ID. Each <c>FleetCapacity</c> object includes a <c>Location</c> property, which is
        /// set to the fleet's home Region. Capacity values are returned only for fleets that
        /// currently exist.
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
        /// up Amazon GameLift Servers fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/monitoring-cloudwatch.html#gamelift-metrics-fleet">GameLift
        /// metrics for fleets</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetCapacity">REST API Reference for DescribeFleetCapacity Operation</seealso>
        public virtual Task<DescribeFleetCapacityResponse> DescribeFleetCapacityAsync(DescribeFleetCapacityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetCapacityResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetCapacityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFleetDeployment

        internal virtual DescribeFleetDeploymentResponse DescribeFleetDeployment(DescribeFleetDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetDeploymentResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetDeploymentResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a managed container fleet deployment. 
        /// 
        ///  
        /// <para>
        ///  <b>Request options</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Get information about the latest deployment for a specific fleet. Provide the fleet
        /// ID or ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Get information about a specific deployment. Provide the fleet ID or ARN and the
        /// deployment ID.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Results</b> 
        /// </para>
        ///  
        /// <para>
        /// If successful, a <c>FleetDeployment</c> object is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleetDeployment service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetDeployment">REST API Reference for DescribeFleetDeployment Operation</seealso>
        public virtual Task<DescribeFleetDeploymentResponse> DescribeFleetDeploymentAsync(DescribeFleetDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetDeploymentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFleetEvents

        internal virtual DescribeFleetEventsResponse DescribeFleetEvents(DescribeFleetEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// up Amazon GameLift Servers fleets</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetEvents">REST API Reference for DescribeFleetEvents Operation</seealso>
        public virtual Task<DescribeFleetEventsResponse> DescribeFleetEventsAsync(DescribeFleetEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetEventsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFleetLocationAttributes

        internal virtual DescribeFleetLocationAttributesResponse DescribeFleetLocationAttributes(DescribeFleetLocationAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// If successful, a <c>LocationAttributes</c> object is returned for each requested location.
        /// If the fleet does not have a requested location, no information is returned. This
        /// operation does not return the home Region. To get information on a fleet's home Region,
        /// call <c>DescribeFleetAttributes</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up Amazon GameLift Servers fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-regions.html">
        /// Amazon GameLift Servers service locations</a> for managed hosting
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetLocationAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetLocationAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetLocationAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFleetLocationCapacity

        internal virtual DescribeFleetLocationCapacityResponse DescribeFleetLocationCapacity(DescribeFleetLocationCapacityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetLocationCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetLocationCapacityResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetLocationCapacityResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the resource capacity settings for a fleet location. The data returned includes
        /// the current capacity (number of EC2 instances) and some scaling settings for the requested
        /// fleet location. For a managed container fleet, this operation also returns counts
        /// for game server container groups.
        /// 
        ///  
        /// <para>
        /// Use this operation to retrieve capacity information for a fleet's remote location
        /// or home Region (you can also retrieve home Region capacity by calling <c>DescribeFleetCapacity</c>).
        /// </para>
        ///  
        /// <para>
        /// To retrieve capacity data, identify a fleet and location. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a <c>FleetCapacity</c> object is returned for the requested fleet location.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up Amazon GameLift Servers fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-regions.html">
        /// Amazon GameLift Servers service locations</a> for managed hosting
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/monitoring-cloudwatch.html#gamelift-metrics-fleet">GameLift
        /// metrics for fleets</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetLocationCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetLocationCapacityResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetLocationCapacityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFleetLocationUtilization

        internal virtual DescribeFleetLocationUtilizationResponse DescribeFleetLocationUtilization(DescribeFleetLocationUtilizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetLocationUtilizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetLocationUtilizationResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetLocationUtilizationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves current usage data for a fleet location. Utilization data provides a snapshot
        /// of current game hosting activity at the requested location. Use this operation to
        /// retrieve utilization information for a fleet's remote location or home Region (you
        /// can also retrieve home Region utilization by calling <c>DescribeFleetUtilization</c>).
        /// 
        ///  
        /// <para>
        /// To retrieve utilization data, identify a fleet and location. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a <c>FleetUtilization</c> object is returned for the requested fleet
        /// location. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up Amazon GameLift Servers fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-regions.html">
        /// Amazon GameLift Servers service locations</a> for managed hosting
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/monitoring-cloudwatch.html#gamelift-metrics-fleet">GameLift
        /// metrics for fleets</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetLocationUtilizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetLocationUtilizationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetLocationUtilizationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFleetPortSettings

        internal virtual DescribeFleetPortSettingsResponse DescribeFleetPortSettings(DescribeFleetPortSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetPortSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetPortSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetPortSettingsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a fleet's inbound connection permissions. Connection permissions specify
        /// IP addresses and port settings that incoming traffic can use to access server processes
        /// in the fleet. Game server processes that are running in the fleet must use a port
        /// that falls within this range. 
        /// 
        ///  
        /// <para>
        /// Use this operation in the following ways: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To retrieve the port settings for a fleet, identify the fleet's unique identifier.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To check the status of recent updates to a fleet remote location, specify the fleet
        /// ID and a location. Port setting updates can take time to propagate across all locations.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If successful, a set of <c>IpPermission</c> objects is returned for the requested
        /// fleet ID. When specifying a location, this operation returns a pending status. If
        /// the requested fleet has been deleted, the result set is empty.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up Amazon GameLift Servers fleets</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
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
        /// IP addresses and port settings that incoming traffic can use to access server processes
        /// in the fleet. Game server processes that are running in the fleet must use a port
        /// that falls within this range. 
        /// 
        ///  
        /// <para>
        /// Use this operation in the following ways: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To retrieve the port settings for a fleet, identify the fleet's unique identifier.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To check the status of recent updates to a fleet remote location, specify the fleet
        /// ID and a location. Port setting updates can take time to propagate across all locations.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If successful, a set of <c>IpPermission</c> objects is returned for the requested
        /// fleet ID. When specifying a location, this operation returns a pending status. If
        /// the requested fleet has been deleted, the result set is empty.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up Amazon GameLift Servers fleets</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetPortSettings">REST API Reference for DescribeFleetPortSettings Operation</seealso>
        public virtual Task<DescribeFleetPortSettingsResponse> DescribeFleetPortSettingsAsync(DescribeFleetPortSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetPortSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetPortSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetPortSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFleetUtilization

        internal virtual DescribeFleetUtilizationResponse DescribeFleetUtilization(DescribeFleetUtilizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetUtilizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetUtilizationResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetUtilizationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves utilization statistics for one or more fleets. Utilization data provides
        /// a snapshot of how the fleet's hosting resources are currently being used. For fleets
        /// with remote locations, this operation retrieves data for the fleet's home Region only.
        /// See <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetLocationUtilization.html">DescribeFleetLocationUtilization</a>
        /// to get utilization statistics for a fleet's remote locations.
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
        /// If successful, a <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_FleetUtilization.html">FleetUtilization</a>
        /// object is returned for each requested fleet ID, unless the fleet identifier is not
        /// found. Each fleet utilization object includes a <c>Location</c> property, which is
        /// set to the fleet's home Region. 
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
        /// up Amazon GameLift Servers Fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/monitoring-cloudwatch.html#gamelift-metrics-fleet">GameLift
        /// Metrics for Fleets</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetUtilization">REST API Reference for DescribeFleetUtilization Operation</seealso>
        public virtual Task<DescribeFleetUtilizationResponse> DescribeFleetUtilizationAsync(DescribeFleetUtilizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetUtilizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetUtilizationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetUtilizationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeGameServer

        internal virtual DescribeGameServerResponse DescribeGameServer(DescribeGameServerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameServerResponseUnmarshaller.Instance;

            return Invoke<DescribeGameServerResponse>(request, options);
        }



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift Servers FleetIQ solution and game
        /// server groups.</b> 
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">Amazon
        /// GameLift Servers FleetIQ Guide</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameServer">REST API Reference for DescribeGameServer Operation</seealso>
        public virtual Task<DescribeGameServerResponse> DescribeGameServerAsync(DescribeGameServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameServerResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameServerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeGameServerGroup

        internal virtual DescribeGameServerGroupResponse DescribeGameServerGroup(DescribeGameServerGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameServerGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeGameServerGroupResponse>(request, options);
        }



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift Servers FleetIQ solution and game
        /// server groups.</b> 
        /// 
        ///  
        /// <para>
        /// Retrieves information on a game server group. This operation returns only properties
        /// related to Amazon GameLift Servers FleetIQ. To view or update properties for the corresponding
        /// Auto Scaling group, such as launch template, auto scaling policies, and maximum/minimum
        /// group size, access the Auto Scaling group directly.
        /// </para>
        ///  
        /// <para>
        /// To get attributes for a game server group, provide a group name or ARN value. If successful,
        /// a <c>GameServerGroup</c> object is returned.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">Amazon
        /// GameLift Servers FleetIQ Guide</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameServerGroup">REST API Reference for DescribeGameServerGroup Operation</seealso>
        public virtual Task<DescribeGameServerGroupResponse> DescribeGameServerGroupAsync(DescribeGameServerGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameServerGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameServerGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeGameServerInstances

        internal virtual DescribeGameServerInstancesResponse DescribeGameServerInstances(DescribeGameServerInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGameServerInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameServerInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeGameServerInstancesResponse>(request, options);
        }



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift Servers FleetIQ solution and game
        /// server groups.</b> 
        /// 
        ///  
        /// <para>
        /// Retrieves status information about the Amazon EC2 instances associated with a Amazon
        /// GameLift Servers FleetIQ game server group. Use this operation to detect when instances
        /// are active or not available to host new game servers.
        /// </para>
        ///  
        /// <para>
        /// To request status for all instances in the game server group, provide a game server
        /// group ID only. To request status for specific instances, provide the game server group
        /// ID and one or more instance IDs. Use the pagination parameters to retrieve results
        /// in sequential segments. If successful, a collection of <c>GameServerInstance</c> objects
        /// is returned. 
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">Amazon
        /// GameLift Servers FleetIQ Guide</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameServerInstances">REST API Reference for DescribeGameServerInstances Operation</seealso>
        public virtual Task<DescribeGameServerInstancesResponse> DescribeGameServerInstancesAsync(DescribeGameServerInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGameServerInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameServerInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameServerInstancesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeGameSessionDetails

        internal virtual DescribeGameSessionDetailsResponse DescribeGameSessionDetails(DescribeGameSessionDetailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionDetailsResponseUnmarshaller.Instance;

            return Invoke<DescribeGameSessionDetailsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves additional game session properties, including the game session protection
        /// policy in force, a set of one or more game sessions in a specific fleet location.
        /// You can optionally filter the results by current game session status.
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
        /// If successful, a <c>GameSessionDetail</c> object is returned for each game session
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <c>RoutingStrategy</c> associated with it. The message returned in this
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameSessionDetailsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeGameSessionPlacement

        internal virtual DescribeGameSessionPlacementResponse DescribeGameSessionPlacement(DescribeGameSessionPlacementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// you must configure an Amazon Simple Notification Service (SNS) topic to receive notifications
        /// from FlexMatch or queues. Continuously polling with <c>DescribeGameSessionPlacement</c>
        /// should only be used for games in development with low game session usage. 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionPlacement">REST API Reference for DescribeGameSessionPlacement Operation</seealso>
        public virtual Task<DescribeGameSessionPlacementResponse> DescribeGameSessionPlacementAsync(DescribeGameSessionPlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionPlacementResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameSessionPlacementResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeGameSessionQueues

        internal virtual DescribeGameSessionQueuesResponse DescribeGameSessionQueues(DescribeGameSessionQueuesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionQueuesResponseUnmarshaller.Instance;

            return Invoke<DescribeGameSessionQueuesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the properties for one or more game session queues. When requesting multiple
        /// queues, use the pagination parameters to retrieve results as a set of sequential pages.
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionQueues">REST API Reference for DescribeGameSessionQueues Operation</seealso>
        public virtual Task<DescribeGameSessionQueuesResponse> DescribeGameSessionQueuesAsync(DescribeGameSessionQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionQueuesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameSessionQueuesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeGameSessions

        internal virtual DescribeGameSessionsResponse DescribeGameSessions(DescribeGameSessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionsResponseUnmarshaller.Instance;

            return Invoke<DescribeGameSessionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a set of one or more game sessions in a specific fleet location. You can
        /// optionally filter the results by current game session status.
        /// 
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
        /// If successful, a <c>GameSession</c> object is returned for each game session that
        /// matches the request.
        /// </para>
        ///  
        /// <para>
        /// This operation is not designed to be continually called to track game session status.
        /// This practice can cause you to exceed your API limit, which results in errors. Instead,
        /// you must configure an Amazon Simple Notification Service (SNS) topic to receive notifications
        /// from FlexMatch or queues. Continuously polling with <c>DescribeGameSessions</c> should
        /// only be used for games in development with low game session usage. 
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Servers Local.</i> 
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <c>RoutingStrategy</c> associated with it. The message returned in this
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameSessionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeInstances

        internal virtual DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about the EC2 instances in an Amazon GameLift Servers managed
        /// fleet, including instance ID, connection data, and status. You can use this operation
        /// with a multi-location fleet to get location-specific instance information. As an alternative,
        /// use the operations <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ListCompute">https://docs.aws.amazon.com/gamelift/latest/apireference/API_ListCompute</a>
        /// and <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeCompute">https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeCompute</a>
        /// to retrieve information for compute resources, including EC2 and Anywhere fleets.
        /// 
        ///  
        /// <para>
        /// You can call this operation in the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To get information on all instances in a fleet's home Region, specify the fleet ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To get information on all instances in a fleet's remote location, specify the fleet
        /// ID and location name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To get information on a specific instance in a fleet, specify the fleet ID and instance
        /// ID.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Use the pagination parameters to retrieve results as a set of sequential pages. 
        /// </para>
        ///  
        /// <para>
        /// If successful, this operation returns <c>Instance</c> objects for each requested instance,
        /// listed in no particular order. If you call this operation for an Anywhere fleet, you
        /// receive an InvalidRequestException.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-remote-access.html">Remotely
        /// connect to fleet instances</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-debug.html">Debug
        /// fleet issues</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstancesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeMatchmaking

        internal virtual DescribeMatchmakingResponse DescribeMatchmaking(DescribeMatchmakingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// notifications, and provide the topic ARN in the matchmaking configuration.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMatchmakingResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMatchmakingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeMatchmakingConfigurations

        internal virtual DescribeMatchmakingConfigurationsResponse DescribeMatchmakingConfigurations(DescribeMatchmakingConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMatchmakingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMatchmakingConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMatchmakingConfigurationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeMatchmakingRuleSets

        internal virtual DescribeMatchmakingRuleSetsResponse DescribeMatchmakingRuleSets(DescribeMatchmakingRuleSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmakingRuleSets">REST API Reference for DescribeMatchmakingRuleSets Operation</seealso>
        public virtual Task<DescribeMatchmakingRuleSetsResponse> DescribeMatchmakingRuleSetsAsync(DescribeMatchmakingRuleSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMatchmakingRuleSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMatchmakingRuleSetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMatchmakingRuleSetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribePlayerSessions

        internal virtual DescribePlayerSessionsResponse DescribePlayerSessions(DescribePlayerSessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// player ID. You can filter this request by player session status. If you provide a
        /// specific <c>PlayerSessionId</c> or <c>PlayerId</c>, Amazon GameLift Servers ignores
        /// the filter criteria. Use the pagination parameters to retrieve results as a set of
        /// sequential pages. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a <c>PlayerSession</c> object is returned for each session that matches
        /// the request.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribePlayerSessions">REST API Reference for DescribePlayerSessions Operation</seealso>
        public virtual Task<DescribePlayerSessionsResponse> DescribePlayerSessionsAsync(DescribePlayerSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePlayerSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePlayerSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePlayerSessionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeRuntimeConfiguration

        internal virtual DescribeRuntimeConfigurationResponse DescribeRuntimeConfiguration(DescribeRuntimeConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRuntimeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuntimeConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeRuntimeConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a fleet's runtime configuration settings. The runtime configuration determines
        /// which server processes run, and how, on computes in the fleet. For managed EC2 fleets,
        /// the runtime configuration describes server processes that run on each fleet instance.
        /// can update a fleet's runtime configuration at any time using <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_UpdateRuntimeConfiguration.html">UpdateRuntimeConfiguration</a>.
        /// 
        ///  
        /// <para>
        /// To get the current runtime configuration for a fleet, provide the fleet ID. 
        /// </para>
        ///  
        /// <para>
        /// If successful, a <c>RuntimeConfiguration</c> object is returned for the requested
        /// fleet. If the requested fleet has been deleted, the result set is empty.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up Amazon GameLift Servers fleets</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-multiprocess.html">Running
        /// multiple processes on a fleet</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeRuntimeConfiguration">REST API Reference for DescribeRuntimeConfiguration Operation</seealso>
        public virtual Task<DescribeRuntimeConfigurationResponse> DescribeRuntimeConfigurationAsync(DescribeRuntimeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRuntimeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuntimeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRuntimeConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeScalingPolicies

        internal virtual DescribeScalingPoliciesResponse DescribeScalingPolicies(DescribeScalingPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>ScalingPolicy</c> objects is returned for the fleet.
        /// </para>
        ///  
        /// <para>
        /// A fleet may have all of its scaling policies suspended. This operation does not affect
        /// the status of the scaling policies, which remains ACTIVE.
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeScalingPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalingPoliciesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeScript

        internal virtual DescribeScriptResponse DescribeScript(DescribeScriptRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// GameLift Servers Amazon GameLift Servers Realtime</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeScript">REST API Reference for DescribeScript Operation</seealso>
        public virtual Task<DescribeScriptResponse> DescribeScriptAsync(DescribeScriptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScriptResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScriptResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeVpcPeeringAuthorizations

        internal virtual DescribeVpcPeeringAuthorizationsResponse DescribeVpcPeeringAuthorizations(DescribeVpcPeeringAuthorizationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVpcPeeringAuthorizationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcPeeringAuthorizationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcPeeringAuthorizationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeVpcPeeringConnections

        internal virtual DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// account that is used to manage the Amazon GameLift Servers fleets. Specify a fleet
        /// ID or leave the parameter empty to retrieve all connection records. If successful,
        /// the retrieved information includes both active and pending connections. Active connections
        /// identify the IpV4 CIDR block that the VPC uses to connect. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        public virtual Task<DescribeVpcPeeringConnectionsResponse> DescribeVpcPeeringConnectionsAsync(DescribeVpcPeeringConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVpcPeeringConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcPeeringConnectionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetComputeAccess

        internal virtual GetComputeAccessResponse GetComputeAccess(GetComputeAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComputeAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComputeAccessResponseUnmarshaller.Instance;

            return Invoke<GetComputeAccessResponse>(request, options);
        }



        /// <summary>
        /// Requests authorization to remotely connect to a hosting resource in a Amazon GameLift
        /// Servers managed fleet. This operation is not used with Amazon GameLift Servers Anywhere
        /// fleets.
        /// 
        ///  
        /// <para>
        ///  <b>Request options</b> 
        /// </para>
        ///  
        /// <para>
        /// Provide the fleet ID and compute name. The compute name varies depending on the type
        /// of fleet.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a compute in a managed EC2 fleet, provide an instance ID. Each instance in the
        /// fleet is a compute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a compute in a managed container fleet, provide a compute name. In a container
        /// fleet, each game server container group on a fleet instance is assigned a compute
        /// name. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Results</b> 
        /// </para>
        ///  
        /// <para>
        /// If successful, this operation returns a set of temporary Amazon Web Services credentials,
        /// including a two-part access key and a session token.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// With a managed EC2 fleet (where compute type is <c>EC2</c>), use these credentials
        /// with Amazon EC2 Systems Manager (SSM) to start a session with the compute. For more
        /// details, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/session-manager-working-with-sessions-start.html#sessions-start-cli">
        /// Starting a session (CLI)</a> in the <i>Amazon EC2 Systems Manager User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComputeAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComputeAccess service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetComputeAccess">REST API Reference for GetComputeAccess Operation</seealso>
        public virtual Task<GetComputeAccessResponse> GetComputeAccessAsync(GetComputeAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComputeAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComputeAccessResponseUnmarshaller.Instance;

            return InvokeAsync<GetComputeAccessResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetComputeAuthToken

        internal virtual GetComputeAuthTokenResponse GetComputeAuthToken(GetComputeAuthTokenRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComputeAuthTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComputeAuthTokenResponseUnmarshaller.Instance;

            return Invoke<GetComputeAuthTokenResponse>(request, options);
        }



        /// <summary>
        /// Requests an authentication token from Amazon GameLift Servers for a compute resource
        /// in an Amazon GameLift Servers fleet. Game servers that are running on the compute
        /// use this token to communicate with the Amazon GameLift Servers service, such as when
        /// calling the Amazon GameLift Servers server SDK action <c>InitSDK()</c>. Authentication
        /// tokens are valid for a limited time span, so you need to request a fresh token before
        /// the current token expires.
        /// 
        ///  
        /// <para>
        ///  <b>Request options</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For managed EC2 fleets (compute type <c>EC2</c>), auth token retrieval and refresh
        /// is handled automatically. All game servers that are running on all fleet instances
        /// have access to a valid auth token.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Anywhere fleets (compute type <c>ANYWHERE</c>), if you're using the Amazon GameLift
        /// Servers Agent, auth token retrieval and refresh is handled automatically for any compute
        /// where the Agent is running. If you're not using the Agent, create a mechanism to retrieve
        /// and refresh auth tokens for computes that are running game server processes.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-anywhere.html">Create
        /// an Anywhere fleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/integration-testing.html">Test
        /// your integration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-serversdk.html">Server
        /// SDK reference guides</a> (for version 5.x)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComputeAuthToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComputeAuthToken service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetComputeAuthToken">REST API Reference for GetComputeAuthToken Operation</seealso>
        public virtual Task<GetComputeAuthTokenResponse> GetComputeAuthTokenAsync(GetComputeAuthTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComputeAuthTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComputeAuthTokenResponseUnmarshaller.Instance;

            return InvokeAsync<GetComputeAuthTokenResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetGameSessionLogUrl

        internal virtual GetGameSessionLogUrlResponse GetGameSessionLogUrl(GetGameSessionLogUrlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGameSessionLogUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGameSessionLogUrlResponseUnmarshaller.Instance;

            return Invoke<GetGameSessionLogUrlResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the location of stored game session logs for a specified game session on
        /// Amazon GameLift Servers managed fleets. When a game session is terminated, Amazon
        /// GameLift Servers automatically stores the logs in Amazon S3 and retains them for 14
        /// days. Use this URL to download the logs.
        /// 
        ///  <note> 
        /// <para>
        /// See the <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_gamelift">Amazon
        /// Web Services Service Limits</a> page for maximum log file sizes. Log files that exceed
        /// this limit are not saved.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
        /// Retrieves the location of stored game session logs for a specified game session on
        /// Amazon GameLift Servers managed fleets. When a game session is terminated, Amazon
        /// GameLift Servers automatically stores the logs in Amazon S3 and retains them for 14
        /// days. Use this URL to download the logs.
        /// 
        ///  <note> 
        /// <para>
        /// See the <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_gamelift">Amazon
        /// Web Services Service Limits</a> page for maximum log file sizes. Log files that exceed
        /// this limit are not saved.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetGameSessionLogUrl">REST API Reference for GetGameSessionLogUrl Operation</seealso>
        public virtual Task<GetGameSessionLogUrlResponse> GetGameSessionLogUrlAsync(GetGameSessionLogUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGameSessionLogUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGameSessionLogUrlResponseUnmarshaller.Instance;

            return InvokeAsync<GetGameSessionLogUrlResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetInstanceAccess

        internal virtual GetInstanceAccessResponse GetInstanceAccess(GetInstanceAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInstanceAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceAccessResponseUnmarshaller.Instance;

            return Invoke<GetInstanceAccessResponse>(request, options);
        }



        /// <summary>
        /// Requests authorization to remotely connect to an instance in an Amazon GameLift Servers
        /// managed fleet. Use this operation to connect to instances with game servers that use
        /// Amazon GameLift Servers server SDK 4.x or earlier. To connect to instances with game
        /// servers that use server SDK 5.x or later, call <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GetComputeAccess">https://docs.aws.amazon.com/gamelift/latest/apireference/API_GetComputeAccess</a>.
        /// 
        ///  
        /// <para>
        /// To request access to an instance, specify IDs for the instance and the fleet it belongs
        /// to. You can retrieve instance IDs for a fleet by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeInstances.html">DescribeInstances</a>
        /// with the fleet ID. 
        /// </para>
        ///  
        /// <para>
        /// If successful, this operation returns an IP address and credentials. The returned
        /// credentials match the operating system of the instance, as follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a Windows instance: returns a user name and secret (password) for use with a Windows
        /// Remote Desktop client. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a Linux instance: returns a user name and secret (RSA private key) for use with
        /// an SSH client. You must save the secret to a <c>.pem</c> file. If you're using the
        /// CLI, see the example <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GetInstanceAccess.html#API_GetInstanceAccess_Examples">
        /// Get credentials for a Linux instance</a> for tips on automatically saving the secret
        /// to a <c>.pem</c> file. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-remote-access.html">Remotely
        /// connect to fleet instances</a> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-debug.html">Debug
        /// fleet issues</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetInstanceAccess">REST API Reference for GetInstanceAccess Operation</seealso>
        public virtual Task<GetInstanceAccessResponse> GetInstanceAccessAsync(GetInstanceAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInstanceAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceAccessResponseUnmarshaller.Instance;

            return InvokeAsync<GetInstanceAccessResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAliases

        internal virtual ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAliasesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBuilds

        internal virtual ListBuildsResponse ListBuilds(ListBuildsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBuildsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBuildsResponseUnmarshaller.Instance;

            return Invoke<ListBuildsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves build resources for all builds associated with the Amazon Web Services account
        /// in use. You can limit results to builds that are in a specific status by using the
        /// <c>Status</c> parameter. Use the pagination parameters to retrieve results in a set
        /// of sequential pages. 
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBuildsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBuildsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBuildsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCompute

        internal virtual ListComputeResponse ListCompute(ListComputeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComputeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComputeResponseUnmarshaller.Instance;

            return Invoke<ListComputeResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information on the compute resources in an Amazon GameLift Servers fleet.
        /// Use the pagination parameters to retrieve results in a set of sequential pages.
        /// 
        ///  
        /// <para>
        ///  <b>Request options</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Retrieve a list of all computes in a fleet. Specify a fleet ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Retrieve a list of all computes in a specific fleet location. Specify a fleet ID and
        /// location.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Results</b> 
        /// </para>
        ///  
        /// <para>
        /// If successful, this operation returns information on a set of computes. Depending
        /// on the type of fleet, the result includes the following information: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a managed EC2 fleet (compute type <c>EC2</c>), this operation returns information
        /// about the EC2 instance. Compute names are EC2 instance IDs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an Anywhere fleet (compute type <c>ANYWHERE</c>), this operation returns compute
        /// names and details from when the compute was registered with <c>RegisterCompute</c>.
        /// This includes <c>GameLiftServiceSdkEndpoint</c> or <c>GameLiftAgentEndpoint</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCompute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCompute service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListCompute">REST API Reference for ListCompute Operation</seealso>
        public virtual Task<ListComputeResponse> ListComputeAsync(ListComputeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComputeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComputeResponseUnmarshaller.Instance;

            return InvokeAsync<ListComputeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListContainerFleets

        internal virtual ListContainerFleetsResponse ListContainerFleets(ListContainerFleetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContainerFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContainerFleetsResponseUnmarshaller.Instance;

            return Invoke<ListContainerFleetsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a collection of container fleet resources in an Amazon Web Services Region.
        /// For fleets that have multiple locations, this operation retrieves fleets based on
        /// their home Region only.
        /// 
        ///  
        /// <para>
        ///  <b>Request options</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Get a list of all fleets. Call this operation without specifying a container group
        /// definition. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Get a list of fleets filtered by container group definition. Provide the container
        /// group definition name or ARN value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To get a list of all Amazon GameLift Servers Realtime fleets with a specific configuration
        /// script, provide the script ID. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Use the pagination parameters to retrieve results as a set of sequential pages. 
        /// </para>
        ///  
        /// <para>
        /// If successful, this operation returns a collection of container fleets that match
        /// the request parameters. A NextToken value is also returned if there are more result
        /// pages to retrieve.
        /// </para>
        ///  <note> 
        /// <para>
        /// Fleet IDs are returned in no particular order.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContainerFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContainerFleets service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListContainerFleets">REST API Reference for ListContainerFleets Operation</seealso>
        public virtual Task<ListContainerFleetsResponse> ListContainerFleetsAsync(ListContainerFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContainerFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContainerFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListContainerFleetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListContainerGroupDefinitions

        internal virtual ListContainerGroupDefinitionsResponse ListContainerGroupDefinitions(ListContainerGroupDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContainerGroupDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContainerGroupDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListContainerGroupDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves container group definitions for the Amazon Web Services account and Amazon
        /// Web Services Region. Use the pagination parameters to retrieve results in a set of
        /// sequential pages.
        /// 
        ///  
        /// <para>
        /// This operation returns only the latest version of each definition. To retrieve all
        /// versions of a container group definition, use <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ListContainerGroupDefinitionVersions.html">ListContainerGroupDefinitionVersions</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Request options:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Retrieve the most recent versions of all container group definitions. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Retrieve the most recent versions of all container group definitions, filtered by
        /// type. Specify the container group type to filter on. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Results:</b> 
        /// </para>
        ///  
        /// <para>
        /// If successful, this operation returns the complete properties of a set of container
        /// group definition versions that match the request.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation returns the list of container group definitions in no particular order.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContainerGroupDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContainerGroupDefinitions service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListContainerGroupDefinitions">REST API Reference for ListContainerGroupDefinitions Operation</seealso>
        public virtual Task<ListContainerGroupDefinitionsResponse> ListContainerGroupDefinitionsAsync(ListContainerGroupDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContainerGroupDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContainerGroupDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListContainerGroupDefinitionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListContainerGroupDefinitionVersions

        internal virtual ListContainerGroupDefinitionVersionsResponse ListContainerGroupDefinitionVersions(ListContainerGroupDefinitionVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContainerGroupDefinitionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContainerGroupDefinitionVersionsResponseUnmarshaller.Instance;

            return Invoke<ListContainerGroupDefinitionVersionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves all versions of a container group definition. Use the pagination parameters
        /// to retrieve results in a set of sequential pages.
        /// 
        ///  
        /// <para>
        ///  <b>Request options:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Get all versions of a specified container group definition. Specify the container
        /// group definition name or ARN value. (If the ARN value has a version number, it's ignored.)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Results:</b> 
        /// </para>
        ///  
        /// <para>
        /// If successful, this operation returns the complete properties of a set of container
        /// group definition versions that match the request.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation returns the list of container group definitions in descending version
        /// order (latest first). 
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/containers-create-groups.html">Manage
        /// a container group definition</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContainerGroupDefinitionVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContainerGroupDefinitionVersions service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListContainerGroupDefinitionVersions">REST API Reference for ListContainerGroupDefinitionVersions Operation</seealso>
        public virtual Task<ListContainerGroupDefinitionVersionsResponse> ListContainerGroupDefinitionVersionsAsync(ListContainerGroupDefinitionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContainerGroupDefinitionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContainerGroupDefinitionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListContainerGroupDefinitionVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFleetDeployments

        internal virtual ListFleetDeploymentsResponse ListFleetDeployments(ListFleetDeploymentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFleetDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ListFleetDeploymentsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a collection of container fleet deployments in an Amazon Web Services Region.
        /// Use the pagination parameters to retrieve results as a set of sequential pages. 
        /// 
        ///  
        /// <para>
        ///  <b>Request options</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Get a list of all deployments. Call this operation without specifying a fleet ID.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Get a list of all deployments for a fleet. Specify the container fleet ID or ARN value.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Results</b> 
        /// </para>
        ///  
        /// <para>
        /// If successful, this operation returns a list of deployments that match the request
        /// parameters. A NextToken value is also returned if there are more result pages to retrieve.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deployments are returned starting with the latest.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleetDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFleetDeployments service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListFleetDeployments">REST API Reference for ListFleetDeployments Operation</seealso>
        public virtual Task<ListFleetDeploymentsResponse> ListFleetDeploymentsAsync(ListFleetDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFleetDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFleetDeploymentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFleets

        internal virtual ListFleetsResponse ListFleets(ListFleetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return Invoke<ListFleetsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a collection of fleet resources in an Amazon Web Services Region. You can
        /// filter the result set to find only those fleets that are deployed with a specific
        /// build or script. For fleets that have multiple locations, this operation retrieves
        /// fleets based on their home Region only.
        /// 
        ///  
        /// <para>
        /// You can use operation in the following ways: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To get a list of all fleets in a Region, don't provide a build or script identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To get a list of all fleets where a specific game build is deployed, provide the build
        /// ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To get a list of all Amazon GameLift Servers Realtime fleets with a specific configuration
        /// script, provide the script ID. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Use the pagination parameters to retrieve results as a set of sequential pages. 
        /// </para>
        ///  
        /// <para>
        /// If successful, this operation returns a list of fleet IDs that match the request parameters.
        /// A NextToken value is also returned if there are more result pages to retrieve.
        /// </para>
        ///  <note> 
        /// <para>
        /// Fleet IDs are returned in no particular order.
        /// </para>
        ///  </note>
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListFleets">REST API Reference for ListFleets Operation</seealso>
        public virtual Task<ListFleetsResponse> ListFleetsAsync(ListFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFleetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListGameServerGroups

        internal virtual ListGameServerGroupsResponse ListGameServerGroups(ListGameServerGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGameServerGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGameServerGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGameServerGroupsResponse>(request, options);
        }



        /// <summary>
        /// Lists a game server groups.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGameServerGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGameServerGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGameServerGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListGameServers

        internal virtual ListGameServersResponse ListGameServers(ListGameServersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGameServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGameServersResponseUnmarshaller.Instance;

            return Invoke<ListGameServersResponse>(request, options);
        }



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift Servers FleetIQ solution and game
        /// server groups.</b> 
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">Amazon
        /// GameLift Servers FleetIQ Guide</a> 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGameServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGameServersResponseUnmarshaller.Instance;

            return InvokeAsync<ListGameServersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListLocations

        internal virtual ListLocationsResponse ListLocations(ListLocationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLocationsResponseUnmarshaller.Instance;

            return Invoke<ListLocationsResponse>(request, options);
        }



        /// <summary>
        /// Lists all custom and Amazon Web Services locations where Amazon GameLift Servers can
        /// host game servers. 
        /// 
        ///  
        /// <para>
        /// Note that if you call this API using a location that doesn't have a service endpoint,
        /// such as one that can only be a remote location in a multi-location fleet, the API
        /// returns an error.
        /// </para>
        ///  
        /// <para>
        /// Consult the table of supported locations in <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-regions.html">Amazon
        /// GameLift Servers service locations</a> to identify home Regions that support single
        /// and multi-location fleets.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-regions.html">Service
        /// locations</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLocations service method, as returned by GameLift.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListLocations">REST API Reference for ListLocations Operation</seealso>
        public virtual Task<ListLocationsResponse> ListLocationsAsync(ListLocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLocationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLocationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListScripts

        internal virtual ListScriptsResponse ListScripts(ListScriptsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// GameLift Servers Amazon GameLift Servers Realtime</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListScriptsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScriptsResponseUnmarshaller.Instance;

            return InvokeAsync<ListScriptsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Retrieves all tags assigned to a Amazon GameLift Servers resource. Use resource tags
        /// to organize Amazon Web Services resources for a range of purposes. This operation
        /// handles the permissions necessary to manage tags for Amazon GameLift Servers resources
        /// that support tagging.
        /// 
        ///  
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutScalingPolicy

        internal virtual PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<PutScalingPolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates or updates a scaling policy for a fleet. Scaling policies are used to automatically
        /// scale a fleet's hosting capacity to meet player demand. An active scaling policy instructs
        /// Amazon GameLift Servers to track a fleet metric and automatically change the fleet's
        /// capacity when a certain threshold is reached. There are two types of scaling policies:
        /// target-based and rule-based. Use a target-based policy to quickly and efficiently
        /// manage fleet scaling; this option is the most commonly used. Use rule-based policies
        /// when you need to exert fine-grained control over auto-scaling. 
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
        /// you set your ideal buffer size and leave it to Amazon GameLift Servers to take whatever
        /// action is needed to maintain that target. 
        /// </para>
        ///  
        /// <para>
        /// For example, you might choose to maintain a 10% buffer for a fleet that has the capacity
        /// to host 100 simultaneous game sessions. This policy tells Amazon GameLift Servers
        /// to take action whenever the fleet's available capacity falls below or rises above
        /// 10 game sessions. Amazon GameLift Servers will start new instances or stop unused
        /// instances in order to return to the 10% buffer. 
        /// </para>
        ///  
        /// <para>
        /// To create or update a target-based policy, specify a fleet ID and name, and set the
        /// policy type to "TargetBased". Specify the metric to track (PercentAvailableGameSessions)
        /// and reference a <c>TargetConfiguration</c> object with your desired buffer value.
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
        /// If <c>[MetricName]</c> is <c>[ComparisonOperator]</c> <c>[Threshold]</c> for <c>[EvaluationPeriods]</c>
        /// minutes, then <c>[ScalingAdjustmentType]</c> to/by <c>[ScalingAdjustment]</c>.
        /// </para>
        ///  
        /// <para>
        /// To implement the example, the rule statement would look like this:
        /// </para>
        ///  
        /// <para>
        /// If <c>[PercentIdleInstances]</c> is <c>[GreaterThanThreshold]</c> <c>[20]</c> for
        /// <c>[15]</c> minutes, then <c>[PercentChangeInCapacity]</c> to/by <c>[10]</c>.
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        public virtual Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutScalingPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RegisterCompute

        internal virtual RegisterComputeResponse RegisterCompute(RegisterComputeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterComputeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterComputeResponseUnmarshaller.Instance;

            return Invoke<RegisterComputeResponse>(request, options);
        }



        /// <summary>
        /// Registers a compute resource in an Amazon GameLift Servers Anywhere fleet. 
        /// 
        ///  
        /// <para>
        /// For an Anywhere fleet that's running the Amazon GameLift Servers Agent, the Agent
        /// handles all compute registry tasks for you. For an Anywhere fleet that doesn't use
        /// the Agent, call this operation to register fleet computes.
        /// </para>
        ///  
        /// <para>
        /// To register a compute, give the compute a name (must be unique within the fleet) and
        /// specify the compute resource's DNS name or IP address. Provide a fleet ID and a fleet
        /// location to associate with the compute being registered. You can optionally include
        /// the path to a TLS certificate on the compute resource.
        /// </para>
        ///  
        /// <para>
        /// If successful, this operation returns compute details, including an Amazon GameLift
        /// Servers SDK endpoint or Agent endpoint. Game server processes running on the compute
        /// can use this endpoint to communicate with the Amazon GameLift Servers service. Each
        /// server process includes the SDK endpoint in its call to the Amazon GameLift Servers
        /// server SDK action <c>InitSDK()</c>. 
        /// </para>
        ///  
        /// <para>
        /// To view compute details, call <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeCompute.html">DescribeCompute</a>
        /// with the compute name. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-anywhere.html">Create
        /// an Anywhere fleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/integration-testing.html">Test
        /// your integration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-serversdk.html">Server
        /// SDK reference guides</a> (for version 5.x)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCompute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterCompute service method, as returned by GameLift.</returns>
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
        /// <exception cref="Amazon.GameLift.Model.NotReadyException">
        /// The operation failed because Amazon GameLift Servers has not yet finished validating
        /// this compute. We recommend attempting 8 to 10 retries over 3 to 5 minutes with <a
        /// href="http://aws.amazon.com/blogs/https:/aws.amazon.com/blogs/architecture/exponential-backoff-and-jitter/">exponential
        /// backoffs and jitter</a>.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/RegisterCompute">REST API Reference for RegisterCompute Operation</seealso>
        public virtual Task<RegisterComputeResponse> RegisterComputeAsync(RegisterComputeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterComputeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterComputeResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterComputeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RegisterGameServer

        internal virtual RegisterGameServerResponse RegisterGameServer(RegisterGameServerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterGameServerResponseUnmarshaller.Instance;

            return Invoke<RegisterGameServerResponse>(request, options);
        }



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift Servers FleetIQ solution and game
        /// server groups.</b> 
        /// 
        ///  
        /// <para>
        /// Creates a new game server resource and notifies Amazon GameLift Servers FleetIQ that
        /// the game server is ready to host gameplay and players. This operation is called by
        /// a game server process that is running on an instance in a game server group. Registering
        /// game servers enables Amazon GameLift Servers FleetIQ to track available game servers
        /// and enables game clients and services to claim a game server for a new game session.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To register a game server, identify the game server group and instance where the game
        /// server is running, and provide a unique identifier for the game server. You can also
        /// include connection and game server data.
        /// </para>
        ///  
        /// <para>
        /// Once a game server is successfully registered, it is put in status <c>AVAILABLE</c>.
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">Amazon
        /// GameLift Servers FleetIQ Guide</a> 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterGameServerResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterGameServerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RequestUploadCredentials

        internal virtual RequestUploadCredentialsResponse RequestUploadCredentials(RequestUploadCredentialsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RequestUploadCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestUploadCredentialsResponseUnmarshaller.Instance;

            return Invoke<RequestUploadCredentialsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a fresh set of credentials for use when uploading a new set of game build
        /// files to Amazon GameLift Servers's Amazon S3. This is done as part of the build creation
        /// process; see <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateBuild.html">CreateBuild</a>.
        /// 
        ///  
        /// <para>
        /// To request new credentials, specify the build ID as returned with an initial <c>CreateBuild</c>
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
        /// files to Amazon GameLift Servers's Amazon S3. This is done as part of the build creation
        /// process; see <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateBuild.html">CreateBuild</a>.
        /// 
        ///  
        /// <para>
        /// To request new credentials, specify the build ID as returned with an initial <c>CreateBuild</c>
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/RequestUploadCredentials">REST API Reference for RequestUploadCredentials Operation</seealso>
        public virtual Task<RequestUploadCredentialsResponse> RequestUploadCredentialsAsync(RequestUploadCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RequestUploadCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestUploadCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<RequestUploadCredentialsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ResolveAlias

        internal virtual ResolveAliasResponse ResolveAlias(ResolveAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResolveAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveAliasResponseUnmarshaller.Instance;

            return Invoke<ResolveAliasResponse>(request, options);
        }


        /// <summary>
        /// Attempts to retrieve a fleet ID that is associated with an alias. Specify a unique
        /// alias identifier.
        /// 
        ///  
        /// <para>
        /// If the alias has a <c>SIMPLE</c> routing strategy, Amazon GameLift Servers returns
        /// a fleet ID. If the alias has a <c>TERMINAL</c> routing strategy, the result is a <c>TerminalRoutingStrategyException</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <c>RoutingStrategy</c> associated with it. The message returned in this
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
        /// Attempts to retrieve a fleet ID that is associated with an alias. Specify a unique
        /// alias identifier.
        /// 
        ///  
        /// <para>
        /// If the alias has a <c>SIMPLE</c> routing strategy, Amazon GameLift Servers returns
        /// a fleet ID. If the alias has a <c>TERMINAL</c> routing strategy, the result is a <c>TerminalRoutingStrategyException</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <c>RoutingStrategy</c> associated with it. The message returned in this
        /// exception is the message defined in the routing strategy itself. Such requests should
        /// only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ResolveAlias">REST API Reference for ResolveAlias Operation</seealso>
        public virtual Task<ResolveAliasResponse> ResolveAliasAsync(ResolveAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResolveAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveAliasResponseUnmarshaller.Instance;

            return InvokeAsync<ResolveAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ResumeGameServerGroup

        internal virtual ResumeGameServerGroupResponse ResumeGameServerGroup(ResumeGameServerGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResumeGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeGameServerGroupResponseUnmarshaller.Instance;

            return Invoke<ResumeGameServerGroupResponse>(request, options);
        }



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift Servers FleetIQ solution and game
        /// server groups.</b> 
        /// 
        ///  
        /// <para>
        /// Reinstates activity on a game server group after it has been suspended. A game server
        /// group might be suspended by the <a href="gamelift/latest/apireference/API_SuspendGameServerGroup.html">SuspendGameServerGroup</a>
        /// operation, or it might be suspended involuntarily due to a configuration problem.
        /// In the second case, you can manually resume activity on the group once the configuration
        /// problem has been resolved. Refer to the game server group status and status reason
        /// for more information on why group activity is suspended.
        /// </para>
        ///  
        /// <para>
        /// To resume activity, specify a game server group ARN and the type of activity to be
        /// resumed. If successful, a <c>GameServerGroup</c> object is returned showing that the
        /// resumed activity is no longer listed in <c>SuspendedActions</c>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">Amazon
        /// GameLift Servers FleetIQ Guide</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ResumeGameServerGroup">REST API Reference for ResumeGameServerGroup Operation</seealso>
        public virtual Task<ResumeGameServerGroupResponse> ResumeGameServerGroupAsync(ResumeGameServerGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResumeGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeGameServerGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ResumeGameServerGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchGameSessions

        internal virtual SearchGameSessionsResponse SearchGameSessions(SearchGameSessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// This operation is not designed to continually track game session status because that
        /// practice can cause you to exceed your API limit and generate errors. Instead, configure
        /// an Amazon Simple Notification Service (Amazon SNS) topic to receive notifications
        /// from a matchmaker or a game session placement queue.
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
        /// If successful, a <c>GameSession</c> object is returned for each game session that
        /// matches the request. Search finds game sessions that are in <c>ACTIVE</c> status only.
        /// To retrieve information on game sessions in other statuses, use <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeGameSessions.html">DescribeGameSessions</a>.
        /// </para>
        ///  
        /// <para>
        /// To set search and sort criteria, create a filter expression using the following game
        /// session attributes. For game session search examples, see the Examples section of
        /// this topic.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>gameSessionId</b> -- A unique identifier for the game session. You can use either
        /// a <c>GameSessionId</c> or <c>GameSessionArn</c> value. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>gameSessionName</b> -- Name assigned to a game session. Game session names do
        /// not need to be unique to a game session.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>gameSessionProperties</b> -- A set of key-value pairs that can store custom data
        /// in a game session. For example: <c>{"Key": "difficulty", "Value": "novice"}</c>. The
        /// filter expression must specify the <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GameProperty">https://docs.aws.amazon.com/gamelift/latest/apireference/API_GameProperty</a>
        /// -- a <c>Key</c> and a string <c>Value</c> to search for the game sessions.
        /// </para>
        ///  
        /// <para>
        /// For example, to search for the above key-value pair, specify the following search
        /// filter: <c>gameSessionProperties.difficulty = "novice"</c>. All game property values
        /// are searched as strings.
        /// </para>
        ///  
        /// <para>
        ///  For examples of searching game sessions, see the ones below, and also see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-client-api.html#game-properties-search">Search
        /// game sessions by game property</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>maximumSessions</b> -- Maximum number of player sessions allowed for a game session.
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
        /// Returned values for <c>playerSessionCount</c> and <c>hasAvailablePlayerSessions</c>
        /// change quickly as players join sessions and others drop out. Results should be considered
        /// a snapshot in time. Be sure to refresh search results often, and handle sessions that
        /// fill up before a player can join. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <c>RoutingStrategy</c> associated with it. The message returned in this
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchGameSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchGameSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchGameSessionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartFleetActions

        internal virtual StartFleetActionsResponse StartFleetActions(StartFleetActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFleetActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFleetActionsResponseUnmarshaller.Instance;

            return Invoke<StartFleetActionsResponse>(request, options);
        }



        /// <summary>
        /// Resumes certain types of activity on fleet instances that were suspended with <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_StopFleetActions.html">StopFleetActions</a>.
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
        /// If successful, Amazon GameLift Servers once again initiates scaling events as triggered
        /// by the fleet's scaling policies. If actions on the fleet location were never stopped,
        /// this operation will have no effect.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up Amazon GameLift Servers fleets</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFleetActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFleetActionsResponseUnmarshaller.Instance;

            return InvokeAsync<StartFleetActionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartGameSessionPlacement

        internal virtual StartGameSessionPlacementResponse StartGameSessionPlacement(StartGameSessionPlacementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGameSessionPlacementResponseUnmarshaller.Instance;

            return Invoke<StartGameSessionPlacementResponse>(request, options);
        }



        /// <summary>
        /// Makes a request to start a new game session using a game session queue. When processing
        /// a placement request, Amazon GameLift Servers looks for the best possible available
        /// resource to host the game session, based on how the queue is configured to prioritize
        /// factors such as resource cost, latency, and location. After selecting an available
        /// resource, Amazon GameLift Servers prompts the resource to start a game session. A
        /// placement request can include a list of players to create a set of player sessions.
        /// The request can also include information to pass to the new game session, such as
        /// to specify a game map or other options.
        /// 
        ///  
        /// <para>
        ///  <b>Request options</b> 
        /// </para>
        ///  
        /// <para>
        /// Use this operation to make the following types of requests. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Request a placement using the queue's default prioritization process (see the default
        /// prioritization described in <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_PriorityConfiguration.html">PriorityConfiguration</a>).
        /// Include these required parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>GameSessionQueueName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MaximumPlayerSessionCount</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PlacementID</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Request a placement and prioritize based on latency. Include these parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Required parameters <c>GameSessionQueueName</c>, <c>MaximumPlayerSessionCount</c>,
        /// <c>PlacementID</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PlayerLatencies</c>. Include a set of latency values for destinations in the queue.
        /// When a request includes latency data, Amazon GameLift Servers automatically reorder
        /// the queue's locations priority list based on lowest available latency values. If a
        /// request includes latency data for multiple players, Amazon GameLift Servers calculates
        /// each location's average latency for all players and reorders to find the lowest latency
        /// across all players. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Don't include <c>PriorityConfigurationOverride</c>.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// Prioritize based on a custom list of locations. If you're using a queue that's configured
        /// to prioritize location first (see <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_PriorityConfiguration.html">PriorityConfiguration</a>
        /// for game session queues), you can optionally use the <i>PriorityConfigurationOverride</i>
        /// parameter to substitute a different location priority list for this placement request.
        /// Amazon GameLift Servers searches each location on the priority override list to find
        /// an available hosting resource for the new game session. Specify a fallback strategy
        /// to use in the event that Amazon GameLift Servers fails to place the game session in
        /// any of the locations on the override list. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Request a placement and prioritized based on a custom list of locations. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can request new player sessions for a group of players. Include the <i>DesiredPlayerSessions</i>
        /// parameter and include at minimum a unique player ID for each. You can also include
        /// player-specific data to pass to the new game session. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Result</b> 
        /// </para>
        ///  
        /// <para>
        /// If successful, this operation generates a new game session placement request and adds
        /// it to the game session queue for processing. You can track the status of individual
        /// placement requests by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeGameSessionPlacement.html">DescribeGameSessionPlacement</a>
        /// or by monitoring queue notifications. When the request status is <c>FULFILLED</c>,
        /// a new game session has started and the placement request is updated with connection
        /// information for the game session (IP address and port). If the request included player
        /// session data, Amazon GameLift Servers creates a player session for each player ID
        /// in the request.
        /// </para>
        ///  
        /// <para>
        /// The request results in a <c>InvalidRequestException</c> in the following situations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the request includes both <i>PlayerLatencies</i> and <i>PriorityConfigurationOverride</i>
        /// parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the request includes the <i>PriorityConfigurationOverride</i> parameter and specifies
        /// a queue that doesn't prioritize locations.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon GameLift Servers continues to retry each placement request until it reaches
        /// the queue's timeout setting. If a request times out, you can resubmit the request
        /// to the same queue or try a different queue. 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartGameSessionPlacement">REST API Reference for StartGameSessionPlacement Operation</seealso>
        public virtual Task<StartGameSessionPlacementResponse> StartGameSessionPlacementAsync(StartGameSessionPlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGameSessionPlacementResponseUnmarshaller.Instance;

            return InvokeAsync<StartGameSessionPlacementResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartMatchBackfill

        internal virtual StartMatchBackfillResponse StartMatchBackfill(StartMatchBackfillRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// When using FlexMatch with Amazon GameLift Servers managed hosting, you can request
        /// a backfill match from a client service by calling this operation with a <c>GameSessions</c>
        /// ID. You also have the option of making backfill requests directly from your game server.
        /// In response to a request, FlexMatch creates player sessions for the new players, updates
        /// the <c>GameSession</c> resource, and sends updated matchmaking data to the game server.
        /// You can request a backfill match at any point after a game session is started. Each
        /// game session can have only one active backfill request at a time; a subsequent request
        /// automatically replaces the earlier request.
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
        /// backfilled. Optionally, specify the <c>GameSession</c> ARN. If successful, a match
        /// backfill ticket is created and returned with status set to QUEUED. Track the status
        /// of backfill tickets using the same method for tracking tickets for new matches.
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
        /// How Amazon GameLift Servers FlexMatch works</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartMatchBackfill">REST API Reference for StartMatchBackfill Operation</seealso>
        public virtual Task<StartMatchBackfillResponse> StartMatchBackfillAsync(StartMatchBackfillRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMatchBackfillRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMatchBackfillResponseUnmarshaller.Instance;

            return InvokeAsync<StartMatchBackfillResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartMatchmaking

        internal virtual StartMatchmakingResponse StartMatchmaking(StartMatchmakingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMatchmakingResponseUnmarshaller.Instance;

            return Invoke<StartMatchmakingResponse>(request, options);
        }



        /// <summary>
        /// Uses FlexMatch to create a game match for a group of players based on custom matchmaking
        /// rules. With games that use Amazon GameLift Servers managed hosting, this operation
        /// also triggers Amazon GameLift Servers to find hosting resources and start a new game
        /// session for the new match. Each matchmaking request includes information on one or
        /// more players and specifies the FlexMatch matchmaker to use. When a request is for
        /// multiple players, FlexMatch attempts to build a match that includes all players in
        /// the request, placing them in the same team and finding additional players as needed
        /// to fill the match. 
        /// 
        ///  
        /// <para>
        /// To start matchmaking, provide a unique ticket ID, specify a matchmaking configuration,
        /// and include the players to be matched. You must also include any player attributes
        /// that are required by the matchmaking configuration's rule set. If successful, a matchmaking
        /// ticket is returned with status set to <c>QUEUED</c>. 
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
        /// How Amazon GameLift Servers FlexMatch works</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartMatchmaking">REST API Reference for StartMatchmaking Operation</seealso>
        public virtual Task<StartMatchmakingResponse> StartMatchmakingAsync(StartMatchmakingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMatchmakingResponseUnmarshaller.Instance;

            return InvokeAsync<StartMatchmakingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopFleetActions

        internal virtual StopFleetActionsResponse StopFleetActions(StopFleetActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// If successful, Amazon GameLift Servers no longer initiates scaling events except in
        /// response to manual changes using <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_UpdateFleetCapacity.html">UpdateFleetCapacity</a>.
        /// To restart fleet actions again, call <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_StartFleetActions.html">StartFleetActions</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up Amazon GameLift Servers Fleets</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopFleetActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFleetActionsResponseUnmarshaller.Instance;

            return InvokeAsync<StopFleetActionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopGameSessionPlacement

        internal virtual StopGameSessionPlacementResponse StopGameSessionPlacement(StopGameSessionPlacementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopGameSessionPlacementResponseUnmarshaller.Instance;

            return Invoke<StopGameSessionPlacementResponse>(request, options);
        }



        /// <summary>
        /// Cancels a game session placement that's in <c>PENDING</c> status. To stop a placement,
        /// provide the placement ID value. 
        /// 
        ///  
        /// <para>
        /// Results
        /// </para>
        ///  
        /// <para>
        /// If successful, this operation removes the placement request from the queue and moves
        /// the <c>GameSessionPlacement</c> to <c>CANCELLED</c> status.
        /// </para>
        ///  
        /// <para>
        /// This operation results in an <c>InvalidRequestExecption</c> (400) error if a game
        /// session has already been created for this placement. You can clean up an unneeded
        /// game session by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_TerminateGameSession">TerminateGameSession</a>.
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopGameSessionPlacement">REST API Reference for StopGameSessionPlacement Operation</seealso>
        public virtual Task<StopGameSessionPlacementResponse> StopGameSessionPlacementAsync(StopGameSessionPlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopGameSessionPlacementResponseUnmarshaller.Instance;

            return InvokeAsync<StopGameSessionPlacementResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopMatchmaking

        internal virtual StopMatchmakingResponse StopMatchmaking(StopMatchmakingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopMatchmakingResponseUnmarshaller.Instance;

            return Invoke<StopMatchmakingResponse>(request, options);
        }



        /// <summary>
        /// Cancels a matchmaking ticket or match backfill ticket that is currently being processed.
        /// To stop the matchmaking operation, specify the ticket ID. If successful, work on the
        /// ticket is stopped, and the ticket status is changed to <c>CANCELLED</c>.
        /// 
        ///  
        /// <para>
        /// This call is also used to turn off automatic backfill for an individual game session.
        /// This is for game sessions that are created with a matchmaking configuration that has
        /// automatic backfill enabled. The ticket ID is included in the <c>MatchmakerData</c>
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopMatchmaking">REST API Reference for StopMatchmaking Operation</seealso>
        public virtual Task<StopMatchmakingResponse> StopMatchmakingAsync(StopMatchmakingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopMatchmakingResponseUnmarshaller.Instance;

            return InvokeAsync<StopMatchmakingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SuspendGameServerGroup

        internal virtual SuspendGameServerGroupResponse SuspendGameServerGroup(SuspendGameServerGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SuspendGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SuspendGameServerGroupResponseUnmarshaller.Instance;

            return Invoke<SuspendGameServerGroupResponse>(request, options);
        }



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift Servers FleetIQ solution and game
        /// server groups.</b> 
        /// 
        ///  
        /// <para>
        /// Temporarily stops activity on a game server group without terminating instances or
        /// the game server group. You can restart activity by calling <a href="gamelift/latest/apireference/API_ResumeGameServerGroup.html">ResumeGameServerGroup</a>.
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
        /// suspended. If successful, a <c>GameServerGroup</c> object is returned showing that
        /// the activity is listed in <c>SuspendedActions</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">Amazon
        /// GameLift Servers FleetIQ Guide</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/SuspendGameServerGroup">REST API Reference for SuspendGameServerGroup Operation</seealso>
        public virtual Task<SuspendGameServerGroupResponse> SuspendGameServerGroupAsync(SuspendGameServerGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SuspendGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SuspendGameServerGroupResponseUnmarshaller.Instance;

            return InvokeAsync<SuspendGameServerGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Assigns a tag to an Amazon GameLift Servers resource. You can use tags to organize
        /// resources, create IAM permissions policies to manage access to groups of resources,
        /// customize Amazon Web Services cost breakdowns, and more. This operation handles the
        /// permissions necessary to manage tags for Amazon GameLift Servers resources that support
        /// tagging.
        /// 
        ///  
        /// <para>
        /// To add a tag to a resource, specify the unique ARN value for the resource and provide
        /// a tag list containing one or more tags. The operation succeeds even if the list includes
        /// tags that are already assigned to the resource. 
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TerminateGameSession

        internal virtual TerminateGameSessionResponse TerminateGameSession(TerminateGameSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TerminateGameSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateGameSessionResponseUnmarshaller.Instance;

            return Invoke<TerminateGameSessionResponse>(request, options);
        }



        /// <summary>
        /// Ends a game session that's currently in progress. Use this action to terminate any
        /// game session that isn't in <c>ERROR</c> status. Terminating a game session is the
        /// most efficient way to free up a server process when it's hosting a game session that's
        /// in a bad state or not ending properly. You can use this action to terminate a game
        /// session that's being hosted on any type of Amazon GameLift Servers fleet compute,
        /// including computes for managed EC2, managed container, and Anywhere fleets. The game
        /// server must be integrated with Amazon GameLift Servers server SDK 5.x or greater.
        /// 
        ///  
        /// <para>
        ///  <b>Request options</b> 
        /// </para>
        ///  
        /// <para>
        /// Request termination for a single game session. Provide the game session ID and the
        /// termination mode. There are two potential methods for terminating a game session:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Initiate a graceful termination using the normal game session shutdown sequence. With
        /// this mode, the Amazon GameLift Servers service prompts the server process that's hosting
        /// the game session by calling the server SDK callback method <c>OnProcessTerminate()</c>.
        /// The callback implementation is part of the custom game server code. It might involve
        /// a variety of actions to gracefully end a game session, such as notifying players,
        /// before stopping the server process.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Force an immediate game session termination. With this mode, the Amazon GameLift Servers
        /// service takes action to stop the server process, which ends the game session without
        /// the normal game session shutdown sequence. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Results</b> 
        /// </para>
        ///  
        /// <para>
        /// If successful, game session termination is initiated. During this activity, the game
        /// session status is changed to <c>TERMINATING</c>. When completed, the server process
        /// that was hosting the game session has been stopped and replaced with a new server
        /// process that's ready to host a new game session. The old game session's status is
        /// changed to <c>TERMINATED</c> with a status reason that indicates the termination method
        /// used.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html">Add
        /// Amazon GameLift Servers to your game server</a> 
        /// </para>
        ///  
        /// <para>
        /// Amazon GameLift Servers server SDK 5 reference guide for <c>OnProcessTerminate()</c>
        /// (<a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/integration-server-sdk5-cpp-initsdk.html">C++</a>)
        /// (<a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/integration-server-sdk5-csharp-initsdk.html">C#</a>)
        /// (<a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/integration-server-sdk5-unreal-initsdk.html">Unreal</a>)
        /// (<a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/integration-server-sdk-go-initsdk.html">Go</a>)
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateGameSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateGameSession service method, as returned by GameLift.</returns>
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotReadyException">
        /// The operation failed because Amazon GameLift Servers has not yet finished validating
        /// this compute. We recommend attempting 8 to 10 retries over 3 to 5 minutes with <a
        /// href="http://aws.amazon.com/blogs/https:/aws.amazon.com/blogs/architecture/exponential-backoff-and-jitter/">exponential
        /// backoffs and jitter</a>.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/TerminateGameSession">REST API Reference for TerminateGameSession Operation</seealso>
        public virtual Task<TerminateGameSessionResponse> TerminateGameSessionAsync(TerminateGameSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TerminateGameSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateGameSessionResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateGameSessionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes a tag assigned to a Amazon GameLift Servers resource. You can use resource
        /// tags to organize Amazon Web Services resources for a range of purposes. This operation
        /// handles the permissions necessary to manage tags for Amazon GameLift Servers resources
        /// that support tagging.
        /// 
        ///  
        /// <para>
        /// To remove a tag from a resource, specify the unique ARN value for the resource and
        /// provide a string list containing one or more tags to remove. This operation succeeds
        /// even if the list includes tags that aren't assigned to the resource.
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TaggingFailedException">
        /// The requested tagging operation did not succeed. This may be due to invalid tag format
        /// or the maximum tag limit may have been exceeded. Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAlias

        internal virtual UpdateAliasResponse UpdateAlias(UpdateAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateAliasResponse>(request, options);
        }



        /// <summary>
        /// Updates properties for an alias. Specify the unique identifier of the alias to be
        /// updated and the new property values. When reassigning an alias to a new fleet, provide
        /// an updated routing strategy. If successful, the updated alias record is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateBuild

        internal virtual UpdateBuildResponse UpdateBuild(UpdateBuildRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateBuild">REST API Reference for UpdateBuild Operation</seealso>
        public virtual Task<UpdateBuildResponse> UpdateBuildAsync(UpdateBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBuildResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBuildResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateContainerFleet

        internal virtual UpdateContainerFleetResponse UpdateContainerFleet(UpdateContainerFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateContainerFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContainerFleetResponseUnmarshaller.Instance;

            return Invoke<UpdateContainerFleetResponse>(request, options);
        }



        /// <summary>
        /// Updates the properties of a managed container fleet. Depending on the properties being
        /// updated, this operation might initiate a fleet deployment. You can track deployments
        /// for a fleet using <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetDeployment.html">https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetDeployment.html</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Request options</b> 
        /// </para>
        ///  
        /// <para>
        /// As with CreateContainerFleet, many fleet properties use common defaults or are calculated
        /// based on the fleet's container group definitions. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Update fleet properties that result in a fleet deployment. Include only those properties
        /// that you want to change. Specify deployment configuration settings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update fleet properties that don't result in a fleet deployment. Include only those
        /// properties that you want to change.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Changes to the following properties initiate a fleet deployment: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>GameServerContainerGroupDefinition</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PerInstanceContainerGroupDefinition</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GameServerContainerGroupsPerInstance</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InstanceInboundPermissions</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InstanceConnectionPortRange</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LogConfiguration</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Results</b> 
        /// </para>
        ///  
        /// <para>
        /// If successful, this operation updates the container fleet resource, and might initiate
        /// a new deployment of fleet resources using the deployment configuration provided. A
        /// deployment replaces existing fleet instances with new instances that are deployed
        /// with the updated fleet properties. The fleet is placed in <c>UPDATING</c> status until
        /// the deployment is complete, then return to <c>ACTIVE</c>. 
        /// </para>
        ///  
        /// <para>
        /// You can have only one update deployment active at a time for a fleet. If a second
        /// update request initiates a deployment while another deployment is in progress, the
        /// first deployment is cancelled.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContainerFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContainerFleet service method, as returned by GameLift.</returns>
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotReadyException">
        /// The operation failed because Amazon GameLift Servers has not yet finished validating
        /// this compute. We recommend attempting 8 to 10 retries over 3 to 5 minutes with <a
        /// href="http://aws.amazon.com/blogs/https:/aws.amazon.com/blogs/architecture/exponential-backoff-and-jitter/">exponential
        /// backoffs and jitter</a>.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateContainerFleet">REST API Reference for UpdateContainerFleet Operation</seealso>
        public virtual Task<UpdateContainerFleetResponse> UpdateContainerFleetAsync(UpdateContainerFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateContainerFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContainerFleetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateContainerFleetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateContainerGroupDefinition

        internal virtual UpdateContainerGroupDefinitionResponse UpdateContainerGroupDefinition(UpdateContainerGroupDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateContainerGroupDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContainerGroupDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateContainerGroupDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Updates properties in an existing container group definition. This operation doesn't
        /// replace the definition. Instead, it creates a new version of the definition and saves
        /// it separately. You can access all versions that you choose to retain.
        /// 
        ///  
        /// <para>
        /// The only property you can't update is the container group type.
        /// </para>
        ///  
        /// <para>
        ///  <b>Request options:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Update based on the latest version of the container group definition. Specify the
        /// container group definition name only, or use an ARN value without a version number.
        /// Provide updated values for the properties that you want to change only. All other
        /// values remain the same as the latest version.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update based on a specific version of the container group definition. Specify the
        /// container group definition name and a source version number, or use an ARN value with
        /// a version number. Provide updated values for the properties that you want to change
        /// only. All other values remain the same as the source version.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change a game server container definition. Provide the updated container definition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add or change a support container definition. Provide a complete set of container
        /// definitions, including the updated definition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Remove a support container definition. Provide a complete set of container definitions,
        /// excluding the definition to remove. If the container group has only one support container
        /// definition, provide an empty set.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Results:</b> 
        /// </para>
        ///  
        /// <para>
        /// If successful, this operation returns the complete properties of the new container
        /// group definition version.
        /// </para>
        ///  
        /// <para>
        /// If the container group definition version is used in an active fleets, the update
        /// automatically initiates a new fleet deployment of the new version. You can track a
        /// fleet's deployments using <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ListFleetDeployments.html">ListFleetDeployments</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContainerGroupDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContainerGroupDefinition service method, as returned by GameLift.</returns>
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateContainerGroupDefinition">REST API Reference for UpdateContainerGroupDefinition Operation</seealso>
        public virtual Task<UpdateContainerGroupDefinitionResponse> UpdateContainerGroupDefinitionAsync(UpdateContainerGroupDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateContainerGroupDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContainerGroupDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateContainerGroupDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFleetAttributes

        internal virtual UpdateFleetAttributesResponse UpdateFleetAttributes(UpdateFleetAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFleetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetAttributesResponse>(request, options);
        }



        /// <summary>
        /// Updates a fleet's mutable attributes, such as game session protection and resource
        /// creation limits.
        /// 
        ///  
        /// <para>
        /// To update fleet attributes, specify the fleet ID and the property values that you
        /// want to change. If successful, Amazon GameLift Servers returns the identifiers for
        /// the updated fleet.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up Amazon GameLift Servers fleets</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetAttributes">REST API Reference for UpdateFleetAttributes Operation</seealso>
        public virtual Task<UpdateFleetAttributesResponse> UpdateFleetAttributesAsync(UpdateFleetAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFleetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFleetAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFleetCapacity

        internal virtual UpdateFleetCapacityResponse UpdateFleetCapacity(UpdateFleetCapacityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFleetCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetCapacityResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetCapacityResponse>(request, options);
        }



        /// <summary>
        /// Updates capacity settings for a managed EC2 fleet or managed container fleet. For
        /// these fleets, you adjust capacity by changing the number of instances in the fleet.
        /// Fleet capacity determines the number of game sessions and players that the fleet can
        /// host based on its configuration. For fleets with multiple locations, use this operation
        /// to manage capacity settings in each location individually.
        /// 
        ///  
        /// <para>
        /// Use this operation to set these fleet capacity properties: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Minimum/maximum size: Set hard limits on the number of Amazon EC2 instances allowed.
        /// If Amazon GameLift Servers receives a request--either through manual update or automatic
        /// scaling--it won't change the capacity to a value outside of this range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Desired capacity: As an alternative to automatic scaling, manually set the number
        /// of Amazon EC2 instances to be maintained. Before changing a fleet's desired capacity,
        /// check the maximum capacity of the fleet's Amazon EC2 instance type by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeEC2InstanceLimits.html">DescribeEC2InstanceLimits</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To update capacity for a fleet's home Region, or if the fleet has no remote locations,
        /// omit the <c>Location</c> parameter. The fleet must be in <c>ACTIVE</c> status. 
        /// </para>
        ///  
        /// <para>
        /// To update capacity for a fleet's remote location, set the <c>Location</c> parameter
        /// to the location to update. The location must be in <c>ACTIVE</c> status.
        /// </para>
        ///  
        /// <para>
        /// If successful, Amazon GameLift Servers updates the capacity settings and returns the
        /// identifiers for the updated fleet and/or location. If a requested change to desired
        /// capacity exceeds the instance type's limit, the <c>LimitExceeded</c> exception occurs.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Updates often prompt an immediate change in fleet capacity, such as when current capacity
        /// is different than the new desired capacity or outside the new limits. In this scenario,
        /// Amazon GameLift Servers automatically initiates steps to add or remove instances in
        /// the fleet location. You can track a fleet's current capacity by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetCapacity.html">DescribeFleetCapacity</a>
        /// or <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetLocationCapacity.html">DescribeFleetLocationCapacity</a>.
        /// 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFleetCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetCapacityResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFleetCapacityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFleetPortSettings

        internal virtual UpdateFleetPortSettingsResponse UpdateFleetPortSettings(UpdateFleetPortSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFleetPortSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetPortSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetPortSettingsResponse>(request, options);
        }



        /// <summary>
        /// Updates permissions that allow inbound traffic to connect to game sessions in the
        /// fleet. 
        /// 
        ///  
        /// <para>
        /// To update settings, specify the fleet ID to be updated and specify the changes to
        /// be made. List the permissions you want to add in <c>InboundPermissionAuthorizations</c>,
        /// and permissions you want to remove in <c>InboundPermissionRevocations</c>. Permissions
        /// to be removed must match existing fleet permissions. 
        /// </para>
        ///  
        /// <para>
        /// If successful, the fleet ID for the updated fleet is returned. For fleets with remote
        /// locations, port setting updates can take time to propagate across all locations. You
        /// can check the status of updates in each location by calling <c>DescribeFleetPortSettings</c>
        /// with a location name.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up Amazon GameLift Servers fleets</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetPortSettings">REST API Reference for UpdateFleetPortSettings Operation</seealso>
        public virtual Task<UpdateFleetPortSettingsResponse> UpdateFleetPortSettingsAsync(UpdateFleetPortSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFleetPortSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetPortSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFleetPortSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateGameServer

        internal virtual UpdateGameServerResponse UpdateGameServer(UpdateGameServerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameServerResponseUnmarshaller.Instance;

            return Invoke<UpdateGameServerResponse>(request, options);
        }



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift Servers FleetIQ solution and game
        /// server groups.</b> 
        /// 
        ///  
        /// <para>
        /// Updates information about a registered game server to help Amazon GameLift Servers
        /// FleetIQ track game server availability. This operation is called by a game server
        /// process that is running on an instance in a game server group. 
        /// </para>
        ///  
        /// <para>
        /// Use this operation to update the following types of game server information. You can
        /// make all three types of updates in the same request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To update the game server's utilization status from <c>AVAILABLE</c> (when the game
        /// server is available to be claimed) to <c>UTILIZED</c> (when the game server is currently
        /// hosting games). Identify the game server and game server group and specify the new
        /// utilization status. You can't change the status from to <c>UTILIZED</c> to <c>AVAILABLE</c>
        /// .
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To report health status, identify the game server and game server group and set health
        /// check to <c>HEALTHY</c>. If a game server does not report health status for a certain
        /// length of time, the game server is no longer considered healthy. As a result, it will
        /// be eventually deregistered from the game server group to avoid affecting utilization
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
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">Amazon
        /// GameLift Servers FleetIQ Guide</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameServer">REST API Reference for UpdateGameServer Operation</seealso>
        public virtual Task<UpdateGameServerResponse> UpdateGameServerAsync(UpdateGameServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGameServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameServerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGameServerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateGameServerGroup

        internal virtual UpdateGameServerGroupResponse UpdateGameServerGroup(UpdateGameServerGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameServerGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGameServerGroupResponse>(request, options);
        }



        /// <summary>
        /// <b>This operation is used with the Amazon GameLift Servers FleetIQ solution and game
        /// server groups.</b> 
        /// 
        ///  
        /// <para>
        /// Updates Amazon GameLift Servers FleetIQ-specific properties for a game server group.
        /// Many Auto Scaling group properties are updated on the Auto Scaling group directly,
        /// including the launch template, Auto Scaling policies, and maximum/minimum/desired
        /// instance counts.
        /// </para>
        ///  
        /// <para>
        /// To update the game server group, specify the game server group ID and provide the
        /// updated values. Before applying the updates, the new values are validated to ensure
        /// that Amazon GameLift Servers FleetIQ can continue to perform instance balancing activity.
        /// If successful, a <c>GameServerGroup</c> object is returned.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">Amazon
        /// GameLift Servers FleetIQ Guide</a> 
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameServerGroup">REST API Reference for UpdateGameServerGroup Operation</seealso>
        public virtual Task<UpdateGameServerGroupResponse> UpdateGameServerGroupAsync(UpdateGameServerGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGameServerGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameServerGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGameServerGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateGameSession

        internal virtual UpdateGameSessionResponse UpdateGameSession(UpdateGameSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// If successful, the updated <c>GameSession</c> object is returned. 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameSession">REST API Reference for UpdateGameSession Operation</seealso>
        public virtual Task<UpdateGameSessionResponse> UpdateGameSessionAsync(UpdateGameSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGameSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameSessionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGameSessionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateGameSessionQueue

        internal virtual UpdateGameSessionQueueResponse UpdateGameSessionQueue(UpdateGameSessionQueueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameSessionQueue">REST API Reference for UpdateGameSessionQueue Operation</seealso>
        public virtual Task<UpdateGameSessionQueueResponse> UpdateGameSessionQueueAsync(UpdateGameSessionQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameSessionQueueResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGameSessionQueueResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateMatchmakingConfiguration

        internal virtual UpdateMatchmakingConfigurationResponse UpdateMatchmakingConfiguration(UpdateMatchmakingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnsupportedRegionException">
        /// The requested operation is not supported in the Region specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateMatchmakingConfiguration">REST API Reference for UpdateMatchmakingConfiguration Operation</seealso>
        public virtual Task<UpdateMatchmakingConfigurationResponse> UpdateMatchmakingConfigurationAsync(UpdateMatchmakingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMatchmakingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMatchmakingConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRuntimeConfiguration

        internal virtual UpdateRuntimeConfigurationResponse UpdateRuntimeConfiguration(UpdateRuntimeConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuntimeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuntimeConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateRuntimeConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates the runtime configuration for the specified fleet. The runtime configuration
        /// tells Amazon GameLift Servers how to launch server processes on computes in managed
        /// EC2 and Anywhere fleets. You can update a fleet's runtime configuration at any time
        /// after the fleet is created; it does not need to be in <c>ACTIVE</c> status.
        /// 
        ///  
        /// <para>
        /// To update runtime configuration, specify the fleet ID and provide a <c>RuntimeConfiguration</c>
        /// with an updated set of server process configurations.
        /// </para>
        ///  
        /// <para>
        /// If successful, the fleet's runtime configuration settings are updated. Fleet computes
        /// that run game server processes regularly check for and receive updated runtime configurations.
        /// The computes immediately take action to comply with the new configuration by launching
        /// new server processes or by not replacing existing processes when they shut down. Updating
        /// a fleet's runtime configuration never affects existing server processes.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
        /// up Amazon GameLift Servers fleets</a> 
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
        /// <exception cref="Amazon.GameLift.Model.LimitExceededException">
        /// The requested operation would cause the resource to exceed the allowed service limit.
        /// Resolve the issue before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateRuntimeConfiguration">REST API Reference for UpdateRuntimeConfiguration Operation</seealso>
        public virtual Task<UpdateRuntimeConfigurationResponse> UpdateRuntimeConfigurationAsync(UpdateRuntimeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuntimeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuntimeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRuntimeConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateScript

        internal virtual UpdateScriptResponse UpdateScript(UpdateScriptRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// a revised script is uploaded to the Amazon GameLift Servers service. Once the script
        /// is updated and acquired by a fleet instance, the new version is used for all new game
        /// sessions. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
        /// GameLift Servers Amazon GameLift Servers Realtime</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related actions</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
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
        /// The requested resources was not found. The resource was either not created yet or
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateScript">REST API Reference for UpdateScript Operation</seealso>
        public virtual Task<UpdateScriptResponse> UpdateScriptAsync(UpdateScriptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScriptResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateScriptResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ValidateMatchmakingRuleSet

        internal virtual ValidateMatchmakingRuleSetResponse ValidateMatchmakingRuleSet(ValidateMatchmakingRuleSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ValidateMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateMatchmakingRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<ValidateMatchmakingRuleSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}