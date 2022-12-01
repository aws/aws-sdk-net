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
        ///  
        /// <para>
        /// You can include up to 10 <code>Players</code> in a <code>StartMatchmaking</code> request.
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