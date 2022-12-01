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
    /// Container for the parameters to the StartMatchBackfill operation.
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
    /// from a client service by calling this operation with a <code>GameSessions</code> ID.
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
    /// </summary>
    public partial class StartMatchBackfillRequest : AmazonGameLiftRequest
    {
        private string _configurationName;
        private string _gameSessionArn;
        private List<Player> _players = new List<Player>();
        private string _ticketId;

        /// <summary>
        /// Gets and sets the property ConfigurationName. 
        /// <para>
        /// Name of the matchmaker to use for this request. You can use either the configuration
        /// name or ARN value. The ARN of the matchmaker that was used with the original game
        /// session is listed in the <code>GameSession</code> object, <code>MatchmakerData</code>
        /// property.
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
        /// Gets and sets the property GameSessionArn. 
        /// <para>
        /// A unique identifier for the game session. Use the game session ID. When using FlexMatch
        /// as a standalone matchmaking solution, this parameter is not needed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string GameSessionArn
        {
            get { return this._gameSessionArn; }
            set { this._gameSessionArn = value; }
        }

        // Check to see if GameSessionArn property is set
        internal bool IsSetGameSessionArn()
        {
            return this._gameSessionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Players. 
        /// <para>
        /// Match information on all players that are currently assigned to the game session.
        /// This information is used by the matchmaker to find new players and add them to the
        /// existing game.
        /// </para>
        ///  
        /// <para>
        /// You can include up to 199 <code>Players</code> in a <code>StartMatchBackfill</code>
        /// request.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PlayerID, PlayerAttributes, Team -- This information is maintained in the <code>GameSession</code>
        /// object, <code>MatchmakerData</code> property, for all players who are currently assigned
        /// to the game session. The matchmaker data is in JSON syntax, formatted as a string.
        /// For more details, see <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-server.html#match-server-data">
        /// Match Data</a>. 
        /// </para>
        ///  
        /// <para>
        /// The backfill request must specify the team membership for every player. Do not specify
        /// team if you are not using backfill.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LatencyInMs -- If the matchmaker uses player latency, include a latency value, in
        /// milliseconds, for the Region that the game session is currently in. Do not include
        /// latency values for any other Region.
        /// </para>
        ///  </li> </ul>
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
        /// match backfill ticket status and retrieve match results.
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