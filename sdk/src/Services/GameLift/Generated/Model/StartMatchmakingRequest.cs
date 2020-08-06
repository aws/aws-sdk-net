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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the StartMatchmaking operation.
    /// Uses FlexMatch to create a game match for a group of players based on custom matchmaking
    /// rules, and starts a new game for the matched players. Each matchmaking request specifies
    /// the type of match to build (team configuration, rules for an acceptable match, etc.).
    /// The request also specifies the players to find a match for and where to host the new
    /// game session for optimal performance. A matchmaking request might start with a single
    /// player or a group of players who want to play together. FlexMatch finds additional
    /// players as needed to fill the match. Match type, rules, and the queue used to place
    /// a new game session are defined in a <code>MatchmakingConfiguration</code>. 
    /// 
    ///  
    /// <para>
    /// To start matchmaking, provide a unique ticket ID, specify a matchmaking configuration,
    /// and include the players to be matched. You must also include a set of player attributes
    /// relevant for the matchmaking configuration. If successful, a matchmaking ticket is
    /// returned with status set to <code>QUEUED</code>. 
    /// </para>
    ///  
    /// <para>
    /// Track the status of the ticket to respond as needed and acquire game session connection
    /// information for successfully completed matches. Ticket status updates are tracked
    /// using event notification through Amazon Simple Notification Service (SNS), which is
    /// defined in the matchmaking configuration.
    /// </para>
    ///  
    /// <para>
    ///  <b>Processing a matchmaking request</b> -- FlexMatch handles a matchmaking request
    /// as follows: 
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Your client code submits a <code>StartMatchmaking</code> request for one or more players
    /// and tracks the status of the request ticket. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// FlexMatch uses this ticket and others in process to build an acceptable match. When
    /// a potential match is identified, all tickets in the proposed match are advanced to
    /// the next status. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the match requires player acceptance (set in the matchmaking configuration), the
    /// tickets move into status <code>REQUIRES_ACCEPTANCE</code>. This status triggers your
    /// client code to solicit acceptance from all players in every ticket involved in the
    /// match, and then call <a>AcceptMatch</a> for each player. If any player rejects or
    /// fails to accept the match before a specified timeout, the proposed match is dropped
    /// (see <code>AcceptMatch</code> for more details).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Once a match is proposed and accepted, the matchmaking tickets move into status <code>PLACING</code>.
    /// FlexMatch locates resources for a new game session using the game session queue (set
    /// in the matchmaking configuration) and creates the game session based on the match
    /// data. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When the match is successfully placed, the matchmaking tickets move into <code>COMPLETED</code>
    /// status. Connection information (including game session endpoint and player session)
    /// is added to the matchmaking tickets. Matched players can use the connection information
    /// to join the game. 
    /// </para>
    ///  </li> </ol> 
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-client.html">
    /// Add FlexMatch to a Game Client</a> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-notification.html">
    /// Set Up FlexMatch Event Notification</a> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-tasks.html">
    /// FlexMatch Integration Roadmap</a> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-match.html">
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
    public partial class StartMatchmakingRequest : AmazonGameLiftRequest
    {
        private string _configurationName;
        private List<Player> _players = new List<Player>();
        private string _ticketId;

        /// <summary>
        /// Gets and sets the property ConfigurationName. 
        /// <para>
        /// Name of the matchmaking configuration to use for this request. Matchmaking configurations
        /// must exist in the same Region as this request. You can use either the configuration
        /// name or ARN value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ConfigurationName
        {
            get { return this._configurationName; }
            set { this._configurationName = value; }
        }

        // Check to see if ConfigurationName property is set
        internal bool IsSetConfigurationName()
        {
            return this._configurationName != null;
        }

        /// <summary>
        /// Gets and sets the property Players. 
        /// <para>
        /// Information on each player to be matched. This information must include a player ID,
        /// and may contain player attributes and latency data to be used in the matchmaking process.
        /// After a successful match, <code>Player</code> objects contain the name of the team
        /// the player is assigned to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Player> Players
        {
            get { return this._players; }
            set { this._players = value; }
        }

        // Check to see if Players property is set
        internal bool IsSetPlayers()
        {
            return this._players != null && this._players.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TicketId. 
        /// <para>
        /// A unique identifier for a matchmaking ticket. If no ticket ID is specified here, Amazon
        /// GameLift will generate one in the form of a UUID. Use this identifier to track the
        /// matchmaking ticket status and retrieve match results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string TicketId
        {
            get { return this._ticketId; }
            set { this._ticketId = value; }
        }

        // Check to see if TicketId property is set
        internal bool IsSetTicketId()
        {
            return this._ticketId != null;
        }

    }
}