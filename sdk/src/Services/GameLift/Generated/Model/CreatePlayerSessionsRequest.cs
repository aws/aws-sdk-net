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
    /// Container for the parameters to the CreatePlayerSessions operation.
    /// Adds a group of players to a game session. Similar to <a>CreatePlayerSession</a>,
    /// this action allows you to add multiple players in a single call, which is useful for
    /// games that provide party and/or matchmaking features. A game session must be in an
    /// <code>ACTIVE</code> status, have a creation policy of <code>ALLOW_ALL</code>, and
    /// have an open player slot before players can be added to the session.
    /// 
    ///  
    /// <para>
    /// To create player sessions, specify a game session ID and a list of player IDs. If
    /// successful, the players are added to the game session and a set of new <a>PlayerSession</a>
    /// objects is returned. 
    /// </para>
    /// </summary>
    public partial class CreatePlayerSessionsRequest : AmazonGameLiftRequest
    {
        private string _gameSessionId;
        private List<string> _playerIds = new List<string>();

        /// <summary>
        /// Gets and sets the property GameSessionId. 
        /// <para>
        /// Unique identifier for the game session to add players to. Game session ID format is
        /// as follows: "arn:aws:gamelift:&lt;region&gt;::gamesession/fleet-&lt;fleet ID&gt;/&lt;ID
        /// string&gt;". The value of &lt;ID string&gt; is either a custom ID string (if one was
        /// specified when the game session was created) an auto-generated string. 
        /// </para>
        /// </summary>
        public string GameSessionId
        {
            get { return this._gameSessionId; }
            set { this._gameSessionId = value; }
        }

        // Check to see if GameSessionId property is set
        internal bool IsSetGameSessionId()
        {
            return this._gameSessionId != null;
        }

        /// <summary>
        /// Gets and sets the property PlayerIds. 
        /// <para>
        /// List of unique identifiers for the players to be added.
        /// </para>
        /// </summary>
        public List<string> PlayerIds
        {
            get { return this._playerIds; }
            set { this._playerIds = value; }
        }

        // Check to see if PlayerIds property is set
        internal bool IsSetPlayerIds()
        {
            return this._playerIds != null && this._playerIds.Count > 0; 
        }

    }
}