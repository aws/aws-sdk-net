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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Represents a potential game session placement, including the full details of the original
    /// placement request and the current status. 
    /// 
    ///  <note> 
    /// <para>
    /// If the game session placement status is <c>PENDING</c>, the properties for game session
    /// ID/ARN, region, IP address/DNS, and port aren't final. A game session is not active
    /// and ready to accept players until placement status reaches <c>FULFILLED</c>. When
    /// the placement is in <c>PENDING</c> status, Amazon GameLift Servers may attempt to
    /// place a game session multiple times before succeeding. With each attempt it creates
    /// a <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GameSession">https://docs.aws.amazon.com/gamelift/latest/apireference/API_GameSession</a>
    /// object and updates this placement object with the new game session properties.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GameSessionPlacement
    {
        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The DNS identifier assigned to the instance that is running the game session. Values
        /// have the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// TLS-enabled fleets: <c>&lt;unique identifier&gt;.&lt;region identifier&gt;.amazongamelift.com</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Non-TLS-enabled fleets: <c>ec2-&lt;unique identifier&gt;.compute.amazonaws.com</c>.
        /// (See <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-instance-addressing.html#concepts-public-addresses">Amazon
        /// EC2 Instance IP Addressing</a>.)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When connecting to a game session that is running on a TLS-enabled fleet, you must
        /// use the DNS name, not the IP address.
        /// </para>
        /// </summary>
        public string DnsName { get; set; }

        /// <summary>
        /// Checks to see if the DnsName property is set.
        /// </summary>
        internal bool IsSetDnsName() => this.DnsName != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Time stamp indicating when this request was completed, canceled, or timed out.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property GameProperties. 
        /// <para>
        /// A set of key-value pairs that can store custom data in a game session. For example:
        /// <c>{"Key": "difficulty", "Value": "novice"}</c>.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// Avoid using periods (".") in property keys if you plan to search for game sessions
        /// by properties. Property keys containing periods cannot be searched and will be filtered
        /// out from search results due to search index limitations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use SearchGameSessions API, there is a limit of 500 game property keys across
        /// all game sessions and all fleets per region. If the limit is exceeded, there will
        /// potentially be game session entries missing from SearchGameSessions API results.
        /// </para>
        ///  </li> </ul> </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 16)]
        public List<GameProperty> GameProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<GameProperty>() : null;

        /// <summary>
        /// Checks to see if the GameProperties property is set.
        /// </summary>
        internal bool IsSetGameProperties() => this.GameProperties != null && (this.GameProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GameSessionArn. 
        /// <para>
        /// An identifier for the game session that is unique across all regions. The value is
        /// always a full ARN in the following format: For Home Region game session - <c>arn:aws:gamelift:&lt;home_region&gt;::gamesession/&lt;fleet
        /// ID&gt;/&lt;ID string&gt;</c>. For Remote Location game session - <c>arn:aws:gamelift:&lt;home_region&gt;::gamesession/&lt;fleet
        /// ID&gt;/&lt;location&gt;/&lt;ID string&gt;</c>. This value is the same as <c>GameSessionId</c>.
        /// This value isn't final until placement status is <c>FULFILLED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string GameSessionArn { get; set; }

        /// <summary>
        /// Checks to see if the GameSessionArn property is set.
        /// </summary>
        internal bool IsSetGameSessionArn() => this.GameSessionArn != null;

        /// <summary>
        /// Gets and sets the property GameSessionData. 
        /// <para>
        /// A set of custom game session properties, formatted as a single string value. This
        /// data is passed to a game server process with a request to start a new game session.
        /// For more information, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html#gamelift-sdk-server-startsession">Start
        /// a game session</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 262144)]
        public string GameSessionData { get; set; }

        /// <summary>
        /// Checks to see if the GameSessionData property is set.
        /// </summary>
        internal bool IsSetGameSessionData() => this.GameSessionData != null;

        /// <summary>
        /// Gets and sets the property GameSessionId. 
        /// <para>
        /// An identifier for the game session that is unique across all regions. The value is
        /// always a full ARN in the following format: For Home Region game session - <c>arn:aws:gamelift:&lt;home_region&gt;::gamesession/&lt;fleet
        /// ID&gt;/&lt;ID string&gt;</c>. For Remote Location game session - <c>arn:aws:gamelift:&lt;home_region&gt;::gamesession/&lt;fleet
        /// ID&gt;/&lt;location&gt;/&lt;ID string&gt;</c>. This value is the same as <c>GameSessionArn</c>.
        /// This value isn't final until placement status is <c>FULFILLED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string GameSessionId { get; set; }

        /// <summary>
        /// Checks to see if the GameSessionId property is set.
        /// </summary>
        internal bool IsSetGameSessionId() => this.GameSessionId != null;

        /// <summary>
        /// Gets and sets the property GameSessionName. 
        /// <para>
        /// A descriptive label that is associated with a game session. Session names do not need
        /// to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string GameSessionName { get; set; }

        /// <summary>
        /// Checks to see if the GameSessionName property is set.
        /// </summary>
        internal bool IsSetGameSessionName() => this.GameSessionName != null;

        /// <summary>
        /// Gets and sets the property GameSessionQueueName. 
        /// <para>
        /// A descriptive label that is associated with game session queue. Queue names must be
        /// unique within each Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string GameSessionQueueName { get; set; }

        /// <summary>
        /// Checks to see if the GameSessionQueueName property is set.
        /// </summary>
        internal bool IsSetGameSessionQueueName() => this.GameSessionQueueName != null;

        /// <summary>
        /// Gets and sets the property GameSessionRegion. 
        /// <para>
        /// Name of the Region where the game session created by this placement request is running.
        /// This value isn't final until placement status is <c>FULFILLED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string GameSessionRegion { get; set; }

        /// <summary>
        /// Checks to see if the GameSessionRegion property is set.
        /// </summary>
        internal bool IsSetGameSessionRegion() => this.GameSessionRegion != null;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address of the game session. To connect to a Amazon GameLift Servers game server,
        /// an app needs both the IP address and port number. This value isn't final until placement
        /// status is <c>FULFILLED</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property MatchmakerData. 
        /// <para>
        /// Information on the matchmaking process for this game. Data is in JSON syntax, formatted
        /// as a string. It identifies the matchmaking configuration used to create the match,
        /// and contains data on all players assigned to the match, including player attributes
        /// and team assignments. For more details on matchmaker data, see <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-server.html#match-server-data">Match
        /// Data</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 390000)]
        public string MatchmakerData { get; set; }

        /// <summary>
        /// Checks to see if the MatchmakerData property is set.
        /// </summary>
        internal bool IsSetMatchmakerData() => this.MatchmakerData != null;

        /// <summary>
        /// Gets and sets the property MaximumPlayerSessionCount. 
        /// <para>
        /// The maximum number of players that can be connected simultaneously to the game session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MaximumPlayerSessionCount { get; set; }

        /// <summary>
        /// Checks to see if the MaximumPlayerSessionCount property is set.
        /// </summary>
        internal bool IsSetMaximumPlayerSessionCount() => this.MaximumPlayerSessionCount.HasValue;

        /// <summary>
        /// Gets and sets the property PlacedPlayerSessions. 
        /// <para>
        /// A collection of information on player sessions created in response to the game session
        /// placement request. These player sessions are created only after a new game session
        /// is successfully placed (placement status is <c>FULFILLED</c>). This information includes
        /// the player ID, provided in the placement request, and a corresponding player session
        /// ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PlacedPlayerSession> PlacedPlayerSessions { get; set; } = AWSConfigs.InitializeCollections ? new List<PlacedPlayerSession>() : null;

        /// <summary>
        /// Checks to see if the PlacedPlayerSessions property is set.
        /// </summary>
        internal bool IsSetPlacedPlayerSessions() => this.PlacedPlayerSessions != null && (this.PlacedPlayerSessions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PlacementId. 
        /// <para>
        /// A unique identifier for a game session placement.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 48)]
        public string PlacementId { get; set; }

        /// <summary>
        /// Checks to see if the PlacementId property is set.
        /// </summary>
        internal bool IsSetPlacementId() => this.PlacementId != null;

        /// <summary>
        /// Gets and sets the property PlayerGatewayStatus. 
        /// <para>
        /// The current status of player gateway for the game session placement. Note, even if
        /// a fleet has PlayerGatewayMode configured as <c>ENABLED</c>, player gateway might not
        /// be available in a specific location. For more information about locations where player
        /// gateway is supported, see <a href="https://docs.aws.amazon.com/gameliftservers/latest/developerguide/gamelift-regions.html">Amazon
        /// GameLift Servers service locations</a>.
        /// </para>
        ///  
        /// <para>
        /// Possible values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c> -- Player gateway is available for this game session placement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> -- Player gateway is not available for this game session placement.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PlayerGatewayStatus PlayerGatewayStatus { get; set; }

        /// <summary>
        /// Checks to see if the PlayerGatewayStatus property is set.
        /// </summary>
        internal bool IsSetPlayerGatewayStatus() => this.PlayerGatewayStatus != null;

        /// <summary>
        /// Gets and sets the property PlayerLatencies. 
        /// <para>
        /// A set of values, expressed in milliseconds, that indicates the amount of latency that
        /// a player experiences when connected to a fleet location (Amazon Web Services Regions
        /// or custom locations for Amazon GameLift Servers Anywhere fleets).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PlayerLatency> PlayerLatencies { get; set; } = AWSConfigs.InitializeCollections ? new List<PlayerLatency>() : null;

        /// <summary>
        /// Checks to see if the PlayerLatencies property is set.
        /// </summary>
        internal bool IsSetPlayerLatencies() => this.PlayerLatencies != null && (this.PlayerLatencies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number for the game session. To connect to a Amazon GameLift Servers game
        /// server, an app needs both the IP address and port number. This value isn't final until
        /// placement status is <c>FULFILLED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 60000)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property PriorityConfigurationOverride. 
        /// <para>
        /// An alternative priority list of locations that's included with a game session placement
        /// request. When provided, the list overrides a queue's location order list for this
        /// game session placement request only. The list might include Amazon Web Services Regions,
        /// local zones, and custom locations (for Anywhere fleets). The fallback strategy tells
        /// Amazon GameLift Servers what action to take (if any) in the event that it failed to
        /// place a new game session. 
        /// </para>
        /// </summary>
        public PriorityConfigurationOverride PriorityConfigurationOverride { get; set; }

        /// <summary>
        /// Checks to see if the PriorityConfigurationOverride property is set.
        /// </summary>
        internal bool IsSetPriorityConfigurationOverride() => this.PriorityConfigurationOverride != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Time stamp indicating when this request was placed in the queue. Format is a number
        /// expressed in Unix time as milliseconds (for example <c>"1469498468.057"</c>).
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the game session placement request.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>PENDING</b> -- The placement request is in the queue waiting to be processed.
        /// Game session properties are not yet final. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FULFILLED</b> -- A new game session has been successfully placed. Game session
        /// properties are now final.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CANCELLED</b> -- The placement request was canceled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>TIMED_OUT</b> -- A new game session was not successfully created before the time
        /// limit expired. You can resubmit the placement request as needed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FAILED</b> -- Amazon GameLift Servers is not able to complete the process of placing
        /// the game session. Common reasons are the game session terminated before the placement
        /// process was completed, or an unexpected internal error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GameSessionPlacementState Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
