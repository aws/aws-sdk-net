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
    /// Queue setting that determines the highest latency allowed for individual players when
    /// placing a game session. When a latency policy is in force, a game session cannot be
    /// placed at any destination in a region where a player is reporting latency higher than
    /// the cap. Latency policies are only enforced when the placement request contains player
    /// latency information.
    /// 
    ///  
    /// <para>
    /// Queue-related operations include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateGameSessionQueue</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeGameSessionQueues</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateGameSessionQueue</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteGameSessionQueue</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PlayerLatencyPolicy
    {
        private int? _maximumIndividualPlayerLatencyMilliseconds;
        private int? _policyDurationSeconds;

        /// <summary>
        /// Gets and sets the property MaximumIndividualPlayerLatencyMilliseconds. 
        /// <para>
        /// The maximum latency value that is allowed for any player, in milliseconds. All policies
        /// must have a value set for this property.
        /// </para>
        /// </summary>
        public int MaximumIndividualPlayerLatencyMilliseconds
        {
            get { return this._maximumIndividualPlayerLatencyMilliseconds.GetValueOrDefault(); }
            set { this._maximumIndividualPlayerLatencyMilliseconds = value; }
        }

        // Check to see if MaximumIndividualPlayerLatencyMilliseconds property is set
        internal bool IsSetMaximumIndividualPlayerLatencyMilliseconds()
        {
            return this._maximumIndividualPlayerLatencyMilliseconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyDurationSeconds. 
        /// <para>
        /// The length of time, in seconds, that the policy is enforced while placing a new game
        /// session. A null value for this property means that the policy is enforced until the
        /// queue times out.
        /// </para>
        /// </summary>
        public int PolicyDurationSeconds
        {
            get { return this._policyDurationSeconds.GetValueOrDefault(); }
            set { this._policyDurationSeconds = value; }
        }

        // Check to see if PolicyDurationSeconds property is set
        internal bool IsSetPolicyDurationSeconds()
        {
            return this._policyDurationSeconds.HasValue; 
        }

    }
}