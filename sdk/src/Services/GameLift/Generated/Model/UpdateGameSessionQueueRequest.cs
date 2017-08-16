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
    /// Container for the parameters to the UpdateGameSessionQueue operation.
    /// Updates settings for a game session queue, which determines how new game session requests
    /// in the queue are processed. To update settings, specify the queue name to be updated
    /// and provide the new settings. When updating destinations, provide a complete list
    /// of destinations. 
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
    public partial class UpdateGameSessionQueueRequest : AmazonGameLiftRequest
    {
        private List<GameSessionQueueDestination> _destinations = new List<GameSessionQueueDestination>();
        private string _name;
        private List<PlayerLatencyPolicy> _playerLatencyPolicies = new List<PlayerLatencyPolicy>();
        private int? _timeoutInSeconds;

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// List of fleets that can be used to fulfill game session placement requests in the
        /// queue. Fleets are identified by either a fleet ARN or a fleet alias ARN. Destinations
        /// are listed in default preference order. When updating this list, provide a complete
        /// list of destinations.
        /// </para>
        /// </summary>
        public List<GameSessionQueueDestination> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && this._destinations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Descriptive label that is associated with game session queue. Queue names must be
        /// unique within each region.
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
        /// Gets and sets the property PlayerLatencyPolicies. 
        /// <para>
        /// Collection of latency policies to apply when processing game sessions placement requests
        /// with player latency information. Multiple policies are evaluated in order of the maximum
        /// latency value, starting with the lowest latency values. With just one policy, it is
        /// enforced at the start of the game session placement for the duration period. With
        /// multiple policies, each policy is enforced consecutively for its duration period.
        /// For example, a queue might enforce a 60-second policy followed by a 120-second policy,
        /// and then no policy for the remainder of the placement. When updating policies, provide
        /// a complete collection of policies.
        /// </para>
        /// </summary>
        public List<PlayerLatencyPolicy> PlayerLatencyPolicies
        {
            get { return this._playerLatencyPolicies; }
            set { this._playerLatencyPolicies = value; }
        }

        // Check to see if PlayerLatencyPolicies property is set
        internal bool IsSetPlayerLatencyPolicies()
        {
            return this._playerLatencyPolicies != null && this._playerLatencyPolicies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutInSeconds. 
        /// <para>
        /// Maximum time, in seconds, that a new game session placement request remains in the
        /// queue. When a request exceeds this time, the game session placement changes to a <code>TIMED_OUT</code>
        /// status.
        /// </para>
        /// </summary>
        public int TimeoutInSeconds
        {
            get { return this._timeoutInSeconds.GetValueOrDefault(); }
            set { this._timeoutInSeconds = value; }
        }

        // Check to see if TimeoutInSeconds property is set
        internal bool IsSetTimeoutInSeconds()
        {
            return this._timeoutInSeconds.HasValue; 
        }

    }
}