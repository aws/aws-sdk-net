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
    /// Information about a player session. This object contains only the player ID and player
    /// session ID. To retrieve full details on a player session, call <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribePlayerSessions.html">DescribePlayerSessions</a>
    /// with the player session ID.
    /// </summary>
    public partial class PlacedPlayerSession
    {
        private string _playerId;
        private string _playerSessionId;

        /// <summary>
        /// Gets and sets the property PlayerId. 
        /// <para>
        /// A unique identifier for a player that is associated with this player session.
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

        /// <summary>
        /// Gets and sets the property PlayerSessionId. 
        /// <para>
        /// A unique identifier for a player session.
        /// </para>
        /// </summary>
        public string PlayerSessionId
        {
            get { return this._playerSessionId; }
            set { this._playerSessionId = value; }
        }

        // Check to see if PlayerSessionId property is set
        internal bool IsSetPlayerSessionId()
        {
            return this._playerSessionId != null;
        }

    }
}