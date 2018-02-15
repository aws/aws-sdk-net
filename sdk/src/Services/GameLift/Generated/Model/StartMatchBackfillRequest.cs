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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the StartMatchBackfill operation.
    /// Finds new players to fill open slots in an existing game session. This operation can
    /// be used to add players to matched games that start with fewer than the maximum number
    /// of players or to replace players when they drop out. By backfilling with the same
    /// matchmaker used to create the original match, you ensure that new players meet the
    /// match criteria and maintain a consistent experience throughout the game session. You
    /// can backfill a match anytime after a game session has been created. 
    /// 
    ///  
    /// <para>
    /// To request a match backfill, specify a unique ticket ID, the existing game session's
    /// ARN, a matchmaking configuration, and a set of data that describes all current players
    /// in the game session. If successful, a match backfill ticket is created and returned
    /// with status set to QUEUED. The ticket is placed in the matchmaker's ticket pool and
    /// processed. Track the status of the ticket to respond as needed. For more detail how
    /// to set up backfilling, see <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/match-backfill.html">
    /// Backfill Existing Games with FlexMatch</a>. 
    /// </para>
    ///  
    /// <para>
    /// The process of finding backfill matches is essentially identical to the initial matchmaking
    /// process. The matchmaker searches the pool and groups tickets together to form potential
    /// matches, allowing only one backfill ticket per potential match. Once the a match is
    /// formed, the matchmaker creates player sessions for the new players. All tickets in
    /// the match are updated with the game session's connection information, and the <a>GameSession</a>
    /// object is updated to include matchmaker data on the new players. For more detail on
    /// how match backfill requests are processed, see <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/match-intro.html">
    /// How Amazon GameLift FlexMatch Works</a>. 
    /// </para>
    ///  
    /// <para>
    /// Matchmaking-related operations include:
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
    public partial class StartMatchBackfillRequest : AmazonGameLiftRequest
    {
        private string _configurationName;
        private string _gameSessionArn;
        private List<Player> _players = new List<Player>();
        private string _ticketId;

        /// <summary>
        /// Gets and sets the property ConfigurationName. 
        /// <para>
        /// Name of the matchmaker to use for this request. The name of the matchmaker that was
        /// used with the original game session is listed in the <a>GameSession</a> object, <code>MatchmakerData</code>
        /// property. This property contains a matchmaking configuration ARN value, which includes
        /// the matchmaker name. (In the ARN value "arn:aws:gamelift:us-west-2:111122223333:matchmakingconfiguration/MM-4v4",
        /// the matchmaking configuration name is "MM-4v4".) Use only the name for this parameter.
        /// </para>
        /// </summary>
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
        /// Amazon Resource Name (<a href="http://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a game session and uniquely identifies it. 
        /// </para>
        /// </summary>
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
        ///  <ul> <li> 
        /// <para>
        /// PlayerID, PlayerAttributes, Team -\\- This information is maintained in the <a>GameSession</a>
        /// object, <code>MatchmakerData</code> property, for all players who are currently assigned
        /// to the game session. The matchmaker data is in JSON syntax, formatted as a string.
        /// For more details, see <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/match-server.html#match-server-data">
        /// Match Data</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LatencyInMs -\\- If the matchmaker uses player latency, include a latency value, in
        /// milliseconds, for the region that the game session is currently in. Do not include
        /// latency values for any other region.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// Unique identifier for a matchmaking ticket. If no ticket ID is specified here, Amazon
        /// GameLift will generate one in the form of a UUID. Use this identifier to track the
        /// match backfill ticket status and retrieve match results.
        /// </para>
        /// </summary>
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