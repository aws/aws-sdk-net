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
    /// Player information for use when creating player sessions using a game session placement
    /// request with <a>StartGameSessionPlacement</a>.
    /// </summary>
    public partial class DesiredPlayerSession
    {
        private string _playerData;
        private string _playerId;

        /// <summary>
        /// Gets and sets the property PlayerData. 
        /// <para>
        /// Developer-defined information related to a player. Amazon GameLift does not use this
        /// data, so it can be formatted as needed for use in the game.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string PlayerData
        {
            get { return this._playerData; }
            set { this._playerData = value; }
        }

        // Check to see if PlayerData property is set
        internal bool IsSetPlayerData()
        {
            return this._playerData != null;
        }

        /// <summary>
        /// Gets and sets the property PlayerId. 
        /// <para>
        /// A unique identifier for a player to associate with the player session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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