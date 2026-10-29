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
    /// Connection information for a new game session that is created in response to a start
    /// matchmaking request. Once a match is made, the FlexMatch engine creates a new game
    /// session for it. This information, including the game session endpoint and player sessions
    /// for each player in the original matchmaking request, is added to the matchmaking ticket.
    /// </summary>
    public partial class GameSessionConnectionInfo
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
        /// Gets and sets the property GameSessionArn. 
        /// <para>
        /// An identifier for the game session that is unique across all regions. The value is
        /// always a full ARN in the following format: For Home Region game session - <c>arn:aws:gamelift:&lt;home_region&gt;::gamesession/&lt;fleet
        /// ID&gt;/&lt;ID string&gt;</c>. For Remote Location game session - <c>arn:aws:gamelift:&lt;home_region&gt;::gamesession/&lt;fleet
        /// ID&gt;/&lt;location&gt;/&lt;ID string&gt;</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string GameSessionArn { get; set; }

        /// <summary>
        /// Checks to see if the GameSessionArn property is set.
        /// </summary>
        internal bool IsSetGameSessionArn() => this.GameSessionArn != null;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address of the game session. To connect to a Amazon GameLift Servers game server,
        /// an app needs both the IP address and port number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property MatchedPlayerSessions. 
        /// <para>
        /// A collection of player session IDs, one for each player ID that was included in the
        /// original matchmaking request. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MatchedPlayerSession> MatchedPlayerSessions { get; set; } = AWSConfigs.InitializeCollections ? new List<MatchedPlayerSession>() : null;

        /// <summary>
        /// Checks to see if the MatchedPlayerSessions property is set.
        /// </summary>
        internal bool IsSetMatchedPlayerSessions() => this.MatchedPlayerSessions != null && (this.MatchedPlayerSessions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PlayerGatewayStatus. 
        /// <para>
        /// The current status of player gateway for the game session. Note, even if a fleet has
        /// PlayerGatewayMode configured as <c>ENABLED</c>, player gateway might not be available
        /// in a specific location. For more information about locations where player gateway
        /// is supported, see <a href="https://docs.aws.amazon.com/gameliftservers/latest/developerguide/gamelift-regions.html">supported
        /// locations</a>.
        /// </para>
        ///  
        /// <para>
        /// Possible values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c> -- Player gateway is available for this game session.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> -- Player gateway is not available for this game session.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PlayerGatewayStatus PlayerGatewayStatus { get; set; }

        /// <summary>
        /// Checks to see if the PlayerGatewayStatus property is set.
        /// </summary>
        internal bool IsSetPlayerGatewayStatus() => this.PlayerGatewayStatus != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number for the game session. To connect to a Amazon GameLift Servers game
        /// server, an app needs both the IP address and port number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;
    }
}
