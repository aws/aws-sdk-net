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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.GameLift.Model;
using Amazon.GameLift.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.GameLift
{
    /// <summary>
    /// Implementation for accessing GameLift
    ///
    /// Amazon GameLift Service 
    /// <para>
    ///  Amazon GameLift is a managed service for developers who need a scalable, dedicated
    /// server solution for their multiplayer games. Amazon GameLift provides tools for the
    /// following tasks: (1) acquire computing resources and deploy game servers, (2) scale
    /// game server capacity to meet player demand, (3) host game sessions and manage player
    /// access, and (4) track in-depth metrics on player usage and server performance.
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
    /// and aliases; set autoscaling policies; retrieve logs and metrics.
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
    ///  <b>MORE RESOURCES</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/">Amazon GameLift
    /// Developer Guide</a> -- Learn more about Amazon GameLift features and how to use them.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://gamedev.amazon.com/forums/tutorials">Lumberyard and Amazon GameLift
    /// Tutorials</a> -- Get started fast with walkthroughs and sample projects.
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
    ///  <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/doc-history.html">Amazon
    /// GameLift Document History</a> -- See changes to the Amazon GameLift service, SDKs,
    /// and documentation, as well as links to release notes. 
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
    ///  <b>Start new game sessions with FlexMatch matchmaking</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>StartMatchmaking</a> -- Request matchmaking for one players or a group who want
    /// to play together. 
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
    /// (Update uploading permissions with <a>RequestUploadCredentials</a>.) To create a build
    /// and upload files from a local path, use the AWS CLI command <code>upload-build</code>.
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
    /// Autoscale -- Manage autoscaling rules and apply them to a fleet.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>PutScalingPolicy</a> -- Create a new autoscaling policy, or update an existing
    /// one.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeScalingPolicies</a> -- Retrieve an existing autoscaling policy.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteScalingPolicy</a> -- Delete an autoscaling policy and stop it from affecting
    /// a fleet's capacity.
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
    public partial class AmazonGameLiftClient : AmazonServiceClient, IAmazonGameLift
    {
        
        #region Constructors

#if CORECLR
    
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

#endif

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

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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
            var marshaller = new AcceptMatchRequestMarshaller();
            var unmarshaller = AcceptMatchResponseUnmarshaller.Instance;

            return Invoke<AcceptMatchRequest,AcceptMatchResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<AcceptMatchResponse> AcceptMatchAsync(AcceptMatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AcceptMatchRequestMarshaller();
            var unmarshaller = AcceptMatchResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptMatchRequest,AcceptMatchResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAlias

        internal virtual CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var marshaller = new CreateAliasRequestMarshaller();
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasRequest,CreateAliasResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAliasRequestMarshaller();
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAliasRequest,CreateAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateBuild

        internal virtual CreateBuildResponse CreateBuild(CreateBuildRequest request)
        {
            var marshaller = new CreateBuildRequestMarshaller();
            var unmarshaller = CreateBuildResponseUnmarshaller.Instance;

            return Invoke<CreateBuildRequest,CreateBuildResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<CreateBuildResponse> CreateBuildAsync(CreateBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateBuildRequestMarshaller();
            var unmarshaller = CreateBuildResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBuildRequest,CreateBuildResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateFleet

        internal virtual CreateFleetResponse CreateFleet(CreateFleetRequest request)
        {
            var marshaller = new CreateFleetRequestMarshaller();
            var unmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return Invoke<CreateFleetRequest,CreateFleetResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateFleetRequestMarshaller();
            var unmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFleetRequest,CreateFleetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateGameSession

        internal virtual CreateGameSessionResponse CreateGameSession(CreateGameSessionRequest request)
        {
            var marshaller = new CreateGameSessionRequestMarshaller();
            var unmarshaller = CreateGameSessionResponseUnmarshaller.Instance;

            return Invoke<CreateGameSessionRequest,CreateGameSessionResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<CreateGameSessionResponse> CreateGameSessionAsync(CreateGameSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateGameSessionRequestMarshaller();
            var unmarshaller = CreateGameSessionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGameSessionRequest,CreateGameSessionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateGameSessionQueue

        internal virtual CreateGameSessionQueueResponse CreateGameSessionQueue(CreateGameSessionQueueRequest request)
        {
            var marshaller = new CreateGameSessionQueueRequestMarshaller();
            var unmarshaller = CreateGameSessionQueueResponseUnmarshaller.Instance;

            return Invoke<CreateGameSessionQueueRequest,CreateGameSessionQueueResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<CreateGameSessionQueueResponse> CreateGameSessionQueueAsync(CreateGameSessionQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateGameSessionQueueRequestMarshaller();
            var unmarshaller = CreateGameSessionQueueResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGameSessionQueueRequest,CreateGameSessionQueueResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateMatchmakingConfiguration

        internal virtual CreateMatchmakingConfigurationResponse CreateMatchmakingConfiguration(CreateMatchmakingConfigurationRequest request)
        {
            var marshaller = new CreateMatchmakingConfigurationRequestMarshaller();
            var unmarshaller = CreateMatchmakingConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateMatchmakingConfigurationRequest,CreateMatchmakingConfigurationResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<CreateMatchmakingConfigurationResponse> CreateMatchmakingConfigurationAsync(CreateMatchmakingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateMatchmakingConfigurationRequestMarshaller();
            var unmarshaller = CreateMatchmakingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMatchmakingConfigurationRequest,CreateMatchmakingConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateMatchmakingRuleSet

        internal virtual CreateMatchmakingRuleSetResponse CreateMatchmakingRuleSet(CreateMatchmakingRuleSetRequest request)
        {
            var marshaller = new CreateMatchmakingRuleSetRequestMarshaller();
            var unmarshaller = CreateMatchmakingRuleSetResponseUnmarshaller.Instance;

            return Invoke<CreateMatchmakingRuleSetRequest,CreateMatchmakingRuleSetResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<CreateMatchmakingRuleSetResponse> CreateMatchmakingRuleSetAsync(CreateMatchmakingRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateMatchmakingRuleSetRequestMarshaller();
            var unmarshaller = CreateMatchmakingRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMatchmakingRuleSetRequest,CreateMatchmakingRuleSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePlayerSession

        internal virtual CreatePlayerSessionResponse CreatePlayerSession(CreatePlayerSessionRequest request)
        {
            var marshaller = new CreatePlayerSessionRequestMarshaller();
            var unmarshaller = CreatePlayerSessionResponseUnmarshaller.Instance;

            return Invoke<CreatePlayerSessionRequest,CreatePlayerSessionResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<CreatePlayerSessionResponse> CreatePlayerSessionAsync(string gameSessionId, string playerId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreatePlayerSessionRequest();
            request.GameSessionId = gameSessionId;
            request.PlayerId = playerId;
            return CreatePlayerSessionAsync(request, cancellationToken);
        }


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
        public virtual Task<CreatePlayerSessionResponse> CreatePlayerSessionAsync(CreatePlayerSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePlayerSessionRequestMarshaller();
            var unmarshaller = CreatePlayerSessionResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePlayerSessionRequest,CreatePlayerSessionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePlayerSessions

        internal virtual CreatePlayerSessionsResponse CreatePlayerSessions(CreatePlayerSessionsRequest request)
        {
            var marshaller = new CreatePlayerSessionsRequestMarshaller();
            var unmarshaller = CreatePlayerSessionsResponseUnmarshaller.Instance;

            return Invoke<CreatePlayerSessionsRequest,CreatePlayerSessionsResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<CreatePlayerSessionsResponse> CreatePlayerSessionsAsync(string gameSessionId, List<string> playerIds, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreatePlayerSessionsRequest();
            request.GameSessionId = gameSessionId;
            request.PlayerIds = playerIds;
            return CreatePlayerSessionsAsync(request, cancellationToken);
        }


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
        public virtual Task<CreatePlayerSessionsResponse> CreatePlayerSessionsAsync(CreatePlayerSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePlayerSessionsRequestMarshaller();
            var unmarshaller = CreatePlayerSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePlayerSessionsRequest,CreatePlayerSessionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcPeeringAuthorization

        internal virtual CreateVpcPeeringAuthorizationResponse CreateVpcPeeringAuthorization(CreateVpcPeeringAuthorizationRequest request)
        {
            var marshaller = new CreateVpcPeeringAuthorizationRequestMarshaller();
            var unmarshaller = CreateVpcPeeringAuthorizationResponseUnmarshaller.Instance;

            return Invoke<CreateVpcPeeringAuthorizationRequest,CreateVpcPeeringAuthorizationResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<CreateVpcPeeringAuthorizationResponse> CreateVpcPeeringAuthorizationAsync(CreateVpcPeeringAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVpcPeeringAuthorizationRequestMarshaller();
            var unmarshaller = CreateVpcPeeringAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcPeeringAuthorizationRequest,CreateVpcPeeringAuthorizationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcPeeringConnection

        internal virtual CreateVpcPeeringConnectionResponse CreateVpcPeeringConnection(CreateVpcPeeringConnectionRequest request)
        {
            var marshaller = new CreateVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateVpcPeeringConnectionRequest,CreateVpcPeeringConnectionResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<CreateVpcPeeringConnectionResponse> CreateVpcPeeringConnectionAsync(CreateVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcPeeringConnectionRequest,CreateVpcPeeringConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAlias

        internal virtual DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
        {
            var marshaller = new DeleteAliasRequestMarshaller();
            var unmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAliasRequest,DeleteAliasResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DeleteAliasResponse> DeleteAliasAsync(string aliasId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteAliasRequest();
            request.AliasId = aliasId;
            return DeleteAliasAsync(request, cancellationToken);
        }


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
        public virtual Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAliasRequestMarshaller();
            var unmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAliasRequest,DeleteAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBuild

        internal virtual DeleteBuildResponse DeleteBuild(DeleteBuildRequest request)
        {
            var marshaller = new DeleteBuildRequestMarshaller();
            var unmarshaller = DeleteBuildResponseUnmarshaller.Instance;

            return Invoke<DeleteBuildRequest,DeleteBuildResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DeleteBuildResponse> DeleteBuildAsync(string buildId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteBuildRequest();
            request.BuildId = buildId;
            return DeleteBuildAsync(request, cancellationToken);
        }


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
        public virtual Task<DeleteBuildResponse> DeleteBuildAsync(DeleteBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBuildRequestMarshaller();
            var unmarshaller = DeleteBuildResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBuildRequest,DeleteBuildResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteFleet

        internal virtual DeleteFleetResponse DeleteFleet(DeleteFleetRequest request)
        {
            var marshaller = new DeleteFleetRequestMarshaller();
            var unmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetRequest,DeleteFleetResponse>(request, marshaller, unmarshaller);
        }


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
        /// Describe fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
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
        /// Manage fleet capacity:
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
        ///  <a>PutScalingPolicy</a> (automatic scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScalingPolicies</a> (automatic scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScalingPolicy</a> (automatic scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> </ul>
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
        public virtual Task<DeleteFleetResponse> DeleteFleetAsync(string fleetId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteFleetRequest();
            request.FleetId = fleetId;
            return DeleteFleetAsync(request, cancellationToken);
        }


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
        public virtual Task<DeleteFleetResponse> DeleteFleetAsync(DeleteFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteFleetRequestMarshaller();
            var unmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFleetRequest,DeleteFleetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteGameSessionQueue

        internal virtual DeleteGameSessionQueueResponse DeleteGameSessionQueue(DeleteGameSessionQueueRequest request)
        {
            var marshaller = new DeleteGameSessionQueueRequestMarshaller();
            var unmarshaller = DeleteGameSessionQueueResponseUnmarshaller.Instance;

            return Invoke<DeleteGameSessionQueueRequest,DeleteGameSessionQueueResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DeleteGameSessionQueueResponse> DeleteGameSessionQueueAsync(DeleteGameSessionQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteGameSessionQueueRequestMarshaller();
            var unmarshaller = DeleteGameSessionQueueResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGameSessionQueueRequest,DeleteGameSessionQueueResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteMatchmakingConfiguration

        internal virtual DeleteMatchmakingConfigurationResponse DeleteMatchmakingConfiguration(DeleteMatchmakingConfigurationRequest request)
        {
            var marshaller = new DeleteMatchmakingConfigurationRequestMarshaller();
            var unmarshaller = DeleteMatchmakingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteMatchmakingConfigurationRequest,DeleteMatchmakingConfigurationResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DeleteMatchmakingConfigurationResponse> DeleteMatchmakingConfigurationAsync(DeleteMatchmakingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteMatchmakingConfigurationRequestMarshaller();
            var unmarshaller = DeleteMatchmakingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMatchmakingConfigurationRequest,DeleteMatchmakingConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteScalingPolicy

        internal virtual DeleteScalingPolicyResponse DeleteScalingPolicy(DeleteScalingPolicyRequest request)
        {
            var marshaller = new DeleteScalingPolicyRequestMarshaller();
            var unmarshaller = DeleteScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteScalingPolicyRequest,DeleteScalingPolicyResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DeleteScalingPolicyResponse> DeleteScalingPolicyAsync(DeleteScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteScalingPolicyRequestMarshaller();
            var unmarshaller = DeleteScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScalingPolicyRequest,DeleteScalingPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcPeeringAuthorization

        internal virtual DeleteVpcPeeringAuthorizationResponse DeleteVpcPeeringAuthorization(DeleteVpcPeeringAuthorizationRequest request)
        {
            var marshaller = new DeleteVpcPeeringAuthorizationRequestMarshaller();
            var unmarshaller = DeleteVpcPeeringAuthorizationResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcPeeringAuthorizationRequest,DeleteVpcPeeringAuthorizationResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DeleteVpcPeeringAuthorizationResponse> DeleteVpcPeeringAuthorizationAsync(DeleteVpcPeeringAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVpcPeeringAuthorizationRequestMarshaller();
            var unmarshaller = DeleteVpcPeeringAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcPeeringAuthorizationRequest,DeleteVpcPeeringAuthorizationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcPeeringConnection

        internal virtual DeleteVpcPeeringConnectionResponse DeleteVpcPeeringConnection(DeleteVpcPeeringConnectionRequest request)
        {
            var marshaller = new DeleteVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcPeeringConnectionRequest,DeleteVpcPeeringConnectionResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DeleteVpcPeeringConnectionResponse> DeleteVpcPeeringConnectionAsync(DeleteVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcPeeringConnectionRequest,DeleteVpcPeeringConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAlias

        internal virtual DescribeAliasResponse DescribeAlias(DescribeAliasRequest request)
        {
            var marshaller = new DescribeAliasRequestMarshaller();
            var unmarshaller = DescribeAliasResponseUnmarshaller.Instance;

            return Invoke<DescribeAliasRequest,DescribeAliasResponse>(request, marshaller, unmarshaller);
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
        public virtual Task<DescribeAliasResponse> DescribeAliasAsync(string aliasId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeAliasRequest();
            request.AliasId = aliasId;
            return DescribeAliasAsync(request, cancellationToken);
        }


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
        public virtual Task<DescribeAliasResponse> DescribeAliasAsync(DescribeAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAliasRequestMarshaller();
            var unmarshaller = DescribeAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAliasRequest,DescribeAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeBuild

        internal virtual DescribeBuildResponse DescribeBuild(DescribeBuildRequest request)
        {
            var marshaller = new DescribeBuildRequestMarshaller();
            var unmarshaller = DescribeBuildResponseUnmarshaller.Instance;

            return Invoke<DescribeBuildRequest,DescribeBuildResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieves properties for a build. To get a build record, specify a build ID. If successful,
        /// an object containing the build properties is returned.
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
        public virtual Task<DescribeBuildResponse> DescribeBuildAsync(string buildId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeBuildRequest();
            request.BuildId = buildId;
            return DescribeBuildAsync(request, cancellationToken);
        }


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
        public virtual Task<DescribeBuildResponse> DescribeBuildAsync(DescribeBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeBuildRequestMarshaller();
            var unmarshaller = DescribeBuildResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBuildRequest,DescribeBuildResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEC2InstanceLimits

        internal virtual DescribeEC2InstanceLimitsResponse DescribeEC2InstanceLimits(DescribeEC2InstanceLimitsRequest request)
        {
            var marshaller = new DescribeEC2InstanceLimitsRequestMarshaller();
            var unmarshaller = DescribeEC2InstanceLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeEC2InstanceLimitsRequest,DescribeEC2InstanceLimitsResponse>(request, marshaller, unmarshaller);
        }


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
        /// Describe fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
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
        /// Manage fleet capacity:
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
        ///  <a>PutScalingPolicy</a> (automatic scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScalingPolicies</a> (automatic scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScalingPolicy</a> (automatic scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
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
        public virtual Task<DescribeEC2InstanceLimitsResponse> DescribeEC2InstanceLimitsAsync(EC2InstanceType ec2InstanceType, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeEC2InstanceLimitsRequest();
            request.EC2InstanceType = ec2InstanceType;
            return DescribeEC2InstanceLimitsAsync(request, cancellationToken);
        }


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
        public virtual Task<DescribeEC2InstanceLimitsResponse> DescribeEC2InstanceLimitsAsync(DescribeEC2InstanceLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEC2InstanceLimitsRequestMarshaller();
            var unmarshaller = DescribeEC2InstanceLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEC2InstanceLimitsRequest,DescribeEC2InstanceLimitsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetAttributes

        internal virtual DescribeFleetAttributesResponse DescribeFleetAttributes(DescribeFleetAttributesRequest request)
        {
            var marshaller = new DescribeFleetAttributesRequestMarshaller();
            var unmarshaller = DescribeFleetAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetAttributesRequest,DescribeFleetAttributesResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DescribeFleetAttributesResponse> DescribeFleetAttributesAsync(DescribeFleetAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeFleetAttributesRequestMarshaller();
            var unmarshaller = DescribeFleetAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetAttributesRequest,DescribeFleetAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetCapacity

        internal virtual DescribeFleetCapacityResponse DescribeFleetCapacity(DescribeFleetCapacityRequest request)
        {
            var marshaller = new DescribeFleetCapacityRequestMarshaller();
            var unmarshaller = DescribeFleetCapacityResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetCapacityRequest,DescribeFleetCapacityResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DescribeFleetCapacityResponse> DescribeFleetCapacityAsync(DescribeFleetCapacityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeFleetCapacityRequestMarshaller();
            var unmarshaller = DescribeFleetCapacityResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetCapacityRequest,DescribeFleetCapacityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetEvents

        internal virtual DescribeFleetEventsResponse DescribeFleetEvents(DescribeFleetEventsRequest request)
        {
            var marshaller = new DescribeFleetEventsRequestMarshaller();
            var unmarshaller = DescribeFleetEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetEventsRequest,DescribeFleetEventsResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DescribeFleetEventsResponse> DescribeFleetEventsAsync(DescribeFleetEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeFleetEventsRequestMarshaller();
            var unmarshaller = DescribeFleetEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetEventsRequest,DescribeFleetEventsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetPortSettings

        internal virtual DescribeFleetPortSettingsResponse DescribeFleetPortSettings(DescribeFleetPortSettingsRequest request)
        {
            var marshaller = new DescribeFleetPortSettingsRequestMarshaller();
            var unmarshaller = DescribeFleetPortSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetPortSettingsRequest,DescribeFleetPortSettingsResponse>(request, marshaller, unmarshaller);
        }


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
        /// Describe fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
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
        /// Manage fleet capacity:
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
        ///  <a>PutScalingPolicy</a> (automatic scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeScalingPolicies</a> (automatic scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteScalingPolicy</a> (automatic scaling)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> </ul>
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
        public virtual Task<DescribeFleetPortSettingsResponse> DescribeFleetPortSettingsAsync(string fleetId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeFleetPortSettingsRequest();
            request.FleetId = fleetId;
            return DescribeFleetPortSettingsAsync(request, cancellationToken);
        }


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
        public virtual Task<DescribeFleetPortSettingsResponse> DescribeFleetPortSettingsAsync(DescribeFleetPortSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeFleetPortSettingsRequestMarshaller();
            var unmarshaller = DescribeFleetPortSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetPortSettingsRequest,DescribeFleetPortSettingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetUtilization

        internal virtual DescribeFleetUtilizationResponse DescribeFleetUtilization(DescribeFleetUtilizationRequest request)
        {
            var marshaller = new DescribeFleetUtilizationRequestMarshaller();
            var unmarshaller = DescribeFleetUtilizationResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetUtilizationRequest,DescribeFleetUtilizationResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DescribeFleetUtilizationResponse> DescribeFleetUtilizationAsync(DescribeFleetUtilizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeFleetUtilizationRequestMarshaller();
            var unmarshaller = DescribeFleetUtilizationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetUtilizationRequest,DescribeFleetUtilizationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeGameSessionDetails

        internal virtual DescribeGameSessionDetailsResponse DescribeGameSessionDetails(DescribeGameSessionDetailsRequest request)
        {
            var marshaller = new DescribeGameSessionDetailsRequestMarshaller();
            var unmarshaller = DescribeGameSessionDetailsResponseUnmarshaller.Instance;

            return Invoke<DescribeGameSessionDetailsRequest,DescribeGameSessionDetailsResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DescribeGameSessionDetailsResponse> DescribeGameSessionDetailsAsync(DescribeGameSessionDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeGameSessionDetailsRequestMarshaller();
            var unmarshaller = DescribeGameSessionDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameSessionDetailsRequest,DescribeGameSessionDetailsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeGameSessionPlacement

        internal virtual DescribeGameSessionPlacementResponse DescribeGameSessionPlacement(DescribeGameSessionPlacementRequest request)
        {
            var marshaller = new DescribeGameSessionPlacementRequestMarshaller();
            var unmarshaller = DescribeGameSessionPlacementResponseUnmarshaller.Instance;

            return Invoke<DescribeGameSessionPlacementRequest,DescribeGameSessionPlacementResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DescribeGameSessionPlacementResponse> DescribeGameSessionPlacementAsync(DescribeGameSessionPlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeGameSessionPlacementRequestMarshaller();
            var unmarshaller = DescribeGameSessionPlacementResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameSessionPlacementRequest,DescribeGameSessionPlacementResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeGameSessionQueues

        internal virtual DescribeGameSessionQueuesResponse DescribeGameSessionQueues(DescribeGameSessionQueuesRequest request)
        {
            var marshaller = new DescribeGameSessionQueuesRequestMarshaller();
            var unmarshaller = DescribeGameSessionQueuesResponseUnmarshaller.Instance;

            return Invoke<DescribeGameSessionQueuesRequest,DescribeGameSessionQueuesResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DescribeGameSessionQueuesResponse> DescribeGameSessionQueuesAsync(DescribeGameSessionQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeGameSessionQueuesRequestMarshaller();
            var unmarshaller = DescribeGameSessionQueuesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameSessionQueuesRequest,DescribeGameSessionQueuesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeGameSessions

        internal virtual DescribeGameSessionsResponse DescribeGameSessions(DescribeGameSessionsRequest request)
        {
            var marshaller = new DescribeGameSessionsRequestMarshaller();
            var unmarshaller = DescribeGameSessionsResponseUnmarshaller.Instance;

            return Invoke<DescribeGameSessionsRequest,DescribeGameSessionsResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DescribeGameSessionsResponse> DescribeGameSessionsAsync(DescribeGameSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeGameSessionsRequestMarshaller();
            var unmarshaller = DescribeGameSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameSessionsRequest,DescribeGameSessionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstances

        internal virtual DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            var marshaller = new DescribeInstancesRequestMarshaller();
            var unmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancesRequest,DescribeInstancesResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstancesRequestMarshaller();
            var unmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstancesRequest,DescribeInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeMatchmaking

        internal virtual DescribeMatchmakingResponse DescribeMatchmaking(DescribeMatchmakingRequest request)
        {
            var marshaller = new DescribeMatchmakingRequestMarshaller();
            var unmarshaller = DescribeMatchmakingResponseUnmarshaller.Instance;

            return Invoke<DescribeMatchmakingRequest,DescribeMatchmakingResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DescribeMatchmakingResponse> DescribeMatchmakingAsync(DescribeMatchmakingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeMatchmakingRequestMarshaller();
            var unmarshaller = DescribeMatchmakingResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMatchmakingRequest,DescribeMatchmakingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeMatchmakingConfigurations

        internal virtual DescribeMatchmakingConfigurationsResponse DescribeMatchmakingConfigurations(DescribeMatchmakingConfigurationsRequest request)
        {
            var marshaller = new DescribeMatchmakingConfigurationsRequestMarshaller();
            var unmarshaller = DescribeMatchmakingConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeMatchmakingConfigurationsRequest,DescribeMatchmakingConfigurationsResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DescribeMatchmakingConfigurationsResponse> DescribeMatchmakingConfigurationsAsync(DescribeMatchmakingConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeMatchmakingConfigurationsRequestMarshaller();
            var unmarshaller = DescribeMatchmakingConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMatchmakingConfigurationsRequest,DescribeMatchmakingConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeMatchmakingRuleSets

        internal virtual DescribeMatchmakingRuleSetsResponse DescribeMatchmakingRuleSets(DescribeMatchmakingRuleSetsRequest request)
        {
            var marshaller = new DescribeMatchmakingRuleSetsRequestMarshaller();
            var unmarshaller = DescribeMatchmakingRuleSetsResponseUnmarshaller.Instance;

            return Invoke<DescribeMatchmakingRuleSetsRequest,DescribeMatchmakingRuleSetsResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DescribeMatchmakingRuleSetsResponse> DescribeMatchmakingRuleSetsAsync(DescribeMatchmakingRuleSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeMatchmakingRuleSetsRequestMarshaller();
            var unmarshaller = DescribeMatchmakingRuleSetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMatchmakingRuleSetsRequest,DescribeMatchmakingRuleSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribePlayerSessions

        internal virtual DescribePlayerSessionsResponse DescribePlayerSessions(DescribePlayerSessionsRequest request)
        {
            var marshaller = new DescribePlayerSessionsRequestMarshaller();
            var unmarshaller = DescribePlayerSessionsResponseUnmarshaller.Instance;

            return Invoke<DescribePlayerSessionsRequest,DescribePlayerSessionsResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DescribePlayerSessionsResponse> DescribePlayerSessionsAsync(DescribePlayerSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribePlayerSessionsRequestMarshaller();
            var unmarshaller = DescribePlayerSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePlayerSessionsRequest,DescribePlayerSessionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRuntimeConfiguration

        internal virtual DescribeRuntimeConfigurationResponse DescribeRuntimeConfiguration(DescribeRuntimeConfigurationRequest request)
        {
            var marshaller = new DescribeRuntimeConfigurationRequestMarshaller();
            var unmarshaller = DescribeRuntimeConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeRuntimeConfigurationRequest,DescribeRuntimeConfigurationResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DescribeRuntimeConfigurationResponse> DescribeRuntimeConfigurationAsync(DescribeRuntimeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeRuntimeConfigurationRequestMarshaller();
            var unmarshaller = DescribeRuntimeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRuntimeConfigurationRequest,DescribeRuntimeConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalingPolicies

        internal virtual DescribeScalingPoliciesResponse DescribeScalingPolicies(DescribeScalingPoliciesRequest request)
        {
            var marshaller = new DescribeScalingPoliciesRequestMarshaller();
            var unmarshaller = DescribeScalingPoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingPoliciesRequest,DescribeScalingPoliciesResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DescribeScalingPoliciesResponse> DescribeScalingPoliciesAsync(DescribeScalingPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeScalingPoliciesRequestMarshaller();
            var unmarshaller = DescribeScalingPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalingPoliciesRequest,DescribeScalingPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcPeeringAuthorizations

        internal virtual DescribeVpcPeeringAuthorizationsResponse DescribeVpcPeeringAuthorizations(DescribeVpcPeeringAuthorizationsRequest request)
        {
            var marshaller = new DescribeVpcPeeringAuthorizationsRequestMarshaller();
            var unmarshaller = DescribeVpcPeeringAuthorizationsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcPeeringAuthorizationsRequest,DescribeVpcPeeringAuthorizationsResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DescribeVpcPeeringAuthorizationsResponse> DescribeVpcPeeringAuthorizationsAsync(DescribeVpcPeeringAuthorizationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpcPeeringAuthorizationsRequestMarshaller();
            var unmarshaller = DescribeVpcPeeringAuthorizationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcPeeringAuthorizationsRequest,DescribeVpcPeeringAuthorizationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcPeeringConnections

        internal virtual DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request)
        {
            var marshaller = new DescribeVpcPeeringConnectionsRequestMarshaller();
            var unmarshaller = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcPeeringConnectionsRequest,DescribeVpcPeeringConnectionsResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<DescribeVpcPeeringConnectionsResponse> DescribeVpcPeeringConnectionsAsync(DescribeVpcPeeringConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpcPeeringConnectionsRequestMarshaller();
            var unmarshaller = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcPeeringConnectionsRequest,DescribeVpcPeeringConnectionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetGameSessionLogUrl

        internal virtual GetGameSessionLogUrlResponse GetGameSessionLogUrl(GetGameSessionLogUrlRequest request)
        {
            var marshaller = new GetGameSessionLogUrlRequestMarshaller();
            var unmarshaller = GetGameSessionLogUrlResponseUnmarshaller.Instance;

            return Invoke<GetGameSessionLogUrlRequest,GetGameSessionLogUrlResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<GetGameSessionLogUrlResponse> GetGameSessionLogUrlAsync(string gameSessionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetGameSessionLogUrlRequest();
            request.GameSessionId = gameSessionId;
            return GetGameSessionLogUrlAsync(request, cancellationToken);
        }


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
        public virtual Task<GetGameSessionLogUrlResponse> GetGameSessionLogUrlAsync(GetGameSessionLogUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetGameSessionLogUrlRequestMarshaller();
            var unmarshaller = GetGameSessionLogUrlResponseUnmarshaller.Instance;

            return InvokeAsync<GetGameSessionLogUrlRequest,GetGameSessionLogUrlResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetInstanceAccess

        internal virtual GetInstanceAccessResponse GetInstanceAccess(GetInstanceAccessRequest request)
        {
            var marshaller = new GetInstanceAccessRequestMarshaller();
            var unmarshaller = GetInstanceAccessResponseUnmarshaller.Instance;

            return Invoke<GetInstanceAccessRequest,GetInstanceAccessResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<GetInstanceAccessResponse> GetInstanceAccessAsync(GetInstanceAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetInstanceAccessRequestMarshaller();
            var unmarshaller = GetInstanceAccessResponseUnmarshaller.Instance;

            return InvokeAsync<GetInstanceAccessRequest,GetInstanceAccessResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAliases

        internal virtual ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            var marshaller = new ListAliasesRequestMarshaller();
            var unmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAliasesRequest,ListAliasesResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAliasesRequestMarshaller();
            var unmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAliasesRequest,ListAliasesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListBuilds

        internal virtual ListBuildsResponse ListBuilds(ListBuildsRequest request)
        {
            var marshaller = new ListBuildsRequestMarshaller();
            var unmarshaller = ListBuildsResponseUnmarshaller.Instance;

            return Invoke<ListBuildsRequest,ListBuildsResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<ListBuildsResponse> ListBuildsAsync(ListBuildsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListBuildsRequestMarshaller();
            var unmarshaller = ListBuildsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBuildsRequest,ListBuildsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListFleets

        internal virtual ListFleetsResponse ListFleets(ListFleetsRequest request)
        {
            var marshaller = new ListFleetsRequestMarshaller();
            var unmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return Invoke<ListFleetsRequest,ListFleetsResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<ListFleetsResponse> ListFleetsAsync(ListFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListFleetsRequestMarshaller();
            var unmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFleetsRequest,ListFleetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutScalingPolicy

        internal virtual PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest request)
        {
            var marshaller = new PutScalingPolicyRequestMarshaller();
            var unmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<PutScalingPolicyRequest,PutScalingPolicyResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutScalingPolicyRequestMarshaller();
            var unmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutScalingPolicyRequest,PutScalingPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RequestUploadCredentials

        internal virtual RequestUploadCredentialsResponse RequestUploadCredentials(RequestUploadCredentialsRequest request)
        {
            var marshaller = new RequestUploadCredentialsRequestMarshaller();
            var unmarshaller = RequestUploadCredentialsResponseUnmarshaller.Instance;

            return Invoke<RequestUploadCredentialsRequest,RequestUploadCredentialsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// <i>This API call is not currently in use. </i> Retrieves a fresh set of upload credentials
        /// and the assigned Amazon S3 storage location for a specific build. Valid credentials
        /// are required to upload your game build files to Amazon S3.
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
        public virtual Task<RequestUploadCredentialsResponse> RequestUploadCredentialsAsync(string buildId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RequestUploadCredentialsRequest();
            request.BuildId = buildId;
            return RequestUploadCredentialsAsync(request, cancellationToken);
        }


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
        public virtual Task<RequestUploadCredentialsResponse> RequestUploadCredentialsAsync(RequestUploadCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RequestUploadCredentialsRequestMarshaller();
            var unmarshaller = RequestUploadCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<RequestUploadCredentialsRequest,RequestUploadCredentialsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResolveAlias

        internal virtual ResolveAliasResponse ResolveAlias(ResolveAliasRequest request)
        {
            var marshaller = new ResolveAliasRequestMarshaller();
            var unmarshaller = ResolveAliasResponseUnmarshaller.Instance;

            return Invoke<ResolveAliasRequest,ResolveAliasResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<ResolveAliasResponse> ResolveAliasAsync(string aliasId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ResolveAliasRequest();
            request.AliasId = aliasId;
            return ResolveAliasAsync(request, cancellationToken);
        }


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
        public virtual Task<ResolveAliasResponse> ResolveAliasAsync(ResolveAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResolveAliasRequestMarshaller();
            var unmarshaller = ResolveAliasResponseUnmarshaller.Instance;

            return InvokeAsync<ResolveAliasRequest,ResolveAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SearchGameSessions

        internal virtual SearchGameSessionsResponse SearchGameSessions(SearchGameSessionsRequest request)
        {
            var marshaller = new SearchGameSessionsRequestMarshaller();
            var unmarshaller = SearchGameSessionsResponseUnmarshaller.Instance;

            return Invoke<SearchGameSessionsRequest,SearchGameSessionsResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<SearchGameSessionsResponse> SearchGameSessionsAsync(SearchGameSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SearchGameSessionsRequestMarshaller();
            var unmarshaller = SearchGameSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchGameSessionsRequest,SearchGameSessionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartGameSessionPlacement

        internal virtual StartGameSessionPlacementResponse StartGameSessionPlacement(StartGameSessionPlacementRequest request)
        {
            var marshaller = new StartGameSessionPlacementRequestMarshaller();
            var unmarshaller = StartGameSessionPlacementResponseUnmarshaller.Instance;

            return Invoke<StartGameSessionPlacementRequest,StartGameSessionPlacementResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<StartGameSessionPlacementResponse> StartGameSessionPlacementAsync(StartGameSessionPlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartGameSessionPlacementRequestMarshaller();
            var unmarshaller = StartGameSessionPlacementResponseUnmarshaller.Instance;

            return InvokeAsync<StartGameSessionPlacementRequest,StartGameSessionPlacementResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartMatchmaking

        internal virtual StartMatchmakingResponse StartMatchmaking(StartMatchmakingRequest request)
        {
            var marshaller = new StartMatchmakingRequestMarshaller();
            var unmarshaller = StartMatchmakingResponseUnmarshaller.Instance;

            return Invoke<StartMatchmakingRequest,StartMatchmakingResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<StartMatchmakingResponse> StartMatchmakingAsync(StartMatchmakingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartMatchmakingRequestMarshaller();
            var unmarshaller = StartMatchmakingResponseUnmarshaller.Instance;

            return InvokeAsync<StartMatchmakingRequest,StartMatchmakingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopGameSessionPlacement

        internal virtual StopGameSessionPlacementResponse StopGameSessionPlacement(StopGameSessionPlacementRequest request)
        {
            var marshaller = new StopGameSessionPlacementRequestMarshaller();
            var unmarshaller = StopGameSessionPlacementResponseUnmarshaller.Instance;

            return Invoke<StopGameSessionPlacementRequest,StopGameSessionPlacementResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<StopGameSessionPlacementResponse> StopGameSessionPlacementAsync(StopGameSessionPlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopGameSessionPlacementRequestMarshaller();
            var unmarshaller = StopGameSessionPlacementResponseUnmarshaller.Instance;

            return InvokeAsync<StopGameSessionPlacementRequest,StopGameSessionPlacementResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopMatchmaking

        internal virtual StopMatchmakingResponse StopMatchmaking(StopMatchmakingRequest request)
        {
            var marshaller = new StopMatchmakingRequestMarshaller();
            var unmarshaller = StopMatchmakingResponseUnmarshaller.Instance;

            return Invoke<StopMatchmakingRequest,StopMatchmakingResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<StopMatchmakingResponse> StopMatchmakingAsync(StopMatchmakingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopMatchmakingRequestMarshaller();
            var unmarshaller = StopMatchmakingResponseUnmarshaller.Instance;

            return InvokeAsync<StopMatchmakingRequest,StopMatchmakingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAlias

        internal virtual UpdateAliasResponse UpdateAlias(UpdateAliasRequest request)
        {
            var marshaller = new UpdateAliasRequestMarshaller();
            var unmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateAliasRequest,UpdateAliasResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateAliasRequestMarshaller();
            var unmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAliasRequest,UpdateAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateBuild

        internal virtual UpdateBuildResponse UpdateBuild(UpdateBuildRequest request)
        {
            var marshaller = new UpdateBuildRequestMarshaller();
            var unmarshaller = UpdateBuildResponseUnmarshaller.Instance;

            return Invoke<UpdateBuildRequest,UpdateBuildResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<UpdateBuildResponse> UpdateBuildAsync(UpdateBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateBuildRequestMarshaller();
            var unmarshaller = UpdateBuildResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBuildRequest,UpdateBuildResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateFleetAttributes

        internal virtual UpdateFleetAttributesResponse UpdateFleetAttributes(UpdateFleetAttributesRequest request)
        {
            var marshaller = new UpdateFleetAttributesRequestMarshaller();
            var unmarshaller = UpdateFleetAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetAttributesRequest,UpdateFleetAttributesResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<UpdateFleetAttributesResponse> UpdateFleetAttributesAsync(UpdateFleetAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateFleetAttributesRequestMarshaller();
            var unmarshaller = UpdateFleetAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFleetAttributesRequest,UpdateFleetAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateFleetCapacity

        internal virtual UpdateFleetCapacityResponse UpdateFleetCapacity(UpdateFleetCapacityRequest request)
        {
            var marshaller = new UpdateFleetCapacityRequestMarshaller();
            var unmarshaller = UpdateFleetCapacityResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetCapacityRequest,UpdateFleetCapacityResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<UpdateFleetCapacityResponse> UpdateFleetCapacityAsync(UpdateFleetCapacityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateFleetCapacityRequestMarshaller();
            var unmarshaller = UpdateFleetCapacityResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFleetCapacityRequest,UpdateFleetCapacityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateFleetPortSettings

        internal virtual UpdateFleetPortSettingsResponse UpdateFleetPortSettings(UpdateFleetPortSettingsRequest request)
        {
            var marshaller = new UpdateFleetPortSettingsRequestMarshaller();
            var unmarshaller = UpdateFleetPortSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetPortSettingsRequest,UpdateFleetPortSettingsResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<UpdateFleetPortSettingsResponse> UpdateFleetPortSettingsAsync(UpdateFleetPortSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateFleetPortSettingsRequestMarshaller();
            var unmarshaller = UpdateFleetPortSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFleetPortSettingsRequest,UpdateFleetPortSettingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateGameSession

        internal virtual UpdateGameSessionResponse UpdateGameSession(UpdateGameSessionRequest request)
        {
            var marshaller = new UpdateGameSessionRequestMarshaller();
            var unmarshaller = UpdateGameSessionResponseUnmarshaller.Instance;

            return Invoke<UpdateGameSessionRequest,UpdateGameSessionResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<UpdateGameSessionResponse> UpdateGameSessionAsync(UpdateGameSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateGameSessionRequestMarshaller();
            var unmarshaller = UpdateGameSessionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGameSessionRequest,UpdateGameSessionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateGameSessionQueue

        internal virtual UpdateGameSessionQueueResponse UpdateGameSessionQueue(UpdateGameSessionQueueRequest request)
        {
            var marshaller = new UpdateGameSessionQueueRequestMarshaller();
            var unmarshaller = UpdateGameSessionQueueResponseUnmarshaller.Instance;

            return Invoke<UpdateGameSessionQueueRequest,UpdateGameSessionQueueResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<UpdateGameSessionQueueResponse> UpdateGameSessionQueueAsync(UpdateGameSessionQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateGameSessionQueueRequestMarshaller();
            var unmarshaller = UpdateGameSessionQueueResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGameSessionQueueRequest,UpdateGameSessionQueueResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateMatchmakingConfiguration

        internal virtual UpdateMatchmakingConfigurationResponse UpdateMatchmakingConfiguration(UpdateMatchmakingConfigurationRequest request)
        {
            var marshaller = new UpdateMatchmakingConfigurationRequestMarshaller();
            var unmarshaller = UpdateMatchmakingConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateMatchmakingConfigurationRequest,UpdateMatchmakingConfigurationResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<UpdateMatchmakingConfigurationResponse> UpdateMatchmakingConfigurationAsync(UpdateMatchmakingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateMatchmakingConfigurationRequestMarshaller();
            var unmarshaller = UpdateMatchmakingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMatchmakingConfigurationRequest,UpdateMatchmakingConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateRuntimeConfiguration

        internal virtual UpdateRuntimeConfigurationResponse UpdateRuntimeConfiguration(UpdateRuntimeConfigurationRequest request)
        {
            var marshaller = new UpdateRuntimeConfigurationRequestMarshaller();
            var unmarshaller = UpdateRuntimeConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateRuntimeConfigurationRequest,UpdateRuntimeConfigurationResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<UpdateRuntimeConfigurationResponse> UpdateRuntimeConfigurationAsync(UpdateRuntimeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateRuntimeConfigurationRequestMarshaller();
            var unmarshaller = UpdateRuntimeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRuntimeConfigurationRequest,UpdateRuntimeConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ValidateMatchmakingRuleSet

        internal virtual ValidateMatchmakingRuleSetResponse ValidateMatchmakingRuleSet(ValidateMatchmakingRuleSetRequest request)
        {
            var marshaller = new ValidateMatchmakingRuleSetRequestMarshaller();
            var unmarshaller = ValidateMatchmakingRuleSetResponseUnmarshaller.Instance;

            return Invoke<ValidateMatchmakingRuleSetRequest,ValidateMatchmakingRuleSetResponse>(request, marshaller, unmarshaller);
        }


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
        public virtual Task<ValidateMatchmakingRuleSetResponse> ValidateMatchmakingRuleSetAsync(ValidateMatchmakingRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ValidateMatchmakingRuleSetRequestMarshaller();
            var unmarshaller = ValidateMatchmakingRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<ValidateMatchmakingRuleSetRequest,ValidateMatchmakingRuleSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}