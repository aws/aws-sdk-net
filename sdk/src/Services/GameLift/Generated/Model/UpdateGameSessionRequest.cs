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
    /// Container for the parameters to the UpdateGameSession operation.
    /// Updates the mutable properties of a game session. 
    /// 
    ///  
    /// <para>
    /// To update a game session, specify the game session ID and the values you want to change.
    /// 
    /// </para>
    ///  
    /// <para>
    /// If successful, the updated <code>GameSession</code> object is returned. 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
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
        /// A unique identifier for the game session to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// The maximum number of players that can be connected simultaneously to the game session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// A descriptive label that is associated with a game session. Session names do not need
        /// to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// A policy that determines whether the game session is accepting new players.
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
        ///  <b>NoProtection</b> -- The game session can be terminated during a scale-down event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FullProtection</b> -- If the game session is in an <code>ACTIVE</code> status,
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