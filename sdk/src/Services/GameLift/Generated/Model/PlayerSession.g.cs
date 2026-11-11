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
    /// Represents a player session. Player sessions are created either for a specific game
    /// session, or as part of a game session placement or matchmaking request. A player session
    /// can represent a reserved player slot in a game session (when status is <c>RESERVED</c>)
    /// or actual player activity in a game session (when status is <c>ACTIVE</c>). A player
    /// session object, including player data, is automatically passed to a game session when
    /// the player connects to the game session and is validated. After the game session ends,
    /// player session information is retained for 30 days and then removed.
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
    public partial class PlayerSession
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp indicating when this data object was created. Format is a number expressed
        /// in Unix time as milliseconds (for example <c>"1469498468.057"</c>).
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

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
        /// Gets and sets the property FleetArn. 
        /// <para>
        ///  The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// associated with the GameLift fleet that the player's game session is running on. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string FleetArn { get; set; }

        /// <summary>
        /// Checks to see if the FleetArn property is set.
        /// </summary>
        internal bool IsSetFleetArn() => this.FleetArn != null;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet that the player's game session is running on.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;

        /// <summary>
        /// Gets and sets the property GameSessionId. 
        /// <para>
        /// An identifier for the game session that is unique across all regions that the player
        /// session is connected to. The value is always a full ARN in the following format: For
        /// Home Region game session - <c>arn:aws:gamelift:&lt;home_region&gt;::gamesession/&lt;fleet
        /// ID&gt;/&lt;ID string&gt;</c>. For Remote Location game session - <c>arn:aws:gamelift:&lt;home_region&gt;::gamesession/&lt;fleet
        /// ID&gt;/&lt;location&gt;/&lt;ID string&gt;</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string GameSessionId { get; set; }

        /// <summary>
        /// Checks to see if the GameSessionId property is set.
        /// </summary>
        internal bool IsSetGameSessionId() => this.GameSessionId != null;

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
        /// Gets and sets the property PlayerData. 
        /// <para>
        /// Developer-defined information related to a player. Amazon GameLift Servers does not
        /// use this data, so it can be formatted as needed for use in the game. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2048)]
        public string PlayerData { get; set; }

        /// <summary>
        /// Checks to see if the PlayerData property is set.
        /// </summary>
        internal bool IsSetPlayerData() => this.PlayerData != null;

        /// <summary>
        /// Gets and sets the property PlayerId. 
        /// <para>
        /// A unique identifier for a player that is associated with this player session.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string PlayerId { get; set; }

        /// <summary>
        /// Checks to see if the PlayerId property is set.
        /// </summary>
        internal bool IsSetPlayerId() => this.PlayerId != null;

        /// <summary>
        /// Gets and sets the property PlayerSessionId. 
        /// <para>
        /// A unique identifier for a player session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string PlayerSessionId { get; set; }

        /// <summary>
        /// Checks to see if the PlayerSessionId property is set.
        /// </summary>
        internal bool IsSetPlayerSessionId() => this.PlayerSessionId != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Port number for the game session. To connect to a Amazon GameLift Servers server process,
        /// an app needs both the IP address and port number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 60000)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the player session.
        /// </para>
        ///  
        /// <para>
        /// Possible player session statuses include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>RESERVED</b> -- The player session request has been received, but the player has
        /// not yet connected to the server process and/or been validated. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ACTIVE</b> -- The player has been validated by the server process and is currently
        /// connected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>COMPLETED</b> -- The player connection has been dropped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>TIMEDOUT</b> -- A player session request was received, but the player did not
        /// connect and/or was not validated within the timeout limit (60 seconds).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PlayerSessionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TerminationTime. 
        /// <para>
        /// A time stamp indicating when this data object was terminated. Format is a number expressed
        /// in Unix time as milliseconds (for example <c>"1469498468.057"</c>).
        /// </para>
        /// </summary>
        public DateTime? TerminationTime { get; set; }

        /// <summary>
        /// Checks to see if the TerminationTime property is set.
        /// </summary>
        internal bool IsSetTerminationTime() => this.TerminationTime.HasValue;
    }
}
