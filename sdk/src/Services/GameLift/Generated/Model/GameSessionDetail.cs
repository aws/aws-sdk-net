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
    /// A game session's properties plus the protection policy currently in force.
    /// </summary>
    public partial class GameSessionDetail
    {
        private GameSession _gameSession;
        private ProtectionPolicy _protectionPolicy;

        /// <summary>
        /// Gets and sets the property GameSession. 
        /// <para>
        /// Object that describes a game session.
        /// </para>
        /// </summary>
        public GameSession GameSession
        {
            get { return this._gameSession; }
            set { this._gameSession = value; }
        }

        // Check to see if GameSession property is set
        internal bool IsSetGameSession()
        {
            return this._gameSession != null;
        }

        /// <summary>
        /// Gets and sets the property ProtectionPolicy. 
        /// <para>
        /// Current status of protection for the game session.
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