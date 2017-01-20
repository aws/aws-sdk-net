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
    /// Policy that limits the number of game sessions a player can create on the same fleet.
    /// This optional policy gives game owners control over how players can consume available
    /// game server resources. A resource creation policy makes the following statement: "An
    /// individual player can create a maximum number of new game sessions within a specified
    /// time period".
    /// 
    ///  
    /// <para>
    /// The policy is evaluated when a player tries to create a new game session. For example,
    /// with a policy of 10 new game sessions and a time period of 60 minutes, on receiving
    /// a <code>CreateGameSession</code> request, GameLift checks that the player (identified
    /// by <code>CreatorId</code>) has created fewer than 10 game sessions in the past 60
    /// minutes.
    /// </para>
    /// </summary>
    public partial class ResourceCreationLimitPolicy
    {
        private int? _newGameSessionsPerCreator;
        private int? _policyPeriodInMinutes;

        /// <summary>
        /// Gets and sets the property NewGameSessionsPerCreator. 
        /// <para>
        /// Maximum number of game sessions that an individual can create during the policy period.
        /// 
        /// </para>
        /// </summary>
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
        /// Time span used in evaluating the resource creation limit policy. 
        /// </para>
        /// </summary>
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