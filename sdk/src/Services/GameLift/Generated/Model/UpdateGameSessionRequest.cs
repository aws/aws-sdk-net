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
    /// Container for the parameters to the UpdateGameSession operation.
    /// Updates game session properties. This includes the session name, maximum player count,
    /// protection policy, which controls whether or not an active game session can be terminated
    /// during a scale-down event, and the player session creation policy, which controls
    /// whether or not new players can join the session. To update a game session, specify
    /// the game session ID and the values you want to change. If successful, an updated <a>GameSession</a>
    /// object is returned.
    /// </summary>
    public partial class UpdateGameSessionRequest : AmazonGameLiftRequest
    {
        private string _gameSessionId;
        private int? _maximumPlayerSessionCount;
        private string _name;
        private PlayerSessionCreationPolicy _playerSessionCreationPolicy;
        private ProtectionPolicy _protectionPolicy;

        /// <summary>
        /// Gets and sets the property GameSessionId. 
        /// <para>
        /// Unique identifier for the game session to update. Game session ID format is as follows:
        /// "arn:aws:gamelift:&lt;region&gt;::gamesession/fleet-&lt;fleet ID&gt;/&lt;ID string&gt;".
        /// The value of &lt;ID string&gt; is either a custom ID string (if one was specified
        /// when the game session was created) an auto-generated string. 
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
        /// Gets and sets the property MaximumPlayerSessionCount. 
        /// <para>
        /// Maximum number of players that can be simultaneously connected to the game session.
        /// </para>
        /// </summary>
        public int MaximumPlayerSessionCount
        {
            get { return this._maximumPlayerSessionCount.GetValueOrDefault(); }
            set { this._maximumPlayerSessionCount = value; }
        }

        // Check to see if MaximumPlayerSessionCount property is set
        internal bool IsSetMaximumPlayerSessionCount()
        {
            return this._maximumPlayerSessionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Descriptive label associated with a game session. Session names do not need to be
        /// unique.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PlayerSessionCreationPolicy. 
        /// <para>
        /// Policy determining whether or not the game session accepts new players.
        /// </para>
        /// </summary>
        public PlayerSessionCreationPolicy PlayerSessionCreationPolicy
        {
            get { return this._playerSessionCreationPolicy; }
            set { this._playerSessionCreationPolicy = value; }
        }

        // Check to see if PlayerSessionCreationPolicy property is set
        internal bool IsSetPlayerSessionCreationPolicy()
        {
            return this._playerSessionCreationPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ProtectionPolicy. 
        /// <para>
        /// Game session protection policy to apply to this game session only.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>NoProtection</b> – The game session can be terminated during a scale-down event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FullProtection</b> – If the game session is in an <code>ACTIVE</code> status,
        /// it cannot be terminated during a scale-down event.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ProtectionPolicy ProtectionPolicy
        {
            get { return this._protectionPolicy; }
            set { this._protectionPolicy = value; }
        }

        // Check to see if ProtectionPolicy property is set
        internal bool IsSetProtectionPolicy()
        {
            return this._protectionPolicy != null;
        }

    }
}