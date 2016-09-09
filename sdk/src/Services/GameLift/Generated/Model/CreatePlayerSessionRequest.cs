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
    /// Container for the parameters to the CreatePlayerSession operation.
    /// Adds a player to a game session and creates a player session record. A game session
    /// must be in an <code>ACTIVE</code> status, have a creation policy of <code>ALLOW_ALL</code>,
    /// and have an open player slot before players can be added to the session.
    /// 
    ///  
    /// <para>
    /// To create a player session, specify a game session ID and player ID. If successful,
    /// the player is added to the game session and a new <a>PlayerSession</a> object is returned.
    /// 
    /// </para>
    /// </summary>
    public partial class CreatePlayerSessionRequest : AmazonGameLiftRequest
    {
        private string _gameSessionId;
        private string _playerId;

        /// <summary>
        /// Gets and sets the property GameSessionId. 
        /// <para>
        /// Unique identifier for a game session. Specify the game session you want to add a player
        /// to.
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
        /// Gets and sets the property PlayerId. 
        /// <para>
        /// Unique identifier for the player to be added.
        /// </para>
        /// </summary>
        public string PlayerId
        {
            get { return this._playerId; }
            set { this._playerId = value; }
        }

        // Check to see if PlayerId property is set
        internal bool IsSetPlayerId()
        {
            return this._playerId != null;
        }

    }
}