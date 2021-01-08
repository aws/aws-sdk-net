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
    /// Container for the parameters to the CreateGameSessionQueue operation.
    /// Establishes a new queue for processing requests to place new game sessions. A queue
    /// identifies where new game sessions can be hosted -- by specifying a list of destinations
    /// (fleets or aliases) -- and how long requests can wait in the queue before timing out.
    /// You can set up a queue to try to place game sessions on fleets in multiple Regions.
    /// To add placement requests to a queue, call <a>StartGameSessionPlacement</a> and reference
    /// the queue name.
    /// 
    ///  
    /// <para>
    ///  <b>Destination order.</b> When processing a request for a game session, Amazon GameLift
    /// tries each destination in order until it finds one with available resources to host
    /// the new game session. A queue's default order is determined by how destinations are
    /// listed. The default order is overridden when a game session placement request provides
    /// player latency information. Player latency information enables Amazon GameLift to
    /// prioritize destinations where players report the lowest average latency, as a result
    /// placing the new game session where the majority of players will have the best possible
    /// gameplay experience.
    /// </para>
    ///  
    /// <para>
    ///  <b>Player latency policies.</b> For placement requests containing player latency
    /// information, use player latency policies to protect individual players from very high
    /// latencies. With a latency cap, even when a destination can deliver a low latency for
    /// most players, the game is not placed where any individual player is reporting latency
    /// higher than a policy's maximum. A queue can have multiple latency policies, which
    /// are enforced consecutively starting with the policy with the lowest latency cap. Use
    /// multiple policies to gradually relax latency controls; for example, you might set
    /// a policy with a low latency cap for the first 60 seconds, a second policy with a higher
    /// cap for the next 60 seconds, etc. 
    /// </para>
    ///  
    /// <para>
    /// To create a new queue, provide a name, timeout value, a list of destinations and,
    /// if desired, a set of latency policies. If successful, a new queue object is returned.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-design.html">
    /// Design a Game Session Queue</a> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-creating.html">
    /// Create a Game Session Queue</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations</b> 
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
    public partial class CreateGameSessionQueueRequest : AmazonGameLiftRequest
    {
        private List<GameSessionQueueDestination> _destinations = new List<GameSessionQueueDestination>();
        private string _name;
        private List<PlayerLatencyPolicy> _playerLatencyPolicies = new List<PlayerLatencyPolicy>();
        private List<Tag> _tags = new List<Tag>();
        private int? _timeoutInSeconds;

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// A list of fleets that can be used to fulfill game session placement requests in the
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label that is associated with game session queue. Queue names must be
        /// unique within each Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// A collection of latency policies to apply when processing game sessions placement
        /// requests with player latency information. Multiple policies are evaluated in order
        /// of the maximum latency value, starting with the lowest latency values. With just one
        /// policy, the policy is enforced at the start of the game session placement for the
        /// duration period. With multiple policies, each policy is enforced consecutively for
        /// its duration period. For example, a queue might enforce a 60-second policy followed
        /// by a 120-second policy, and then no policy for the remainder of the placement. A player
        /// latency policy must set a value for <code>MaximumIndividualPlayerLatencyMilliseconds</code>.
        /// If none is set, this API request fails.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of labels to assign to the new game session queue resource. Tags are developer-defined
        /// key-value pairs. Tagging AWS resources are useful for resource management, access
        /// management and cost allocation. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">
        /// Tagging AWS Resources</a> in the <i>AWS General Reference</i>. Once the resource is
        /// created, you can use <a>TagResource</a>, <a>UntagResource</a>, and <a>ListTagsForResource</a>
        /// to add, remove, and view tags. The maximum tag limit may be lower than stated. See
        /// the AWS General Reference for actual tagging limits.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutInSeconds. 
        /// <para>
        /// The maximum time, in seconds, that a new game session placement request remains in
        /// the queue. When a request exceeds this time, the game session placement changes to
        /// a <code>TIMED_OUT</code> status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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