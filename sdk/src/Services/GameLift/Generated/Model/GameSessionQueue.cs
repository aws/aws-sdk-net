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
    /// Configuration of a queue that is used to process game session placement requests.
    /// The queue configuration identifies several game features:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The destinations where a new game session can potentially be hosted. Amazon GameLift
    /// tries these destinations in an order based on either the queue's default order or
    /// player latency information, if provided in a placement request. With latency information,
    /// Amazon GameLift can place game sessions where the majority of players are reporting
    /// the lowest possible latency. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The length of time that placement requests can wait in the queue before timing out.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A set of optional latency policies that protect individual players from high latencies,
    /// preventing game sessions from being placed where any individual player is reporting
    /// latency higher than a policy's maximum.
    /// </para>
    ///  </li> </ul> <ul> <li> 
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
    public partial class GameSessionQueue
    {
        private List<GameSessionQueueDestination> _destinations = new List<GameSessionQueueDestination>();
        private string _gameSessionQueueArn;
        private string _name;
        private List<PlayerLatencyPolicy> _playerLatencyPolicies = new List<PlayerLatencyPolicy>();
        private int? _timeoutInSeconds;

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// List of fleets that can be used to fulfill game session placement requests in the
        /// queue. Fleets are identified by either a fleet ARN or a fleet alias ARN. Destinations
        /// are listed in default preference order.
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
        /// Gets and sets the property GameSessionQueueArn. 
        /// <para>
        /// Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a game session queue and uniquely identifies it. Format is <code>arn:aws:gamelift:&lt;region&gt;::fleet/fleet-a1234567-b8c9-0d1e-2fa3-b45c6d7e8912</code>.
        /// </para>
        /// </summary>
        public string GameSessionQueueArn
        {
            get { return this._gameSessionQueueArn; }
            set { this._gameSessionQueueArn = value; }
        }

        // Check to see if GameSessionQueueArn property is set
        internal bool IsSetGameSessionQueueArn()
        {
            return this._gameSessionQueueArn != null;
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
        /// and then no policy for the remainder of the placement. 
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