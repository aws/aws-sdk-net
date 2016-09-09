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
    /// Properties describing a game session.
    /// </summary>
    public partial class GameSession
    {
        private DateTime? _creationTime;
        private int? _currentPlayerSessionCount;
        private string _fleetId;
        private List<GameProperty> _gameProperties = new List<GameProperty>();
        private string _gameSessionId;
        private string _ipAddress;
        private int? _maximumPlayerSessionCount;
        private string _name;
        private PlayerSessionCreationPolicy _playerSessionCreationPolicy;
        private int? _port;
        private GameSessionStatus _status;
        private DateTime? _terminationTime;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Time stamp indicating when this data object was created. Format is a number expressed
        /// in Unix time as milliseconds (ex: "1469498468.057".
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentPlayerSessionCount. 
        /// <para>
        /// Number of players currently in the game session.
        /// </para>
        /// </summary>
        public int CurrentPlayerSessionCount
        {
            get { return this._currentPlayerSessionCount.GetValueOrDefault(); }
            set { this._currentPlayerSessionCount = value; }
        }

        // Check to see if CurrentPlayerSessionCount property is set
        internal bool IsSetCurrentPlayerSessionCount()
        {
            return this._currentPlayerSessionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier for a fleet.
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
        /// Set of custom properties for the game session.
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
        /// Gets and sets the property GameSessionId. 
        /// <para>
        /// Unique identifier for a game session.
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
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// IP address of the game session. To connect to a GameLift server process, an app needs
        /// both the IP address and port number.
        /// </para>
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumPlayerSessionCount. 
        /// <para>
        /// Maximum number of players allowed in the game session.
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
        /// Indicates whether or not the game session is accepting new players.
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
        /// Gets and sets the property Port. 
        /// <para>
        /// Port number for the game session. To connect to a GameLift server process, an app
        /// needs both the IP address and port number.
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the game session. A game session must be in an <code>ACTIVE</code>
        /// status to have player sessions.
        /// </para>
        /// </summary>
        public GameSessionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TerminationTime. 
        /// <para>
        /// Time stamp indicating when this data object was terminated. Format is a number expressed
        /// in Unix time as milliseconds (ex: "1469498468.057".
        /// </para>
        /// </summary>
        public DateTime TerminationTime
        {
            get { return this._terminationTime.GetValueOrDefault(); }
            set { this._terminationTime = value; }
        }

        // Check to see if TerminationTime property is set
        internal bool IsSetTerminationTime()
        {
            return this._terminationTime.HasValue; 
        }

    }
}