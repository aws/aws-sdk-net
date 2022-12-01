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
    /// A policy that puts limits on the number of game sessions that a player can create
    /// within a specified span of time. With this policy, you can control players' ability
    /// to consume available resources.
    /// 
    ///  
    /// <para>
    /// The policy is evaluated when a player tries to create a new game session. On receiving
    /// a <code>CreateGameSession</code> request, GameLift checks that the player (identified
    /// by <code>CreatorId</code>) has created fewer than game session limit in the specified
    /// time period.
    /// </para>
    /// </summary>
    public partial class ResourceCreationLimitPolicy
    {
        private int? _newGameSessionsPerCreator;
        private int? _policyPeriodInMinutes;

        /// <summary>
        /// Gets and sets the property NewGameSessionsPerCreator. 
        /// <para>
        /// A policy that puts limits on the number of game sessions that a player can create
        /// within a specified span of time. With this policy, you can control players' ability
        /// to consume available resources.
        /// </para>
        ///  
        /// <para>
        /// The policy is evaluated when a player tries to create a new game session. On receiving
        /// a <code>CreateGameSession</code> request, GameLift checks that the player (identified
        /// by <code>CreatorId</code>) has created fewer than game session limit in the specified
        /// time period.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int NewGameSessionsPerCreator
        {
            get { return this._newGameSessionsPerCreator.GetValueOrDefault(); }
            set { this._newGameSessionsPerCreator = value; }
        }

        // Check to see if NewGameSessionsPerCreator property is set
        internal bool IsSetNewGameSessionsPerCreator()
        {
            return this._newGameSessionsPerCreator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyPeriodInMinutes. 
        /// <para>
        /// The time span used in evaluating the resource creation limit policy. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int PolicyPeriodInMinutes
        {
            get { return this._policyPeriodInMinutes.GetValueOrDefault(); }
            set { this._policyPeriodInMinutes = value; }
        }

        // Check to see if PolicyPeriodInMinutes property is set
        internal bool IsSetPolicyPeriodInMinutes()
        {
            return this._policyPeriodInMinutes.HasValue; 
        }

    }
}