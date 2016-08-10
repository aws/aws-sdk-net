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
    /// Container for the parameters to the CreateGameSession operation.
    /// Creates a multiplayer game session for players. This action creates a game session
    /// record and assigns the new session to an instance in the specified fleet, which initializes
    /// a new server process to host the game session. A fleet must be in an <code>ACTIVE</code>
    /// status before a game session can be created in it.
    /// 
    ///  
    /// <para>
    /// To create a game session, specify either a fleet ID or an alias ID and indicate the
    /// maximum number of players the game session allows. You can also provide a name and
    /// a set of properties for your game (optional). If successful, a <a>GameSession</a>
    /// object is returned containing session properties, including an IP address. By default,
    /// newly created game sessions are set to accept adding any new players to the game session.
    /// Use <a>UpdateGameSession</a> to change the creation policy.
    /// </para>
    /// </summary>
    public partial class CreateGameSessionRequest : AmazonGameLiftRequest
    {
        private string _aliasId;
        private string _fleetId;
        private List<GameProperty> _gameProperties = new List<GameProperty>();
        private int? _maximumPlayerSessionCount;
        private string _name;

        /// <summary>
        /// Gets and sets the property AliasId. 
        /// <para>
        /// Unique identifier for a fleet alias. Each request must reference either a fleet ID
        /// or alias ID, but not both.
        /// </para>
        /// </summary>
        public string AliasId
        {
            get { return this._aliasId; }
            set { this._aliasId = value; }
        }

        // Check to see if AliasId property is set
        internal bool IsSetAliasId()
        {
            return this._aliasId != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier for a fleet. Each request must reference either a fleet ID or alias
        /// ID, but not both.
        /// </para>
        /// </summary>
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property GameProperties. 
        /// <para>
        /// Set of properties used to administer a game session. These properties are passed to
        /// the server process hosting it. 
        /// </para>
        /// </summary>
        public List<GameProperty> GameProperties
        {
            get { return this._gameProperties; }
            set { this._gameProperties = value; }
        }

        // Check to see if GameProperties property is set
        internal bool IsSetGameProperties()
        {
            return this._gameProperties != null && this._gameProperties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaximumPlayerSessionCount. 
        /// <para>
        /// Maximum number of players that can be connected simultaneously to the game session.
        /// 
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

    }
}